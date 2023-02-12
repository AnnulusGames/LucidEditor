using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;
using UnityEditor.IMGUI.Controls;

namespace AnnulusGames.LucidTools.Editor.Experimental
{
    public class TreeMenu
    {
        private List<TreeMenuItem> baseElements = new List<TreeMenuItem>();
        private SimpleTreeView simpleTreeView;
        private TreeViewState state;

        private int currentId = 0;
        private List<TreeMenuItem> _selectedItems = new List<TreeMenuItem>();

        public IReadOnlyList<TreeMenuItem> selectedItems => Array.AsReadOnly(_selectedItems.ToArray());
        public event Action<IReadOnlyList<TreeMenuItem>> onSelectionChanged;

        public Action<Rect, TreeMenuItem> drawItemCallback;
        public Func<TreeMenuItem, float> itemHeightCallback;

        public string searchString
        {
            get
            {
                return _searchString;
            }
            set
            {
                _searchString = value;
                if (simpleTreeView != null) simpleTreeView.searchString = _searchString;
            }
        }
        private string _searchString;

        public void AddItem(string path)
        {
            string[] hierarchy = path.Split('/');
            string currentPath = string.Empty;
            TreeMenuItem parent = null;

            for (int i = 0; i < hierarchy.Length; i++)
            {
                currentPath += hierarchy[i];

                if (parent == null)
                {
                    parent = baseElements.Find(x => x.name == hierarchy[i]);
                    if (parent == null)
                    {
                        parent = CreateItem(currentPath);
                        baseElements.Add(parent);
                    }
                }
                else
                {
                    TreeMenuItem newParent = null;
                    foreach (TreeMenuItem child in parent.childElements)
                    {
                        if (child.name == hierarchy[i])
                        {
                            newParent = child;
                            parent = child;
                            break;
                        }
                    }
                    if (newParent == null)
                    {
                        newParent = CreateItem(currentPath);
                        parent.Add(newParent);
                        parent = newParent;
                    }
                }

                currentPath += '/';
            }
        }

        private TreeMenuItem CreateItem(string path)
        {
            TreeMenuItem item = new TreeMenuItem(path);
            item.id = currentId;
            currentId++;
            return item;
        }

        public void Show(Rect position)
        {
            if (simpleTreeView == null) Setup();
            simpleTreeView.OnGUI(position);
        }

        public void ShowLayout(params GUILayoutOption[] options)
        {
            if (simpleTreeView == null) Setup();
            simpleTreeView.OnGUI(EditorGUILayout.GetControlRect(false, simpleTreeView.totalHeight, options));
        }

        public void Setup()
        {
            state = new TreeViewState();
            simpleTreeView = new SimpleTreeView(state);
            simpleTreeView.searchString = _searchString;
            simpleTreeView.Setup(baseElements.ToArray());
            simpleTreeView.onSelectionChanged += (idList) =>
            {
                _selectedItems.Clear();
                foreach (int id in idList)
                {
                    TreeMenuItem item = FindItem(id);
                    if (item != null) _selectedItems.Add(item);
                }
                onSelectionChanged?.Invoke(_selectedItems);
            };

            if (drawItemCallback != null)
            {
                simpleTreeView.drawItemCallback = (rect, id) =>
                {
                    drawItemCallback.Invoke(rect, FindItem(id));
                };
            }

            if (itemHeightCallback != null)
            {
                simpleTreeView.itemHeightCallback = (id) =>
                {
                    return itemHeightCallback.Invoke(FindItem(id));
                };
            }
        }

        private TreeMenuItem FindItem(int id)
        {
            TreeMenuItem item = null;
            foreach(TreeMenuItem child in baseElements)
            {
                item = FindItem(child, id);
                if (item != null) return item;
            }
            return null;
        }

        private TreeMenuItem FindItem(TreeMenuItem root, int id)
        {
            if (root.id == id) return root;
            TreeMenuItem item = null;

            foreach (TreeMenuItem child in root.childElements)
            {
                item = FindItem(child, id);
                if (item != null) return item;
            }

            return null;
        }

    }

    public class TreeMenuItem
    {
        public TreeMenuItem(string path)
        {
            this.path = path;
            depth = path.Count(x => x == '/');
            _name = path.Split('/').Last();
        }

        public readonly string path;
        public readonly int depth;

        internal int id;

        public string name
        {
            get
            {
                return _name;
            }
        }
        private string _name;

        public TreeMenuItem parent { get; private set; }
        private List<TreeMenuItem> _childElements = new List<TreeMenuItem>();
        public IReadOnlyList<TreeMenuItem> childElements => _childElements;

        public void Add(TreeMenuItem child)
        {
            if (child.parent != null)
            {
                child.parent.Remove(child);
            }

            _childElements.Add(child);
            child.parent = this;
        }

        public bool Remove(TreeMenuItem child)
        {
            if (_childElements.Contains(child))
            {
                _childElements.Remove(child);
                child.parent = null;
                return true;
            }
            return false;
        }
    }
}