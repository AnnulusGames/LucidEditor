using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(HideIfAttribute))]
    public class HideIfAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeDrawProperty()
        {
            HideIfAttribute hideIf = (HideIfAttribute)attribute;
            property.isHidden |= ReflectionUtil.GetValueBool(property.parentObject, hideIf.condition);
        }
    }
}