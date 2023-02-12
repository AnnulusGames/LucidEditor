using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(DisableIfAttribute))]
    public class DisableIfAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeDrawProperty()
        {
            DisableIfAttribute disableIf = (DisableIfAttribute)attribute;
            property.isEditable = !ReflectionUtil.GetValueBool(property.parentObject, disableIf.condition);
        }
    }
}