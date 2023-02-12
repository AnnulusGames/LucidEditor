using System;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field)]
    public class LabelWidthAttribute : Attribute
    {
        public readonly float width;

        public LabelWidthAttribute(float width)
        {
            this.width = width;
        }
    }
}