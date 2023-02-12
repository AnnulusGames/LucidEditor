using UnityEngine;
using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomGroupProcessor(typeof(FoldoutGroupAttribute))]
    public class FoldoutGroupAttributeProcessor : PropertyGroupProcessor
    {
        private LocalPersistentData<bool> expanded;

        public override void Initialize()
        {
            expanded = GetLocalPersistentData<bool>("exanded");
        }

        public override void BeginPropertyGroup()
        {
            LucidEditorGUILayout.BeginLayoutIndent(EditorGUI.indentLevel);
            expanded.Value = LucidEditorGUILayout.BeginFoldoutGroup(expanded.Value, attribute.name, GUILayout.MinWidth(0));
            group.isExpanded = expanded.Value;
        }

        public override void EndPropertyGroup()
        {
            LucidEditorGUILayout.EndFoldoutGroup();
            LucidEditorGUILayout.EndLayoutIndent();

            EditorGUILayout.Space(2);
        }
    }
}