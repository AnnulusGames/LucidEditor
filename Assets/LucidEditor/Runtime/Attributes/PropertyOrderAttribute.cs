using System;
using UnityEngine;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method)]
    public class PropertyOrderAttribute : Attribute
    {
        public readonly int propertyOrder;

        public PropertyOrderAttribute(int propertyOrder)
        {
            this.propertyOrder = propertyOrder;
        }
    }
}