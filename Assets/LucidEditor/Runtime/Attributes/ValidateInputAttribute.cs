using System;
using UnityEngine;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ValidateInputAttribute : Attribute
    {
        public readonly string condition;
        public readonly string message;
        public readonly HelpBoxMessageType type = HelpBoxMessageType.Error;

        public ValidateInputAttribute(string condition)
        {
            this.condition = condition;
        }

        public ValidateInputAttribute(string condition, string message)
        {
            this.condition = condition;
            this.message = message;
        }

        public ValidateInputAttribute(string condition, string message, HelpBoxMessageType type)
        {
            this.condition = condition;
            this.message = message;
            this.type = type;
        }
    }
}