using System;
using UnityEngine;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = true)]
    public class HelpBoxIfAttribute : Attribute
    {
        public readonly string condition;
        public readonly string message;
        public readonly HelpBoxMessageType type;

        public HelpBoxIfAttribute(string condition, string message)
        {
            this.condition = condition;
            this.message = message;
            this.type = HelpBoxMessageType.Info;
        }

        public HelpBoxIfAttribute(string condition, string message, HelpBoxMessageType type)
        {
            this.condition = condition;
            this.message = message;
            this.type = type;
        }
    }
}