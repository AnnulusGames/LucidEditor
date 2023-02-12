using System;
using System.Reflection;
using System.Linq;
using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    internal static class ProcessorUtil
    {
        private static Type[] cacheAttributeProcessorTypes;
        private static Type[] cacheGroupProcessorTypes;

        public static PropertyProcessor CreateAttributeProcessor(InspectorProperty property, Attribute attribute)
        {
            if (cacheAttributeProcessorTypes == null)
            {
                cacheAttributeProcessorTypes = Assembly.GetAssembly(typeof(PropertyProcessor))
                    .GetTypes()
                    .Where(x => x.IsSubclassOf(typeof(PropertyProcessor)) && !x.IsAbstract)
                    .ToArray();
            }

            foreach (Type t in cacheAttributeProcessorTypes)
            {
                if (t.IsDefined(typeof(CustomAttributeProcessorAttribute), false))
                {
                    CustomAttributeProcessorAttribute a = t.GetCustomAttributes(typeof(CustomAttributeProcessorAttribute), false)[0] as CustomAttributeProcessorAttribute;
                    if (a.type == attribute.GetType())
                    {
                        PropertyProcessor processor = (PropertyProcessor)Activator.CreateInstance(t);
                        processor._attribute = attribute;
                        processor._inspectorProperty = property;
                        return processor;
                    }
                }
            }

            return null;
        }

        public static PropertyGroupProcessor CreateGroupProcessor(InspectorPropertyGroup group, SerializedObject serializedObject, PropertyGroupAttribute attribute)
        {
            if (attribute == null) return null;

            if (cacheGroupProcessorTypes == null)
            {
                cacheGroupProcessorTypes = Assembly.GetAssembly(typeof(PropertyGroupProcessor))
                    .GetTypes()
                    .Where(x => x.IsSubclassOf(typeof(PropertyGroupProcessor)) && !x.IsAbstract)
                    .ToArray();
            }

            foreach (Type t in cacheGroupProcessorTypes)
            {
                if (t.IsDefined(typeof(CustomGroupProcessorAttribute), false))
                {
                    CustomGroupProcessorAttribute a = t.GetCustomAttributes(typeof(CustomGroupProcessorAttribute), false)[0] as CustomGroupProcessorAttribute;

                    if (a.type == attribute.GetType())
                    {
                        PropertyGroupProcessor processor = (PropertyGroupProcessor)Activator.CreateInstance(t);
                        processor._attribute = attribute;
                        processor._group = group;
                        processor.serializedObject = serializedObject;

                        return processor;
                    }
                }
            }

            return null;
        }
    }
}