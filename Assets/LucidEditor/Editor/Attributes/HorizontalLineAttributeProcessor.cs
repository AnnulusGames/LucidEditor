using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(HorizontalLineAttribute))]
    public class HorizontalLineAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeDrawProperty()
        {
            HorizontalLineAttribute horizontalLine = (HorizontalLineAttribute)attribute;
            
            EditorGUILayout.Space(EditorGUIUtility.standardVerticalSpacing);
            if (horizontalLine.useCustomColor)
            {
                LucidEditorGUILayout.Line(horizontalLine.customColor);
            }
            else
            {
                LucidEditorGUILayout.Line(horizontalLine.color.ToColor());
            }
            EditorGUILayout.Space(EditorGUIUtility.standardVerticalSpacing);
        }
    }
}