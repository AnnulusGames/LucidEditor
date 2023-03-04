using System;
using UnityEngine;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = true)]
    public class GUIColorAttribute : Attribute
    {
        public readonly InspectorColor color = InspectorColor.EditorText;
        public readonly bool useCustomColor;
        public readonly Color customColor;

        public GUIColorAttribute() { }
        public GUIColorAttribute(InspectorColor color)
        {
            this.color = color;
        }
        public GUIColorAttribute(float r, float g, float b)
        {
            useCustomColor = true;
            customColor = new Color(r, g, b);
        }
        public GUIColorAttribute(float r, float g, float b, float a)
        {
            useCustomColor = true;
            customColor = new Color(r, g, b, a);
        }
    }
}