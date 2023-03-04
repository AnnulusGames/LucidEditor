using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AnnulusGames.LucidTools.Editor
{
    internal static class ReflectionUtil
    {
        private static Dictionary<(Type, string, BindingFlags, bool), FieldInfo> cacheFieldInfo = new Dictionary<(Type, string, BindingFlags, bool), FieldInfo>();
        private static Dictionary<(Type, string, BindingFlags, bool), PropertyInfo> cachePropertyInfo = new Dictionary<(Type, string, BindingFlags, bool), PropertyInfo>();
        private static Dictionary<(Type, BindingFlags, bool), MemberInfo[]> cacheAllMembers = new Dictionary<(Type, BindingFlags, bool), MemberInfo[]>();

        private static Dictionary<(Type, string), Func<object, object>> cacheGetFieldValue = new Dictionary<(Type, string), Func<object, object>>();
        private static Dictionary<(Type, string), Func<object, object>> cacheGetPropertyValue = new Dictionary<(Type, string), Func<object, object>>();
        private static Dictionary<(Type, string), Func<object, object>> cacheGetMethodValue = new Dictionary<(Type, string), Func<object, object>>();

        public static Func<object, object> CreateGetter(FieldInfo fieldInfo)
        {
            if (fieldInfo == null) return null;
            if (fieldInfo.IsStatic)
            {
                Expression body = Expression.Convert(Expression.MakeMemberAccess(null, fieldInfo), typeof(object));
                var lambda = Expression.Lambda<Func<object>>(body).Compile();
                return _ => lambda();
            }
            if (fieldInfo.DeclaringType != null)
            {
                var objParam = Expression.Parameter(typeof(object), "obj");
                var tParam = Expression.Convert(objParam, fieldInfo.DeclaringType);
                Expression body = Expression.Convert(Expression.MakeMemberAccess(tParam, fieldInfo), typeof(object));
                return Expression.Lambda<Func<object, object>>(body, objParam).Compile();
            }
            return null;
        }
        public static Func<object, object> CreateGetter(PropertyInfo propertyInfo)
        {
            if (propertyInfo == null) return null;
            if (propertyInfo.GetGetMethod(true).IsStatic)
            {
                Expression body = Expression.Convert(Expression.MakeMemberAccess(null, propertyInfo), typeof(object));
                var lambda = Expression.Lambda<Func<object>>(body).Compile();
                return _ => lambda();
            }
            if (propertyInfo.DeclaringType != null)
            {
                var objParam = Expression.Parameter(typeof(object), "obj");
                var tParam = Expression.Convert(objParam, propertyInfo.DeclaringType);
                Expression body = Expression.Convert(Expression.MakeMemberAccess(tParam, propertyInfo), typeof(object));
                return Expression.Lambda<Func<object, object>>(body, objParam).Compile();
            }
            return null;
        }
        public static Func<object, object> CreateGetter(MethodInfo methodInfo)
        {
            if (methodInfo == null) return null;
            if (methodInfo.IsStatic)
            {
                Expression body = Expression.Convert(Expression.Call(null, methodInfo), typeof(object));
                var lambda = Expression.Lambda<Func<object>>(body).Compile();
                return _ => lambda();
            }
            if (methodInfo.DeclaringType != null)
            {
                var objParam = Expression.Parameter(typeof(object), "obj");
                var tParam = Expression.Convert(objParam, methodInfo.DeclaringType);
                Expression body = Expression.Convert(Expression.Call(tParam, methodInfo), typeof(object));
                return Expression.Lambda<Func<object, object>>(body, objParam).Compile();
            }
            return null;
        }

        public static object GetFieldValue(object target, Type type, string name, BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
        {
            if (!cacheGetFieldValue.TryGetValue((type, name), out var value))
            {
                FieldInfo info = type.GetField(name, bindingAttr);
                cacheGetFieldValue.Add((type, name), CreateGetter(info));
            }
            return value?.Invoke(target);
        }

        public static object GetPropertyValue(object target, Type type, string name, BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
        {
            if (!cacheGetPropertyValue.TryGetValue((type, name), out var value))
            {
                PropertyInfo info = type.GetProperty(name, bindingAttr);
                cacheGetPropertyValue.Add((type, name), CreateGetter(info));
            }
            return value?.Invoke(target);
        }

        public static object GetMethodValue(object target, Type type, string name, BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
        {
            if (!cacheGetMethodValue.TryGetValue((type, name), out var value))
            {
                MethodInfo info = type.GetMethod(name, bindingAttr);
                cacheGetMethodValue.Add((type, name), CreateGetter(info));
            }
            return value?.Invoke(target);
        }

        public static FieldInfo GetField(Type type, string name, BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static, bool inherit = false)
        {
            FieldInfo info;
            if (cacheFieldInfo.ContainsKey((type, name, bindingAttr, inherit)))
            {
                info = cacheFieldInfo[(type, name, bindingAttr, inherit)];
            }
            else
            {
                if (inherit)
                {
                    info = GetAllFieldsIncludingInherited(type, bindingAttr).FirstOrDefault(x => x.Name == name);
                }
                else
                {
                    info = type.GetField(name, bindingAttr);
                }
                cacheFieldInfo.Add((type, name, bindingAttr, inherit), info);
            }
            return info;
        }

        private static IEnumerable<FieldInfo> GetAllFieldsIncludingInherited(Type type, BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
        {
            if (type == null) return Enumerable.Empty<FieldInfo>();
            return type.GetFields(bindingAttr).Concat(GetAllFieldsIncludingInherited(type.BaseType));
        }

        public static PropertyInfo GetProperty(Type type, string name, BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static, bool inherit = false)
        {
            PropertyInfo info;
            if (cachePropertyInfo.ContainsKey((type, name, bindingAttr, inherit)))
            {
                info = cachePropertyInfo[(type, name, bindingAttr, inherit)];
            }
            else
            {
                if (inherit)
                {
                    info = GetAllPropertiesIncludingInherited(type, bindingAttr).FirstOrDefault(x => x.Name == name);
                }
                else
                {
                    info = type.GetProperty(name, bindingAttr);
                }
                cachePropertyInfo.Add((type, name, bindingAttr, inherit), info);
            }
            return info;
        }

        private static IEnumerable<PropertyInfo> GetAllPropertiesIncludingInherited(Type type, BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
        {
            if (type == null) return Enumerable.Empty<PropertyInfo>();
            return type.GetProperties(bindingAttr).Concat(GetAllPropertiesIncludingInherited(type.BaseType));
        }

        public static object GetValue(object target, string name, BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static, bool allowProperty = true, bool allowMethod = true)
        {
            if (target == null) return null;
            Type type = target.GetType();
            object result = null;

            while (type != null)
            {
                result = GetFieldValue(target, type, name, bindingAttr);
                if (result != null) return result;

                if (allowProperty)
                {
                    result = GetPropertyValue(target, type, name, bindingAttr);
                    if (result != null) return result;
                }

                if (allowMethod)
                {
                    result = GetMethodValue(target, type, name, bindingAttr);
                    if (result != null) return result;
                }

                type = type.BaseType;
            }
            return null;
        }

        public static object GetValue(object target, string name, int index)
        {
            IEnumerable enumerable = ReflectionUtil.GetValue(target, name, allowMethod: false) as IEnumerable;
            if (enumerable == null) return null;
            IEnumerator enm = enumerable.GetEnumerator();

            for (int i = 0; i <= index; i++)
            {
                if (!enm.MoveNext()) return null;
            }
            return enm.Current;
        }

        public static bool GetValueBool(object target, string name)
        {
            if (GetValue(target, name) is bool cond)
            {
                return cond;
            }
            return false;
        }

        public static MemberInfo[] GetAllMembers(Type type, BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static, bool inherit = false)
        {
            if (cacheAllMembers.ContainsKey((type, bindingAttr, inherit)))
            {
                return cacheAllMembers[(type, bindingAttr, inherit)];
            }
            else
            {
                MemberInfo[] memberInfos;
                if (inherit)
                {
                    memberInfos = GetAllMembersIncludingInherited(type, bindingAttr).ToArray();
                }
                else
                {
                    memberInfos = type.GetMembers(bindingAttr);
                }
                cacheAllMembers.Add((type, bindingAttr, inherit), memberInfos);
                return memberInfos;
            }
        }

        private static IEnumerable<MemberInfo> GetAllMembersIncludingInherited(Type type, BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
        {
            if (type == null) return Enumerable.Empty<MemberInfo>();
            return type.GetMembers(bindingAttr).Concat(GetAllMembersIncludingInherited(type.BaseType));
        }

        public static object Invoke(object target, string name, params object[] parameters)
        {
            if (target == null) return false;
            Type type = target.GetType();
            BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance;

            while (type != null)
            {
                MethodInfo m = type.GetMethod(name, bindingAttr);
                if (m != null) return m.Invoke(m.IsStatic ? null : target, parameters);

                type = type.BaseType;
            }
            return false;
        }

        public static bool InvokeBool(object target, string name, params object[] parameters)
        {
            if (Invoke(target, name, parameters) is bool cond)
            {
                return cond;
            }
            return false;
        }
    }
}

