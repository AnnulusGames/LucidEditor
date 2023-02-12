using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(LabelTextAttribute))]
    public class LabelTextAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeDrawProperty()
        {
            property.displayName = ((LabelTextAttribute)attribute).label;
        }
    }
}