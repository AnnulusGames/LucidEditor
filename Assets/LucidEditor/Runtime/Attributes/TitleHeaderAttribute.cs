using System;
using UnityEngine;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = true)]
    public class TitleHeaderAttribute : Attribute
    {
        public readonly string title;

        public TitleHeaderAttribute(string title)
        {
            this.title = title;
        }
    }
}