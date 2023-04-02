using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEditor;

namespace AnnulusGames.LucidTools.Editor
{
    internal static class TypeUtil 
    {
        private static List<Type> cacheCustomDrawerTypes;
        public static bool HasCustomDrawerType(Type type)
        {
            if (cacheCustomDrawerTypes == null)
            {
                cacheCustomDrawerTypes = new List<Type>();
                foreach (var drawer in TypeCache.GetTypesDerivedFrom<GUIDrawer>())
                {
                    foreach (CustomPropertyDrawer customAttribute in drawer.GetCustomAttributes(typeof(CustomPropertyDrawer), true))
                    {
                        var field = customAttribute.GetType().GetField("m_Type", BindingFlags.NonPublic | BindingFlags.Instance);
                        var useForChildren = customAttribute.GetType().GetField("m_UseForChildren", BindingFlags.NonPublic | BindingFlags.Instance);
                        var t = (Type)field.GetValue(customAttribute);
                        
                        if (!cacheCustomDrawerTypes.Contains(t))
                        {
                            cacheCustomDrawerTypes.Add(t);
                        }
                        if ((bool)useForChildren.GetValue(customAttribute))
                        {
                            foreach (var d in Assembly.GetAssembly(t).GetTypes().Where(x => x.IsSubclassOf(t)))
                            {
                                if (!cacheCustomDrawerTypes.Contains(d)) cacheCustomDrawerTypes.Add(d);
                            }
                        }
                    }
                }
            }
            return cacheCustomDrawerTypes.Contains(type);
        }

        private static List<Type> cacheTypes;
        public static Type GetType(string name)
        {
            foreach (Type type in GetAllTypes())
            {
                if (type.Name == name) return type;
            }
            return null;
        }

        public static IReadOnlyList<Type> GetAllTypes()
        {
            if (cacheTypes == null)
            {
                cacheTypes = new List<Type>();
                foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
                {
                    cacheTypes.AddRange(assembly.GetTypes());
                }
            }

            return cacheTypes;
        }

        public static IEnumerable<Type> GetBaseClassesAndInterfaces(Type type, bool includeSelf = false)
        {
            List<Type> allTypes = new List<Type>();

            if (includeSelf) allTypes.Add(type);

            if (type.BaseType == typeof(object))
            {
                allTypes.AddRange(type.GetInterfaces());
            }
            else
            {
                allTypes.AddRange(
                    Enumerable.Repeat(type.BaseType, 1)
                        .Concat(type.GetInterfaces())
                        .Concat(GetBaseClassesAndInterfaces(type.BaseType))
                        .Distinct());
            }

            return allTypes;
        }
    }

    internal static class GenericTypeConverter<T>
    {
        private readonly static IDictionary<Type, object> funcs = new Dictionary<Type, object>();

        // static GenericTypeConverter()
        // {
        //     funcs.Add(typeof(int), new Func<int, int>(o => o));
        //     funcs.Add(typeof(float), new Func<float, float>(o => o));
        //     funcs.Add(typeof(double), new Func<double, double>(o => o));
        //     funcs.Add(typeof(long), new Func<long, long>(o => o));
        //     funcs.Add(typeof(bool), new Func<bool, bool>(o => o));
        //     funcs.Add(typeof(string), new Func<string, string>(o => o));
        //     funcs.Add(typeof(Enum), new Func<Enum, Enum>(o => o));
        //     funcs.Add(typeof(Vector2Int), new Func<Vector2Int, Vector2Int>(o => o));
        //     funcs.Add(typeof(Vector2), new Func<Vector2, Vector2>(o => o));
        //     funcs.Add(typeof(Vector3Int), new Func<Vector3Int, Vector3Int>(o => o));
        //     funcs.Add(typeof(Vector3), new Func<Vector3, Vector3>(o => o));
        //     funcs.Add(typeof(Vector4), new Func<Vector4, Vector4>(o => o));
        //     funcs.Add(typeof(RectInt), new Func<RectInt, RectInt>(o => o));
        //     funcs.Add(typeof(Rect), new Func<Rect, Rect>(o => o));
        //     funcs.Add(typeof(BoundsInt), new Func<BoundsInt, BoundsInt>(o => o));
        //     funcs.Add(typeof(Bounds), new Func<Bounds, Bounds>(o => o));
        //     funcs.Add(typeof(UnityEngine.Object), new Func<UnityEngine.Object, UnityEngine.Object>(o => o));
        // }

        public static T Convert<TArgument>(TArgument t1)
        {
            Type argType = typeof(TArgument);
            if (!funcs.ContainsKey(argType))
            {
                funcs.Add(argType, new Func<T, T>(o => o));
            }

            var f = funcs[argType] as Func<TArgument, T>;
            return f(t1);
        }
    }

}