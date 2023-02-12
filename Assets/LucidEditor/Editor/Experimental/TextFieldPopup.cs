using System;
using UnityEngine;
using UnityEditor;

namespace AnnulusGames.LucidTools.Editor.Experimental
{
    public class TextFieldPopup : PopupWindowContent
    {
        public string text;

        public Action<string> onValueChanged;
        public Action onSubmit;
        public Action onCancel;

        private bool submit;
        private bool initialized;
        private bool didFocus = false;

        private Rect size;

        public void Show(Rect position)
        {
            size = position;
            size.height = EditorGUIUtility.singleLineHeight;
            PopupWindow.Show(position, this);
        }

        public override void OnGUI(Rect rect)
        {
            if (!initialized)
            {
                initialized = true;
                onValueChanged?.Invoke(text);
            }

            if (LucidGUIEvent.GetKeyDown(KeyCode.Return))
            {
                submit = true;
                editorWindow.Close();
            }

            string textFieldName = $"{GetType().Name}:{nameof(text)}";
            using (var scope = new EditorGUI.ChangeCheckScope())
            {
                GUI.SetNextControlName(textFieldName);
                Rect fieldRect = EditorGUILayout.GetControlRect();
                fieldRect.xMin -= 2.7f;
                fieldRect.xMax += 2.7f;
                fieldRect.yMin -= 2.7f;
                fieldRect.yMax += 2.7f;
                text = EditorGUI.TextField(fieldRect, text);
                if (scope.changed)
                {
                    onValueChanged?.Invoke(text);
                }
            }

            if (!didFocus)
            {
                GUI.FocusControl(textFieldName);
                didFocus = true;
            }
        }

        public override Vector2 GetWindowSize()
        {
            return new Vector2(size.width, EditorGUIUtility.singleLineHeight);
        }

        public override void OnClose()
        {
            base.OnClose();
            if (submit) onSubmit?.Invoke();
            else onCancel?.Invoke();
        }
    }

}