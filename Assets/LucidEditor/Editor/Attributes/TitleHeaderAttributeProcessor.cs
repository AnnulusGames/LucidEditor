using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(TitleHeaderAttribute))]
    public class TitleHeaderAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeDrawProperty()
        {
            EditorGUILayout.Space(7);
            LucidEditorGUILayout.TitleHeader(((TitleHeaderAttribute)attribute).title);
        }
    }
}