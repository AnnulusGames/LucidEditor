using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(HideLabelAttribute))]
    public class HideLabelAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeDrawProperty()
        {
            property.hideLabel = true;
        }
    }
}