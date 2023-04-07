using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;

namespace AnnulusGames.LucidTools.Editor
{
    public sealed class NonSerializedInspectorProperty : InspectorProperty
    {
        private List<PropertyProcessor> processors = new List<PropertyProcessor>();
        internal NonSerializedInspectorProperty(SerializedObject serializedObject, object parentObject, string name, Attribute[] attributes) : base(serializedObject, null, parentObject, name, attributes) { }

        internal override void Initialize()
        {
            processors.Clear();
            foreach (Attribute attribute in attributes)
            {
                PropertyProcessor processor = ProcessorUtil.CreateAttributeProcessor(this, attribute);

                if (processor != null)
                {
                    processor.Initialize();
                    processors.Add(processor);
                }
            }
        }

        internal override void Draw()
        {
            foreach (PropertyProcessor processor in processors) processor.OnBeforeDrawProperty();

            if (isHidden) return;

            LucidEditorGUILayout.BeginLayoutIndent(EditorGUI.indentLevel + indent);
            if (!isEditable) EditorGUI.BeginDisabledGroup(true);
            {
                object value = ReflectionUtil.GetValue(parentObject, name);
                var n = string.IsNullOrEmpty(displayName) ? name : displayName;
                
                if (value == null) EditorGUILayout.LabelField(n);
                else LucidEditorGUILayout.ReadOnlyField(n, value, value.GetType());
            }
            if (!isEditable) EditorGUI.EndDisabledGroup();
            LucidEditorGUILayout.EndLayoutIndent();

            foreach (PropertyProcessor processor in processors) processor.OnAfterDrawProperty();
        }

        internal override void OnBeforeInspectorGUI()
        {
            foreach (PropertyProcessor processor in processors) processor.OnBeforeInspectorGUI();
        }

        internal override void OnAfterInspectorGUI()
        {
            foreach (PropertyProcessor processor in processors) processor.OnAfterInspectorGUI();
        }
    }
}