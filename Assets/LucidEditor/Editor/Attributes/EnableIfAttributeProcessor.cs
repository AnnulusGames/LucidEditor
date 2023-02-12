using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(EnableIfAttribute))]
    public class EnableIfAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeDrawProperty()
        {
            EnableIfAttribute enableIf = (EnableIfAttribute)attribute;
            property.isEditable = ReflectionUtil.GetValueBool(property.parentObject, enableIf.condition);
        }
    }
}