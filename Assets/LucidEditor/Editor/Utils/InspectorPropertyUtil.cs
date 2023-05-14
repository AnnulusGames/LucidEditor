using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    internal static class InspectorPropertyUtil
    {
        public static InspectorField CreatePropertyField(SerializedProperty serializedProperty)
        {
            return new InspectorField(serializedProperty, serializedProperty.GetAttributes<Attribute>(true));
        }

        public static List<InspectorProperty> CreateProperties(SerializedObject serializedObject)
        {
            var list = new List<InspectorProperty>();
            SerializedProperty iterator = serializedObject.GetIterator();

            iterator.NextVisible(true);
            while (iterator.NextVisible(false))
            {
                InspectorField ip = CreatePropertyField(iterator.Copy());
                list.Add(ip);
            }

            list.AddRange(CreateButtonsAndNonSerializedProperties(serializedObject, serializedObject.targetObject));

            return list;
        }

        public static List<InspectorProperty> CreateChildProperties(InspectorField property)
        {
            var list = new List<InspectorProperty>();
            var pType = property.serializedProperty.GetFieldInfo()?.FieldType;

            if (property.serializedProperty.hasVisibleChildren &&
                (property.serializedProperty.propertyType == SerializedPropertyType.Generic || property.serializedProperty.propertyType == SerializedPropertyType.ManagedReference) &&
                !property.serializedProperty.isArray &&
                (pType != null ? !TypeUtil.HasCustomDrawerType(pType.IsGenericType ? pType.GetGenericTypeDefinition() : pType) : true))
            {
                var iterator = property.serializedProperty.Copy();

                iterator.NextVisible(true);
                int depth = iterator.depth;
                list.Add(new InspectorField(iterator.Copy(), iterator.GetAttributes<Attribute>(true)));

                while (iterator.NextVisible(false))
                {
                    if (iterator.depth != depth) break;
                    list.Add(new InspectorField(iterator.Copy(), iterator.GetAttributes<Attribute>(true)));
                }

                object obj = property.serializedProperty.GetValue<object>();
                list.AddRange(CreateButtonsAndNonSerializedProperties(property.serializedProperty.serializedObject, obj));
            }

            return list;
        }

        public static List<InspectorProperty> CreateButtonsAndNonSerializedProperties(SerializedObject serializedObject, object targetObject)
        {
            var list = new List<InspectorProperty>();

            if (targetObject == null)
            {
                return list;
            }

            foreach (MemberInfo memberInfo in ReflectionUtil.GetAllMembers(targetObject.GetType(), (BindingFlags)(-1), inherit: true))
            {
                if (memberInfo is FieldInfo fieldInfo)
                {
                    if (fieldInfo.IsPublic || fieldInfo.GetCustomAttribute<SerializeField>() == null)
                    {
                        ShowInInspectorAttribute showInInspector = fieldInfo.GetCustomAttribute<ShowInInspectorAttribute>();
                        if (showInInspector != null)
                        {
                            list.Add(new NonSerializedInspectorProperty(serializedObject, targetObject, fieldInfo.Name, fieldInfo.GetCustomAttributes().ToArray()));
                        }
                    }
                }
                else if (memberInfo is PropertyInfo propertyInfo)
                {
                    MethodInfo getterInfo = propertyInfo.GetGetMethod(true);
                    if (getterInfo != null)
                    {
                        ShowInInspectorAttribute showInInspector = propertyInfo.GetCustomAttribute<ShowInInspectorAttribute>();
                        if (showInInspector != null)
                        {
                            list.Add(new NonSerializedInspectorProperty(serializedObject, targetObject, propertyInfo.Name, propertyInfo.GetCustomAttributes().ToArray()));
                        }
                    }
                }
                else if (memberInfo is MethodInfo methodInfo)
                {
                    ShowInInspectorAttribute showInInspector = methodInfo.GetCustomAttribute<ShowInInspectorAttribute>();
                    if (showInInspector != null)
                    {
                        list.Add(new NonSerializedInspectorProperty(serializedObject, targetObject, methodInfo.Name, methodInfo.GetCustomAttributes().ToArray()));
                    }

                    ButtonAttribute buttonAttribute = methodInfo.GetCustomAttribute<ButtonAttribute>();
                    if (buttonAttribute != null)
                    {
                        InspectorButton ib;
                        if (string.IsNullOrEmpty(buttonAttribute.label))
                        {
                            ib = new InspectorButton(serializedObject, targetObject, methodInfo, buttonAttribute.size);
                        }
                        else
                        {
                            ib = new InspectorButton(serializedObject, targetObject, methodInfo, buttonAttribute.label, buttonAttribute.size);
                        }
                        list.Add(ib);
                    }
                }
            }

            return list;
        }

        public static List<InspectorProperty> GroupProperties(IEnumerable<InspectorProperty> properties)
        {
            List<List<InspectorProperty>> groupList = new List<List<InspectorProperty>>();

            List<InspectorProperty> propertyList = new List<InspectorProperty>(properties);
            List<InspectorProperty> usedProperties = new List<InspectorProperty>();

            Dictionary<InspectorProperty, List<PropertyGroupAttribute>> paDictionary = new Dictionary<InspectorProperty, List<PropertyGroupAttribute>>();
            foreach (InspectorProperty property in propertyList)
            {
                paDictionary.Add(property, new List<PropertyGroupAttribute>());
                paDictionary[property].AddRange(
                    property.attributes
                        .Where(x => x is PropertyGroupAttribute)
                        .Select(x => (PropertyGroupAttribute)x)
                );
            }

            int depth = 0;
            while (propertyList.Count > 0)
            {
                groupList.Add(new List<InspectorProperty>());

                foreach (InspectorProperty property in propertyList)
                {
                    PropertyGroupAttribute attribute = paDictionary[property].FirstOrDefault(x => x.groupDepth == depth);

                    if (attribute != null)
                    {
                        string[] hierarchy = attribute.path.Split('/');
                        string currentPath = string.Empty;
                        InspectorPropertyGroup group = null;

                        for (int i = 0; i < hierarchy.Length; i++)
                        {
                            currentPath += hierarchy[i];

                            InspectorPropertyGroup newGroup = groupList[i]
                                .Where(x => x is InspectorPropertyGroup)
                                .Select(x => (InspectorPropertyGroup)x)
                                .FirstOrDefault(x => x.path.Split('/')[i] == hierarchy[i]);

                            if (newGroup == null)
                            {
                                newGroup = new InspectorPropertyGroup(currentPath, property.serializedObject, attribute);
                                groupList[i].Add(newGroup);
                                group?.Add(newGroup);
                            }

                            group = newGroup;
                            currentPath += '/';
                        }

                        paDictionary[property].RemoveAll(x => x.groupDepth == depth);
                        if (paDictionary[property].Count == 0)
                        {
                            group.Add(property);
                            usedProperties.Add(property);
                        }
                    }
                    else if (paDictionary[property].Count == 0)
                    {
                        groupList[0].Add(property);
                        usedProperties.Add(property);
                    }
                }

                foreach (InspectorProperty property in usedProperties)
                {
                    propertyList.Remove(property);
                }
                usedProperties.Clear();
                depth++;
            }

            return groupList.Count > 0 ? groupList[0] : new List<InspectorProperty>();
        }

    }

}