using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;
using UnityEditor.IMGUI.Controls;

namespace AnnulusGames.LucidTools.Editor
{
    public class SerializeReferenceDropdownItem : AdvancedDropdownItem
    {
        public readonly Type type;
        public SerializeReferenceDropdownItem(Type type, string name) : base(name)
        {
            this.type = type;
            if (type != null) icon = (Texture2D)EditorIcons.CsScriptIcon.image;
        }
    }

    public class SerializeReferenceDropdown : AdvancedDropdown
    {
        private static readonly float headerHeight = EditorGUIUtility.singleLineHeight * 2f;
        private static readonly int maxNamespaceNestCount = 16;
        private static readonly string nullDisplayName = "(Null)";

        private Type[] types;
        public event Action<SerializeReferenceDropdownItem> onItemSelected;

        public static void AddTo(AdvancedDropdownItem root, IEnumerable<Type> types)
        {
            int itemCount = 0;
            var nullItem = new SerializeReferenceDropdownItem(null, nullDisplayName)
            {
                id = itemCount++
            };
            root.AddChild(nullItem);

            var typeArray = types.OrderBy(x => x.FullName);

            bool isSingleNamespace = true;
            string[] namespaces = new string[maxNamespaceNestCount];
            foreach (Type type in typeArray)
            {
                string[] splittedTypePath = GetSplittedTypePath(type);
                if (splittedTypePath.Length <= 1)
                {
                    continue;
                }
                for (int i = 0; (splittedTypePath.Length - 1) > i; i++)
                {
                    string ns = namespaces[i];
                    if (ns == null)
                    {
                        namespaces[i] = splittedTypePath[i];
                    }
                    else if (ns != splittedTypePath[i])
                    {
                        isSingleNamespace = false;
                        break;
                    }
                }

                if (!isSingleNamespace)
                {
                    break;
                }
            }

            foreach (Type type in typeArray)
            {
                string[] splittedTypePath = GetSplittedTypePath(type);
                if (splittedTypePath.Length == 0) continue;

                AdvancedDropdownItem parent = root;

                if (!isSingleNamespace)
                {
                    for (int i = 0; (splittedTypePath.Length - 1) > i; i++)
                    {
                        AdvancedDropdownItem foundItem = GetItem(parent, splittedTypePath[i]);
                        if (foundItem != null)
                        {
                            parent = foundItem;
                        }
                        else
                        {
                            var newItem = new AdvancedDropdownItem(splittedTypePath[i])
                            {
                                id = itemCount++,
                            };
                            parent.AddChild(newItem);
                            parent = newItem;
                        }
                    }
                }

                var item = new SerializeReferenceDropdownItem(type, ObjectNames.NicifyVariableName(splittedTypePath[splittedTypePath.Length - 1]))
                {
                    id = itemCount++
                };
                parent.AddChild(item);
            }
        }

        static AdvancedDropdownItem GetItem(AdvancedDropdownItem parent, string name)
        {
            foreach (AdvancedDropdownItem item in parent.children)
            {
                if (item.name == name) return item;
            }
            return null;
        }

        public SerializeReferenceDropdown(IEnumerable<Type> types, int maxLineCount, AdvancedDropdownState state) : base(state)
        {
            SetTypes(types);
            minimumSize = new Vector2(minimumSize.x, EditorGUIUtility.singleLineHeight * maxLineCount + headerHeight);
        }

        public void SetTypes(IEnumerable<Type> types)
        {
            this.types = types.ToArray();
        }

        protected override AdvancedDropdownItem BuildRoot()
        {
            var root = new AdvancedDropdownItem("Select Type");
            AddTo(root, types);
            return root;
        }

        protected override void ItemSelected(AdvancedDropdownItem item)
        {
            base.ItemSelected(item);
            if (item is SerializeReferenceDropdownItem dropdownItem)
            {
                onItemSelected?.Invoke(dropdownItem);
            }
        }

        private static string[] GetSplittedTypePath(Type type)
        {
            int splitIndex = type.FullName.LastIndexOf('.');
            if (splitIndex >= 0)
            {
                return new string[] { type.FullName.Substring(0, splitIndex), type.FullName.Substring(splitIndex + 1) };
            }
            else
            {
                return new string[] { type.Name };
            }
        }

    }
}