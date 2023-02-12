using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AnnulusGames.LucidTools.Editor
{
    internal static class ReflectionUtil
    {
        private static Dictionary<(Type, string, BindingFlags), FieldInfo> cacheFieldInfo = new Dictionary<(Type, string, BindingFlags), FieldInfo>();
        private static Dictionary<(object, BindingFlags), MemberInfo[]> cacheAllMembers = new Dictionary<(object, BindingFlags), MemberInfo[]>();
        private static Dictionary<(object, BindingFlags), MethodInfo[]> cacheAllMethods = new Dictionary<(object, BindingFlags), MethodInfo[]>();

        private static Dictionary<(object, string), Func<object>> cacheGetFieldValue = new Dictionary<(object, string), Func<object>>();
        private static Dictionary<(object, string), Func<object>> cacheGetPropertyValue = new Dictionary<(object, string), Func<object>>();
        private static Dictionary<(object, string), Func<object>> cacheGetMethodValue = new Dictionary<(object, string), Func<object>>();

        public static object GetFieldValue(object target, Type type, string name, BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
        {
            if (cacheGetFieldValue.ContainsKey((target, name)))
            {
                if (cacheGetFieldValue[(target, name)] == null) return null;
                else return cacheGetFieldValue[(target, name)].Invoke();
            }
            else
            {
                FieldInfo info = type.GetField(name, bindingAttr);
                if (info == null)
                {
                    cacheGetFieldValue.Add((target, name), null);
                    return null;
                }

                var lambda = Expression.Lambda<Func<object>>(
                    Expression.Convert(Expression.Field(info.IsStatic ? null : Expression.Constant(target), info), typeof(object))
                );

                cacheGetFieldValue.Add((target, name), lambda.Compile());

                return cacheGetFieldValue[(target, name)].Invoke();
            }
        }

        public static object GetPropertyValue(object target, Type type, string name, BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
        {
            if (cacheGetPropertyValue.ContainsKey((target, name)))
            {
                if (cacheGetPropertyValue[(target, name)] == null) return null;
                else return cacheGetPropertyValue[(target, name)].Invoke();
            }
            else
            {
                PropertyInfo info = type.GetProperty(name, bindingAttr);
                if (info == null)
                {
                    cacheGetPropertyValue.Add((target, name), null);
                    return null;
                }

                var lambda = Expression.Lambda<Func<object>>(
                    Expression.Convert(Expression.Property(info.GetGetMethod(true).IsStatic ? null : Expression.Constant(target), info), typeof(object))
                );

                cacheGetPropertyValue.Add((target, name), lambda.Compile());

                return cacheGetPropertyValue[(target, name)].Invoke();
            }
        }

        public static object GetMethodValue(object target, Type type, string name, BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
        {
            if (cacheGetMethodValue.ContainsKey((target, name)))
            {
                if (cacheGetMethodValue[(target, name)] == null) return null;
                else return cacheGetMethodValue[(target, name)].Invoke();
            }
            else
            {
                MethodInfo info = type.GetMethod(name, bindingAttr);
                if (info == null)
                {
                    cacheGetMethodValue.Add((target, name), null);
                    return null;
                }

                var lambda = Expression.Lambda<Func<object>>(
                    Expression.Convert(Expression.Call(info.IsStatic ? null : Expression.Constant(target), info), typeof(object))
                );

                cacheGetMethodValue.Add((target, name), lambda.Compile());

                return cacheGetMethodValue[(target, name)].Invoke();
            }
        }



        public static FieldInfo GetField(Type type, string name, BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
        {
            FieldInfo info;
            if (cacheFieldInfo.ContainsKey((type, name, bindingAttr)))
            {
                info = cacheFieldInfo[(type, name, bindingAttr)];
            }
            else
            {
                info = type.GetField(name, bindingAttr);
                cacheFieldInfo.Add((type, name, bindingAttr), info);
            }
            return info;
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

        public static MemberInfo[] GetAllMembers(object target, BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
        {
            if (cacheAllMembers.ContainsKey((target, bindingAttr)))
            {
                return cacheAllMembers[(target, bindingAttr)];
            }
            else
            {
                MemberInfo[] memberInfos = target.GetType().GetMembers(bindingAttr);
                cacheAllMembers.Add((target, bindingAttr), memberInfos);
                return memberInfos;
            }
        }

        public static MethodInfo[] GetAllMethods(object target, BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
        {
            if (cacheAllMethods.ContainsKey((target, bindingAttr)))
            {
                return cacheAllMethods[(target, bindingAttr)];
            }
            else
            {
                MethodInfo[] methodInfos = target.GetType().GetMethods(bindingAttr);
                cacheAllMethods.Add((target, bindingAttr), methodInfos);
                return methodInfos;
            }
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

