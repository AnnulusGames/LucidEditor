using System;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method)]
    public class TabGroupAttribute : PropertyGroupAttribute
    {
        public readonly string tabName;

        public TabGroupAttribute(string groupName, string tabName) : base(groupName)
        {
            this.tabName = tabName;
        }
    }
}