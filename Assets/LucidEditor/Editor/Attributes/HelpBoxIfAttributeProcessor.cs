using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(HelpBoxIfAttribute))]
    public class HelpBoxIfAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeDrawProperty()
        {
            HelpBoxIfAttribute helpBoxIf = (HelpBoxIfAttribute)attribute;
            if (ReflectionUtil.GetValueBool(property.parentObject, helpBoxIf.condition))
            {
                EditorGUILayout.HelpBox(helpBoxIf.message, (MessageType)helpBoxIf.type);
            }
        }
    }
}