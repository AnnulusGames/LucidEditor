using System;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method)]
    public class HorizontalGroupAttribute : PropertyGroupAttribute
    {
        public HorizontalGroupAttribute(string groupName) : base(groupName) { }
    }
}