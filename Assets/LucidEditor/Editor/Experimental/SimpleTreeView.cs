using System;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace AnnulusGames.LucidTools.Editor.Experimental
{
    internal class SimpleTreeView : TreeView
    {
        private TreeMenuItem[] baseElements;

        public Action<Rect, int> drawItemCallback;
        public Func<int, float> itemHeightCallback;
        public event Action<IList<int>> onSelectionChanged;

        public SimpleTreeView(TreeViewState treeViewState) : base(treeViewState) { }

        public void Setup(TreeMenuItem[] baseElements)
        {
            this.baseElements = baseElements;
            Reload();
        }

        protected override TreeViewItem BuildRoot()
        {
            return new TreeViewItem { id = -1, depth = -1, displayName = "Root" };
        }

        protected override void RowGUI(RowGUIArgs args)
        {
            if (drawItemCallback != null)
            {
                Rect contentRect = args.rowRect;
                contentRect.width -= GetContentIndent(args.item);
                contentRect.x += GetContentIndent(args.item);

                drawItemCallback.Invoke(contentRect, args.item.id);
            }
            else
            {
                base.RowGUI(args);
            }
        }

        protected override float GetCustomRowHeight(int row, TreeViewItem item)
        {
            if (itemHeightCallback != null)
            {
                return itemHeightCallback.Invoke(item.id);
            }
            return base.GetCustomRowHeight(row, item);
        }

        protected override IList<TreeViewItem> BuildRows(TreeViewItem root)
        {
            var rows = GetRows() ?? new List<TreeViewItem>();
            rows.Clear();

            foreach (var baseElement in baseElements)
            {
                var baseItem = CreateTreeViewItem(baseElement);
                root.AddChild(baseItem);
                rows.Add(baseItem);
                if (baseElement.childElements.Count > 0)
                {
                    if (IsExpanded(baseItem.id))
                    {
                        AddChildrenRecursive(baseElement, baseItem, rows);
                    }
                    else
                    {
                        baseItem.children = CreateChildListForCollapsedParent();
                    }
                }
            }

            SetupDepthsFromParentsAndChildren(root);

            return rows;
        }

        protected override void SelectionChanged(IList<int> selectedIds)
        {
            onSelectionChanged?.Invoke(selectedIds);
        }

        private void AddChildrenRecursive(TreeMenuItem model, TreeViewItem item, IList<TreeViewItem> rows)
        {
            foreach (var childElement in model.childElements)
            {
                var childItem = CreateTreeViewItem(childElement);
                item.AddChild(childItem);
                rows.Add(childItem);
                if (childElement.childElements.Count > 0)
                {
                    if (IsExpanded(childElement.id))
                    {
                        AddChildrenRecursive(childElement, childItem, rows);
                    }
                    else
                    {
                        childItem.children = CreateChildListForCollapsedParent();
                    }
                }
            }
        }

        private TreeViewItem CreateTreeViewItem(TreeMenuItem model)
        {
            return new TreeViewItem { id = model.id, displayName = model.name };
        }
    }
}