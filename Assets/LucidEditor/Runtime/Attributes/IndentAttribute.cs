using System;
using UnityEngine;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method)]
    public class IndentAttribute : Attribute
    {
        public readonly int indent;

        public IndentAttribute()
        {
            this.indent = 1;
        }
        
        public IndentAttribute(int indent)
        {
            this.indent = indent;
        }
    }
}