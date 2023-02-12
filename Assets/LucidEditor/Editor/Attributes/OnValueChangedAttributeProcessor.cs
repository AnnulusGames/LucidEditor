using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(OnValueChangedAttribute))]
    public class OnValueChangedAttributeProcessor : PropertyProcessor
    {
        public override void OnAfterDrawProperty()
        {
            if (property.changed)
            {
                OnValueChangedAttribute onValueChanged = (OnValueChangedAttribute)attribute;
                ReflectionUtil.Invoke(property.parentObject, onValueChanged.methodName, property.serializedProperty.GetValue<object>());
            }
        }
    }
}
