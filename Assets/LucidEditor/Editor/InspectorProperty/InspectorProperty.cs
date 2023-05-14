using System;
using UnityEditor;

namespace AnnulusGames.LucidTools.Editor
{
    public abstract class InspectorProperty
    {
        public readonly SerializedObject serializedObject;
        public readonly SerializedProperty serializedProperty;
        public object parentObject { get; internal set; }
        public readonly string name;

        public readonly Attribute[] attributes;

        public TAttribute GetAttribute<TAttribute>() where TAttribute : Attribute
        {
            foreach (Attribute att in attributes)
            {
                if (att is TAttribute)
                {
                    return (TAttribute)att;
                }
            }
            return null;
        }

        public bool TryGetAttribute<TAttribute>(out TAttribute result) where TAttribute : Attribute
        {
            foreach (Attribute att in attributes)
            {
                if (att is TAttribute)
                {
                    result = (TAttribute)att;
                    return true;
                }
            }
            result = null;
            return false;
        }

        internal InspectorProperty(SerializedObject serializedObject, SerializedProperty serializedProperty, object parentObject, string name, Attribute[] attributes)
        {
            this.serializedObject = serializedObject;
            if (serializedProperty != null) this.serializedProperty = serializedProperty.Copy();
            this.parentObject = parentObject;
            this.displayName = name;
            this.name = name;
            this.attributes = attributes;
        }

        public int order;
        public bool isHidden;
        public bool isEditable = true;
        public bool hideLabel;
        public int indent;
        public string displayName;

        public bool isInGroup => _isInGroup;
        public bool changed => _changed;

        internal bool _changed;
        internal bool _isInGroup;
        internal abstract void Initialize();
        internal abstract void OnBeforeInspectorGUI();
        internal abstract void OnAfterInspectorGUI();
        internal abstract void Draw();

        internal virtual void Reset()
        {
            order = 0;
            isHidden = false;
            isEditable = true;
            hideLabel = false;
            indent = 0;
            displayName = string.Empty;
            _changed = false;
        }
    }

}