using UnityEngine;
using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomGroupProcessor(typeof(GroupAttribute))]
    public class GroupAttributeProcessor : PropertyGroupProcessor
    {
        public override void BeginPropertyGroup()
        {
            LucidEditorGUILayout.BeginLayoutIndent(EditorGUI.indentLevel);
            EditorGUILayout.BeginVertical(GUI.skin.box, GUILayout.MinWidth(0));
        }

        public override void EndPropertyGroup()
        {
            EditorGUILayout.EndVertical();
            LucidEditorGUILayout.EndLayoutIndent();
            
            EditorGUILayout.Space(2);
        }
    }
}