using System;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method)]
    public class BoxGroupAttribute : PropertyGroupAttribute
    {
        public BoxGroupAttribute(string groupName) : base(groupName) { }
    }
}