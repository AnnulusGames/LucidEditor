using System;
using UnityEngine;

namespace AnnulusGames.LucidTools.Editor
{
    public static class LucidGUIEvent
    {
        public static bool isRepaint
        {
            get
            {
                return Event.current.type == EventType.Repaint;
            }
        }

        public static bool isLayout
        {
            get
            {
                return Event.current.type == EventType.Layout;
            }
        }

        public static bool isUsed
        {
            get
            {
                return Event.current.type == EventType.Used;
            }
        }

        public static Vector2 mousePosition
        {
            get
            {
                return Event.current.mousePosition;
            }
        }

        public static Vector2 mouseDelta
        {
            get
            {
                return Event.current.delta;
            }
        }

        public static bool GetKeyDown(KeyCode keyCode, bool use = false)
        {
            return GetGUIEvent(e => e.type == EventType.KeyDown && e.keyCode == keyCode, use);
        }

        public static bool GetKeyUp(KeyCode keyCode, bool use = false)
        {
            return GetGUIEvent(e => e.type == EventType.KeyUp && e.keyCode == keyCode, use);
        }

        public static bool GetMouseButtonDown(int button, bool use = false)
        {
            return GetGUIEvent(e => e.type == EventType.MouseDown && e.button == button, use);
        }

        public static bool GetMouseButtonDown(int button, Rect rect, bool use = false)
        {
            return GetGUIEvent(e => e.type == EventType.MouseDown && e.button == button && rect.Contains(e.mousePosition), use);
        }

        public static bool GetMouseButtonUp(int button, bool use = false)
        {
            return GetGUIEvent(e => e.type == EventType.MouseUp && e.button == button, use);
        }

        public static bool GetMouseButtonUp(int button, Rect rect, bool use = false)
        {
            return GetGUIEvent(e => e.type == EventType.MouseUp && e.button == button && rect.Contains(e.mousePosition), use);
        }

        public static bool GetMouseButtonMultiClick(int button, int count, bool use = false)
        {
            return GetGUIEvent(e => e.type == EventType.MouseUp && e.button == button && e.clickCount == count, use);
        }

        public static bool GetMouseButtonMultiClick(int button, int count, Rect rect, bool use = false)
        {
            return GetGUIEvent(e => e.type == EventType.MouseUp && e.button == button && e.clickCount == count && rect.Contains(e.mousePosition), use);
        }

        private static bool GetGUIEvent(Func<Event, bool> func, bool use)
        {
            if (func == null) return false;
            var e = Event.current;
            bool result = func.Invoke(e);
            if (result && use) e.Use();
            return result;
        }

        internal static void MouseDownEvent(Rect rect, Action action)
        {
            var e = Event.current;
            if (e.type == EventType.MouseDown && rect.Contains(e.mousePosition) && e.button == 0)
            {
                action?.Invoke();
                e.Use();
            }
        }
    }
}
