using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(LabelWidthAttribute))]
    public class LabelWidthAttributeProcessor : PropertyProcessor
    {
        private float defaultWidth;

        public override void OnBeforeDrawProperty()
        {
            defaultWidth = EditorGUIUtility.labelWidth;
            EditorGUIUtility.labelWidth = ((LabelWidthAttribute)attribute).width;
        }

        public override void OnAfterDrawProperty()
        {
            EditorGUIUtility.labelWidth = defaultWidth;
        }
    }
}