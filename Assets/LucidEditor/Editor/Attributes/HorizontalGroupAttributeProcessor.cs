using UnityEngine;
using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomGroupProcessor(typeof(HorizontalGroupAttribute))]
    public class HorizontalGroupAttributeProcessor : PropertyGroupProcessor
    {
        public override void BeginPropertyGroup()
        {
            HorizontalGroupAttribute horizontalGroupAttribute = (HorizontalGroupAttribute)attribute;
            
            LucidEditorGUILayout.BeginLayoutIndent(EditorGUI.indentLevel);
            EditorGUILayout.BeginHorizontal();
            LucidEditorUtility.horizontalGroupCount++;
        }

        public override void EndPropertyGroup()
        {
            LucidEditorUtility.horizontalGroupCount--;
            EditorGUILayout.EndHorizontal();
            LucidEditorGUILayout.EndLayoutIndent();
        }
    }
}