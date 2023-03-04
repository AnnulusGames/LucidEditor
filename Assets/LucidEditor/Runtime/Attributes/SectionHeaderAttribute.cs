using System;
using UnityEngine;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = true)]
    public class SectionHeaderAttribute : Attribute
    {
        public readonly string title;

        public SectionHeaderAttribute(string title)
        {
            this.title = title;
        }
    }
}