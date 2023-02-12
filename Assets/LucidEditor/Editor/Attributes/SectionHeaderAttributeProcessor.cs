using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(SectionHeaderAttribute))]
    public class SectionHeaderAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeDrawProperty()
        {
            EditorGUILayout.Space(7);
            LucidEditorGUILayout.SectionHeader(((SectionHeaderAttribute)attribute).title);
        }
    }
}