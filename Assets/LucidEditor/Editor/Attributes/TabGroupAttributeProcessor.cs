using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomGroupProcessor(typeof(TabGroupAttribute))]
    public class TabGroupAttributeProcessor : PropertyGroupProcessor
    {
        private LocalPersistentData<int> selected;
        private string[] tabArray;

        public override void Initialize()
        {
            selected = GetLocalPersistentData<int>("selected");

            List<string> tabList = new List<string>();
            foreach (InspectorProperty property in group.childProperties)
            {
                TabGroupAttribute att = property.GetAttribute<TabGroupAttribute>();
                if (!tabList.Contains(att.tabName)) tabList.Add(att.tabName);
            }
            tabArray = tabList.ToArray();
        }

        public override void BeginPropertyGroup()
        {
            LucidEditorGUILayout.BeginLayoutIndent(EditorGUI.indentLevel);
            selected.Value = LucidEditorGUILayout.BeginTabGroup(selected.Value, tabArray, GUILayout.MinWidth(0));

            foreach (InspectorProperty property in group.childProperties)
            {
                TabGroupAttribute att = property.GetAttribute<TabGroupAttribute>();
                if (att != null)
                {
                    property.isHidden |= att.tabName != tabArray[selected.Value];
                }
            }
        }

        public override void EndPropertyGroup()
        {
            LucidEditorGUILayout.EndFoldoutGroup();
            LucidEditorGUILayout.EndLayoutIndent();

            EditorGUILayout.Space(2);
        }
    }
}