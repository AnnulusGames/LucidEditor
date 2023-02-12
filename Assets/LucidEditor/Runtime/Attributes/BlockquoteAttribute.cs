using System;
using UnityEngine;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method, AllowMultiple = true)]
    public class BlockquoteAttribute : Attribute
    {
        public readonly string text;

        public BlockquoteAttribute(string text)
        {
            this.text = text;
        }
    }
}