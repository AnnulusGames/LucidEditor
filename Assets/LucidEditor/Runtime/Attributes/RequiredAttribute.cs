using System;
using UnityEngine;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field)]
    public class RequiredAttribute : Attribute
    {
        public readonly string message = null;
        public RequiredAttribute() { }
        public RequiredAttribute(string message)
        {
            this.message = message;
        }
    }
}