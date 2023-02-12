using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace AnnulusGames.LucidTools.Editor
{
    public static class LucidEditorUtility
    {
        private static Stack<int> indentStack = new Stack<int>();
        private static Stack<Color> guiColorStack = new Stack<Color>();

        internal static int horizontalGroupCount;

        public static float singleIndentWidth { get; set; } = 15f;
        public static float currentIndentWidth
        {
            get
            {
                return EditorGUI.indentLevel * singleIndentWidth;
            }
        }
        
        public static void PushIndentLevel(int indentLevel)
        {
            indentStack.Push(EditorGUI.indentLevel);
            EditorGUI.indentLevel = indentLevel;
        }

        public static void PopIndentLevel()
        {
            EditorGUI.indentLevel = indentStack.Pop();
        }

        public static void PushGUIColor(Color color)
        {
            guiColorStack.Push(GUI.color);
            GUI.color = color;
        }

        public static void PopGUIColor()
        {
            GUI.color = guiColorStack.Pop();
        }
    }
}