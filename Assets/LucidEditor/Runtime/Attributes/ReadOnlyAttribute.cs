using System;
using UnityEngine;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method)]
    public class ReadOnlyAttribute : Attribute { }
}