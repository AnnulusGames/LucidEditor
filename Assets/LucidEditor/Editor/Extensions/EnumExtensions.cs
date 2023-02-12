using UnityEngine;
using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    public static class InspectorColorExtensions
    {
        public static Color ToColor(this InspectorColor color)
        {
            switch (color)
            {
                default:
                case InspectorColor.Clear: return Color.clear;

                case InspectorColor.Red: return Color.red;
                case InspectorColor.Green: return Color.green;
                case InspectorColor.Blue: return Color.blue;
                case InspectorColor.Orange: return new Color(1f, 0.5f, 0f);
                case InspectorColor.Purple: return new Color(0.5f, 0f, 1f);
                case InspectorColor.Pink: return new Color(1f, 0.4f, 1f);
                case InspectorColor.Indigo: return new Color(0.3f, 0f, 0.5f);
                case InspectorColor.Cyan: return Color.cyan;
                case InspectorColor.Magenta: return Color.magenta;
                case InspectorColor.Yellow: return Color.yellow;
                case InspectorColor.White: return Color.white;
                case InspectorColor.Gray: return Color.gray;
                case InspectorColor.Grey: return Color.grey;
                case InspectorColor.Black: return Color.black;
                case InspectorColor.EditorText: return EditorColors.text;
                case InspectorColor.EditorTextSelected: return EditorColors.textSelected;
                case InspectorColor.EditorBackground: return EditorColors.background;
                case InspectorColor.EditorLine: return EditorColors.line;
                case InspectorColor.EditorThinLine: return EditorColors.thinLine;
                case InspectorColor.EditorWarning: return EditorColors.warning;
                case InspectorColor.EditorError: return EditorColors.error;
            }
        }
    }

    public static class InspectorButtonSizeExtensions
    {
        public static float GetHeight(this InspectorButtonSize size)
        {
            switch (size)
            {
                default:
                case InspectorButtonSize.Small:
                    return EditorGUIUtility.singleLineHeight;
                case InspectorButtonSize.Medium:
                    return EditorGUIUtility.singleLineHeight * 1.5f;
                case InspectorButtonSize.Large:
                    return EditorGUIUtility.singleLineHeight * 2f;
                case InspectorButtonSize.ExtraLarge:
                    return EditorGUIUtility.singleLineHeight * 4f;
            }
        }
    }
}