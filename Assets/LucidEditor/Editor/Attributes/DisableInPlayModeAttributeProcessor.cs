using UnityEngine;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    [CustomAttributeProcessor(typeof(DisableInPlayModeAttribute))]
    public class DisableInPlayModeAttributeProcessor : PropertyProcessor
    {
        public override void OnBeforeDrawProperty()
        {
            DisableInPlayModeAttribute disableInPlayMode = (DisableInPlayModeAttribute)attribute;
            property.isEditable = !Application.isPlaying;
        }
    }
}