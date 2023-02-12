using UnityEngine;
using System;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method)]
    public class GroupAttribute : PropertyGroupAttribute
    {
        public GroupAttribute(string groupName) : base(groupName) { }
    }
}