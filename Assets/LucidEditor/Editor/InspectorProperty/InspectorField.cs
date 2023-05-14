using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using UnityEngine;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEditorInternal;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    public class InspectorField : InspectorProperty
    {
        public IReadOnlyList<InspectorProperty> childProperties => _childProperties.AsReadOnly();
        private List<InspectorProperty> _childProperties;

        private List<PropertyProcessor> processors = new List<PropertyProcessor>();
        private Dictionary<SerializedProperty, ReorderableList> reorderableListCache = new Dictionary<SerializedProperty, ReorderableList>();

        public bool hasChildren
        {
            get
            {
                return _childProperties != null && _childProperties.Capacity > 0;
            }
        }

        public bool isManagedReference
        {
            get
            {
                return serializedProperty.propertyType == SerializedPropertyType.ManagedReference;
            }
        }

        public bool isArray
        {
            get
            {
                return serializedProperty.isArray && serializedProperty.propertyType != SerializedPropertyType.String;
            }
        }

        public GUIStyle foldoutHeaderStyle
        {
            get
            {
                if (_foldoutHeaderStyle == null)
                {
                    _foldoutHeaderStyle = new GUIStyle(EditorStyles.foldout);
                    _foldoutHeaderStyle.fontStyle = FontStyle.Bold;
                }
                return _foldoutHeaderStyle;
            }
        }
        private GUIStyle _foldoutHeaderStyle;

        internal InspectorField(SerializedProperty property, Attribute[] attributes) : base(property.serializedObject, property, property.GetParentObject(), property.name, attributes)
        {
            this.displayName = property.displayName;
            InitializeChildProperties();
        }

        internal void InitializeChildProperties()
        {
            if (isArray)
            {
                _childProperties = new List<InspectorProperty>();
                serializedObject.Update();
                for (int i = 0; i < serializedProperty.arraySize; i++)
                {
                    var element = serializedProperty.GetArrayElementAtIndex(i);
                    var field = InspectorPropertyUtil.CreatePropertyField(element);
                    _childProperties.Add(field);
                }
            }
            else
            {
                _childProperties = InspectorPropertyUtil.GroupProperties(InspectorPropertyUtil.CreateChildProperties(this));
            }

            foreach (var child in _childProperties) child.Initialize();
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

            foreach (var child in _childProperties) child.Initialize();
        }

        internal override void OnBeforeInspectorGUI()
        {
            foreach (PropertyProcessor processor in processors) processor.OnBeforeInspectorGUI();
            foreach (var child in _childProperties) child.OnBeforeInspectorGUI();
        }

        internal override void OnAfterInspectorGUI()
        {
            foreach (PropertyProcessor processor in processors) processor.OnAfterInspectorGUI();
            foreach (var child in _childProperties) child.OnAfterInspectorGUI();
        }

        internal override void Reset()
        {
            base.Reset();
            this.displayName = serializedProperty.displayName;
            foreach (InspectorProperty property in _childProperties)
            {
                property.Reset();
            }
        }

        internal override void Draw()
        {
            if (attributes.Any(x => x is DisableLucidEditorAttribute))
            {
                EditorGUILayout.PropertyField(serializedProperty);
                return;
            }

            foreach (PropertyProcessor processor in processors) processor.OnBeforeDrawProperty();

            if (isHidden) return;

            using (var changeScope = new EditorGUI.ChangeCheckScope())
            {
                if (!isEditable) EditorGUI.BeginDisabledGroup(true);

                LucidEditorUtility.PushIndentLevel(EditorGUI.indentLevel + this.indent);
                DrawField();
                LucidEditorUtility.PopIndentLevel();

                if (!isEditable) EditorGUI.EndDisabledGroup();

                _changed = changeScope.changed;

                if (_changed)
                {
                    serializedObject.ApplyModifiedProperties();
                }
            }

            foreach (PropertyProcessor processor in processors) processor.OnAfterDrawProperty();
        }

        private void DrawField()
        {
            if (isArray)
            {
                DrawArrayField(serializedProperty, !TryGetAttribute<NonReorderableAttribute>(out var nonReorderableAttribute));
            }
            else if (isManagedReference)
            {
                DrawSerializeReferenceField();
            }
            else if (hasChildren)
            {
                Rect foldoutRect = EditorGUILayout.GetControlRect();

                if (_isInGroup)
                {
                    using (new EditorGUI.IndentLevelScope())
                    {
                        foldoutRect.xMin -= 4f;
                        serializedProperty.isExpanded = EditorGUI.Foldout(foldoutRect, serializedProperty.isExpanded, displayName, true, foldoutHeaderStyle);
                    }
                }
                else
                {
                    serializedProperty.isExpanded = EditorGUI.Foldout(foldoutRect, serializedProperty.isExpanded, displayName, true, foldoutHeaderStyle);
                }

                if (serializedProperty.isExpanded)
                {
                    using (new EditorGUI.IndentLevelScope())
                    {
                        foreach (var child in _childProperties.OrderBy(x => x.order))
                        {
                            child.Draw();
                        }
                    }
                }
            }
            else
            {
                GUIContent label;
                if (hideLabel)
                {
                    label = GUIContent.none;
                }
                else
                {
                    label = new GUIContent(displayName);
                }

                if (LucidEditorUtility.horizontalGroupCount > 0 && serializedProperty.propertyType != SerializedPropertyType.Generic)
                {
                    using (new EditorGUILayout.HorizontalScope())
                    {
                        GUILayout.Label(label, GUILayout.MinWidth(50f));
                        DrawNormalField(serializedProperty, GUIContent.none, GUILayout.MinWidth(0f));
                    }
                }
                else
                {
                    DrawNormalField(serializedProperty, label, GUILayout.MinWidth(0f));
                }
            }
        }

        private void DrawNormalField(SerializedProperty property, GUIContent label, params GUILayoutOption[] options)
        {
            EditorGUILayout.PropertyField(serializedProperty, label, true, options);
        }

        private void DrawArrayField(SerializedProperty property, bool reordable)
        {
            // TODO: support reordable list
            if (reordable)
            {
                if (_isInGroup)
                {
                    using (new EditorGUI.IndentLevelScope())
                    {
                        DrawNormalField(property, new GUIContent(displayName));
                    }
                }
                else
                {
                    DrawNormalField(property, new GUIContent(displayName));
                }
                return;
            }

            var reorderableList = GetArrayReordableList(property);
            Rect position = EditorGUILayout.GetControlRect();

            Rect foldoutRect = position;
            foldoutRect.xMax -= 60f;
            if (_isInGroup)
            {
                using (new EditorGUI.IndentLevelScope())
                {
                    foldoutRect.xMin -= 4f;
                    property.isExpanded = EditorGUI.Foldout(foldoutRect, property.isExpanded, displayName, true, foldoutHeaderStyle);
                }
            }
            else
            {
                property.isExpanded = EditorGUI.Foldout(foldoutRect, property.isExpanded, displayName, true, foldoutHeaderStyle);
            }

            Rect arraySizeFieldRect = position;
            arraySizeFieldRect.width = 48;
            arraySizeFieldRect.x = position.xMax - 48f;

            int arraySize = EditorGUI.DelayedIntField(arraySizeFieldRect, property.arraySize);
            if (arraySize != property.arraySize)
            {
                property.arraySize = arraySize;
                serializedObject.ApplyModifiedProperties();
                InitializeChildProperties();
            }

            // if (reordable)
            // {
            //     if (property.isExpanded)
            //     {
            //         reorderableList.DoLayoutList();
            //     }
            // }
            // else
            {
                if (_isInGroup) LucidEditorUtility.PushIndentLevel(EditorGUI.indentLevel + 2);
                else LucidEditorUtility.PushIndentLevel(EditorGUI.indentLevel + 1);

                if (property.isExpanded)
                {
                    if (arraySize == 0)
                    {
                        EditorGUILayout.HelpBox("Array size is 0", MessageType.Info);
                    }
                    else
                    {
                        foreach (var child in _childProperties.OrderBy(x => x.order))
                        {
                            child.Draw();
                        }
                    }
                }

                LucidEditorUtility.PopIndentLevel();
            }
        }

        private ReorderableList GetArrayReordableList(SerializedProperty property)
        {
            if (!reorderableListCache.TryGetValue(property, out var reorderableList))
            {
                reorderableList = new ReorderableList(property.serializedObject, property);
                reorderableList.headerHeight = 0;
                reorderableList.drawElementCallback = (Rect rect, int index, bool isActive, bool isFocused) =>
                {
                    GUILayout.BeginArea(rect);
                    _childProperties[index].Draw();
                    GUILayout.EndArea();
                };
                reorderableList.onAddCallback = list =>
                {
                    property.InsertArrayElementAtIndex(property.arraySize);
                    InitializeChildProperties();
                };
                reorderableList.onRemoveCallback = list =>
                {
                    property.DeleteArrayElementAtIndex(list.index);
                    InitializeChildProperties();
                };
                reorderableList.multiSelect = true;
                reorderableList.onCanAddCallback = _ => true;
                reorderableList.onCanRemoveCallback = _ => true;

                reorderableListCache.Add(property, reorderableList);
            }

            return reorderableList;
        }

        private void DrawSerializeReferenceField()
        {
            InspectorField property = this;
            Rect position = EditorGUILayout.GetControlRect();

            // dropdown -----------------------------------------------------------------------------------
            int maxTypePopupLineCount = 13;

            Rect dropdownRect = position;
            dropdownRect.height = EditorGUIUtility.singleLineHeight;
            dropdownRect.xMin += EditorGUIUtility.labelWidth;

            GUIContent buttonLabel = EditorIcons.CsScriptIcon;
            buttonLabel.text = (property.serializedProperty.managedReferenceValue == null ? "Null" : property.serializedProperty.managedReferenceValue.GetType().Name) +
                $" ({GetManagedReferenceFieldTypeName(property.serializedProperty)})";

            if (GUI.Button(dropdownRect, buttonLabel, EditorStyles.objectField))
            {
                Type baseType = GetManagedReferenceFieldType(property.serializedProperty);
                SerializeReferenceDropdown dropdown = new SerializeReferenceDropdown(
                    TypeCache.GetTypesDerivedFrom(baseType).Append(baseType).Where(p =>
                            (p.IsPublic || p.IsNestedPublic) &&
                            !p.IsAbstract &&
                            !p.IsGenericType &&
                            !typeof(UnityEngine.Object).IsAssignableFrom(p) &&
                            Attribute.IsDefined(p, typeof(SerializableAttribute))
                        ),
                        maxTypePopupLineCount,
                        new AdvancedDropdownState()
                    );
                dropdown.onItemSelected += item =>
                {
                    Type type = item.type;
                    object obj = property.serializedProperty.SetManagedReferenceType(type);
                    property.serializedProperty.isExpanded = true;
                    property.serializedProperty.serializedObject.ApplyModifiedProperties();
                    property.serializedProperty.serializedObject.Update();

                    property.InitializeChildProperties();
                };

                dropdown.Show(position);
            }

            // elements -----------------------------------------------------------------------------------

            if (_isInGroup)
            {
                using (new EditorGUI.IndentLevelScope())
                {
                    position.xMin -= 4f;
                    serializedProperty.isExpanded = EditorGUI.Foldout(position, serializedProperty.isExpanded, displayName, true, foldoutHeaderStyle);
                }
            }
            else
            {
                serializedProperty.isExpanded = EditorGUI.Foldout(position, serializedProperty.isExpanded, displayName, true, foldoutHeaderStyle);
            }

            if (serializedProperty.isExpanded)
            {
                using (new EditorGUI.IndentLevelScope())
                {
                    if (!hasChildren)
                    {
                        EditorGUILayout.HelpBox("No type assigned.", MessageType.Info);
                    }
                    else
                    {
                        foreach (var child in _childProperties.OrderBy(x => x.order))
                        {
                            child.Draw();
                        }
                    }
                }
            }
        }

        private string GetManagedReferenceFieldTypeName(SerializedProperty property)
        {
            string typeName = property.managedReferenceFieldTypename;
            int splitIndex = typeName.IndexOf(' ');
            return typeName.Substring(splitIndex + 1);
        }

        private Type GetManagedReferenceFieldType(SerializedProperty property)
        {
            string typeName = property.managedReferenceFieldTypename;
            int splitIndex = typeName.IndexOf(' ');
            var assembly = Assembly.Load(typeName.Substring(0, splitIndex));
            return assembly.GetType(typeName.Substring(splitIndex + 1));
        }
    }
}