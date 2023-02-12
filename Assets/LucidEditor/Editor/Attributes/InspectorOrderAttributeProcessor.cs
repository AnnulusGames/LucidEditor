using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(InspectorOrderAttribute))]
    public class InspectorOrderAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeInspectorGUI()
        {
            InspectorOrderAttribute inspectorOrder = (InspectorOrderAttribute)attribute;
            property.order = inspectorOrder.inspectorOrder;
        }
    }
}