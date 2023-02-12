using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(ShowIfAttribute))]
    public class ShowIfAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeDrawProperty()
        {
            ShowIfAttribute showIf = (ShowIfAttribute)attribute;
            property.isHidden |= !ReflectionUtil.GetValueBool(property.parentObject, showIf.condition);
        }
    }
}