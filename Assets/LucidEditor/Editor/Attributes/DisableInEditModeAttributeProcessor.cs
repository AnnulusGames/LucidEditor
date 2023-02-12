using UnityEngine;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(DisableInEditModeAttribute))]
    public class DisableInEditModeAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeDrawProperty()
        {
            DisableInEditModeAttribute disableInEditMode = (DisableInEditModeAttribute)attribute;
            property.isEditable = Application.isPlaying;
        }
    }
}