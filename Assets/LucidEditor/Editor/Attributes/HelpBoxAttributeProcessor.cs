using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(HelpBoxAttribute))]
    public class HelpBoxAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeDrawProperty()
        {
            HelpBoxAttribute helpBox = (HelpBoxAttribute)attribute;
            EditorGUILayout.HelpBox(helpBox.message, (MessageType)helpBox.type);
        }
    }
}