using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEditor;

namespace AnnulusGames.LucidTools.Editor
{
    public static class SerializedPropertyExtensions
    {
        public static bool TryGetAttribute<TAttribute>(this SerializedProperty property, out TAttribute result) where TAttribute : Attribute
        {
            return TryGetAttribute<TAttribute>(property, false, out result);
        }

        public static bool TryGetAttribute<TAttribute>(this SerializedProperty property, bool inherit, out TAttribute result) where TAttribute : Attribute
        {
            TAttribute att = GetAttribute<TAttribute>(property, inherit);
            result = att;
            return att != null;
        }

        public static TAttribute GetAttribute<TAttribute>(this SerializedProperty property, bool inherit = false) where TAttribute : Attribute
        {
            if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }

            Type targetObjectType = property.GetParentObject().GetType();

            if (targetObjectType == null)
            {
                throw new ArgumentException($"Could not find the {nameof(targetObjectType)} of {nameof(property)}");
            }

            foreach (var pathSegment in property.propertyPath.Split('.'))
            {
                FieldInfo fieldInfo = ReflectionUtil.GetField(targetObjectType, pathSegment, (BindingFlags)(-1), inherit);
                if (fieldInfo != null)
                {
                    return (TAttribute)fieldInfo.GetCustomAttribute<TAttribute>(inherit);
                }

                PropertyInfo propertyInfo = targetObjectType.GetProperty(pathSegment, (BindingFlags)(-1));
                if (propertyInfo != null)
                {
                    return (TAttribute)propertyInfo.GetCustomAttribute<TAttribute>(inherit);
                }
            }

            throw new ArgumentException($"Could not find the field or property of {nameof(property)}");
        }

        public static TAttribute[] GetAttributes<TAttribute>(this SerializedProperty property, bool inherit) where TAttribute : Attribute
        {
            if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }

            Type targetObjectType = property.GetParentObject()?.GetType();

            if (targetObjectType == null)
            {
                return Enumerable.Empty<TAttribute>().ToArray();
            }

            foreach (var pathSegment in property.propertyPath.Split('.'))
            {
                FieldInfo fieldInfo = ReflectionUtil.GetField(targetObjectType, pathSegment, (BindingFlags)(-1), true);
                if (fieldInfo != null)
                {
                    return (TAttribute[])fieldInfo.GetCustomAttributes<TAttribute>(inherit);
                }

                PropertyInfo propertyInfo = ReflectionUtil.GetProperty(targetObjectType, pathSegment, (BindingFlags)(-1), true);
                if (propertyInfo != null)
                {
                    return (TAttribute[])propertyInfo.GetCustomAttributes<TAttribute>(inherit);
                }
            }

            return Enumerable.Empty<TAttribute>().ToArray();
        }

        public static float GetHeight(this SerializedProperty property)
        {
            return EditorGUI.GetPropertyHeight(property, true);
        }

        public static float GetHeight(this SerializedProperty property, bool includeChildren)
        {
            return EditorGUI.GetPropertyHeight(property, includeChildren);
        }

        public static float GetHeight(this SerializedProperty property, GUIContent label, bool includeChildren)
        {
            return EditorGUI.GetPropertyHeight(property, label, includeChildren);
        }

        // public static TEnum GetEnum<TEnum>(this SerializedProperty property) where TEnum : struct, Enum
        // {
        //     return (TEnum)Enum.ToObject(typeof(TEnum), property.enumValueIndex);
        // }

        // public static void SetEnum<TEnum>(this SerializedProperty property, TEnum value) where TEnum : struct, Enum
        // {
        //     property.enumValueIndex = Convert.ToInt32(value);
        // }

        public static T GetValue<T>(this SerializedProperty property)
        {
            return GetNestedObject<T>(property.propertyPath, GetSerializedPropertyRootObject(property));
        }

        public static bool SetValue<T>(this SerializedProperty property, T value)
        {
            object obj = GetSerializedPropertyRootObject(property);
            string[] fieldStructure = property.propertyPath.Split('.');
            for (int i = 0; i < fieldStructure.Length - 1; i++)
            {
                obj = GetFieldOrPropertyValue<object>(fieldStructure[i], obj);
            }
            string fieldName = fieldStructure.Last();

            return SetFieldOrPropertyValue(fieldName, obj, value);
        }

        public static FieldInfo GetFieldInfo(this SerializedProperty property)
        {
            var parentType = property.serializedObject.targetObject.GetType();
            var splits = property.propertyPath.Split('.');
            var fieldInfo = ReflectionUtil.GetField(parentType, splits[0]);
            for (var i = 1; i < splits.Length; i++)
            {
                if (splits[i] == "Array")
                {
                    i += 2;
                    if (i >= splits.Length)
                        continue;

                    var type = fieldInfo.FieldType.IsArray
                        ? fieldInfo.FieldType.GetElementType()
                        : fieldInfo.FieldType.GetGenericArguments()[0];

                    fieldInfo = ReflectionUtil.GetField(type, splits[i]);
                }
                else
                {
                    fieldInfo = i + 1 < splits.Length && splits[i + 1] == "Array"
                        ? ReflectionUtil.GetField(parentType, splits[i])
                        : ReflectionUtil.GetField(fieldInfo.FieldType, splits[i]);
                }

                if (fieldInfo == null) return null;

                parentType = fieldInfo.FieldType;
            }

            return fieldInfo;
        }

        public static Type GetPropertyType(this SerializedProperty property, bool isCollectionType = false)
        {
            var fieldInfo = property.GetFieldInfo();

            if (isCollectionType && property.isArray && property.propertyType != SerializedPropertyType.String)
                return fieldInfo.FieldType.IsArray
                    ? fieldInfo.FieldType.GetElementType()
                    : fieldInfo.FieldType.GetGenericArguments()[0];
            return fieldInfo.FieldType;
        }

        internal static object SetManagedReferenceType(this SerializedProperty property, Type type)
        {
            object obj = (type != null) ? Activator.CreateInstance(type) : null;
            property.managedReferenceValue = obj;
            return obj;
        }

        private static UnityEngine.Object GetSerializedPropertyRootObject(SerializedProperty property)
        {
            return property.serializedObject.targetObject as UnityEngine.Object;
        }

        private static T GetNestedObject<T>(string path, object obj, bool includeAllBases = false)
        {
            string[] parts = path.Split('.');
            for (int i = 0; i < parts.Length; i++)
            {
                string part = parts[i];

                if (part == "Array")
                {
                    var regex = new Regex(@"[^0-9]");
                    var countText = regex.Replace(parts[i + 1], "");
                    int index = 0;
                    if (!int.TryParse(countText, out index))
                    {
                        index = -1;
                    }

                    obj = GetElementAtOrDefault(obj, index);

                    i++;
                }
                else
                {
                    obj = GetFieldOrPropertyValue<object>(part, obj, includeAllBases);
                }
            }
            return (T)obj;
        }

        private static object GetElementAtOrDefault(object arrayOrListObj, int index)
        {
            if (arrayOrListObj is IEnumerable<object> referenceEnumerable)
            {
                return referenceEnumerable.ElementAtOrDefault(index);
            }

            var valueList = arrayOrListObj as IList;
            if (valueList != null)
            {
                object returnObj = null;
                if (index < 0 || index >= valueList.Count)
                {
                    Type listType = valueList.GetType();
                    Type elementType = listType.IsArray ? listType.GetElementType() : listType.GetGenericArguments()[0];
                    returnObj = Activator.CreateInstance(elementType);
                }
                else
                {
                    returnObj = valueList[index];
                }

                return returnObj;
            }

            throw new ArgumentException($"Can't parse {arrayOrListObj.GetType()} as Array or List");
        }

        public static object GetParentObject(this SerializedProperty property)
        {
            if (property == null) return null;

            var path = property.propertyPath.Replace(".Array.data[", "[");
            object obj = property.serializedObject.targetObject;
            var elements = path.Split('.');
            foreach (var element in elements.Take(elements.Length - 1))
            {
                if (element.Contains("["))
                {
                    var elementName = element.Substring(0, element.IndexOf("["));
                    var index = Convert.ToInt32(element.Substring(element.IndexOf("[")).Replace("[", "").Replace("]", ""));
                    obj = ReflectionUtil.GetValue(obj, elementName, index);
                }
                else
                {
                    obj = ReflectionUtil.GetValue(obj, element);
                }
            }
            return obj;
        }

        private static T GetFieldOrPropertyValue<T>(string fieldName, object obj, bool includeAllBases = false, BindingFlags bindings = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
        {
            FieldInfo field = obj.GetType().GetField(fieldName, bindings);
            if (field != null) return (T)field.GetValue(obj);

            PropertyInfo property = obj.GetType().GetProperty(fieldName, bindings);
            if (property != null) return (T)property.GetValue(obj, null);

            if (includeAllBases)
            {
                foreach (Type type in TypeUtil.GetBaseClassesAndInterfaces(obj.GetType()))
                {
                    field = type.GetField(fieldName, bindings);
                    if (field != null) return (T)field.GetValue(obj);

                    property = type.GetProperty(fieldName, bindings);
                    if (property != null) return (T)property.GetValue(obj, null);
                }
            }

            return default(T);
        }

        private static bool SetFieldOrPropertyValue(string fieldName, object obj, object value, bool includeAllBases = false, BindingFlags bindings = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
        {
            FieldInfo field = obj.GetType().GetField(fieldName, bindings);
            if (field != null)
            {
                field.SetValue(obj, value);
                return true;
            }

            PropertyInfo property = obj.GetType().GetProperty(fieldName, bindings);
            if (property != null)
            {
                property.SetValue(obj, value, null);
                return true;
            }

            if (includeAllBases)
            {
                foreach (Type type in TypeUtil.GetBaseClassesAndInterfaces(obj.GetType()))
                {
                    field = type.GetField(fieldName, bindings);
                    if (field != null)
                    {
                        field.SetValue(obj, value);
                        return true;
                    }

                    property = type.GetProperty(fieldName, bindings);
                    if (property != null)
                    {
                        property.SetValue(obj, value, null);
                        return true;
                    }
                }
            }
            return false;
        }

    }

}