using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(ReadOnlyAttribute))]
    public class ReadOnlyAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeDrawProperty()
        {
            property.isEditable = false;
        }
    }
}