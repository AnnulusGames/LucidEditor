using System;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    public sealed class InspectorButton : InspectorProperty
    {
        public readonly MethodInfo methodInfo;
        public readonly InspectorButtonSize size;

        private readonly string label;

        private Action action;
        private List<PropertyProcessor> processors = new List<PropertyProcessor>();

        internal InspectorButton(SerializedObject serializedObject, object parentObject, MethodInfo methodInfo, InspectorButtonSize size) : base(serializedObject, null, parentObject, methodInfo.Name, methodInfo.GetCustomAttributes().ToArray())
        {
            this.methodInfo = methodInfo;
            this.size = size;
            this.label = methodInfo.Name;

            action = Expression.Lambda<Action>(
                Expression.Call(methodInfo.IsStatic ? null : Expression.Constant(methodInfo.IsStatic ? null : parentObject), methodInfo)
            ).Compile();
        }

        internal InspectorButton(SerializedObject serializedObject, object parentObject, MethodInfo methodInfo, string label, InspectorButtonSize size) : base(serializedObject, null, parentObject, methodInfo.Name, methodInfo.GetCustomAttributes().ToArray())
        {
            this.methodInfo = methodInfo;
            this.size = size;
            this.label = label;

            action = Expression.Lambda<Action>(
                Expression.Call(methodInfo.IsStatic ? null : Expression.Constant(parentObject), methodInfo)
            ).Compile();
        }

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

        internal override void Reset()
        {
            base.Reset();
            displayName = label;
        }

        internal override void Draw()
        {
            foreach (PropertyProcessor processor in processors) processor.OnBeforeDrawProperty();

            if (isHidden) return;

            LucidEditorGUILayout.BeginLayoutIndent(EditorGUI.indentLevel + indent);
            if (!isEditable) EditorGUI.BeginDisabledGroup(true);
            {
                if (GUILayout.Button(hideLabel ? string.Empty : displayName, GUILayout.Height(size.GetHeight())))
                {
                    action.Invoke();
                }
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