using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(IndentAttribute))]
    public class IndentAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeDrawProperty()
        {
            IndentAttribute indent = (IndentAttribute)attribute;
            property.indent = indent.indent;
        }
    }
}