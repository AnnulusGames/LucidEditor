using System;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method)]
    public class OnValueChangedAttribute : Attribute
    {
        public readonly string methodName;

        public OnValueChangedAttribute(string methodName)
        {
            this.methodName = methodName;
        }
    }
}