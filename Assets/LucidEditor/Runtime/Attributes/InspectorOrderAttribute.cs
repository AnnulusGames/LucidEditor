using System;
using UnityEngine;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method)]
    public class InspectorOrderAttribute : Attribute
    {
        public readonly int inspectorOrder;

        public InspectorOrderAttribute(int inspectorOrder)
        {
            this.inspectorOrder = inspectorOrder;
        }
    }
}