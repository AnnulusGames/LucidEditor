using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(ValidateInputAttribute))]
    public class ValidateInputAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeDrawProperty()
        {
            ValidateInputAttribute validateInput = (ValidateInputAttribute)attribute;
            if (!ReflectionUtil.InvokeBool(property.parentObject, validateInput.condition, property.serializedProperty.GetValue<object>()))
            {
                EditorGUILayout.HelpBox(validateInput.message == null ? $"{property.displayName} is not valid." : validateInput.message, (MessageType)validateInput.type);
            }
        }
    }
}
