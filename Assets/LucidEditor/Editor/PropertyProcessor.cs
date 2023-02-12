using System;
using UnityEditor;

namespace AnnulusGames.LucidTools.Editor
{
    public abstract class PropertyProcessor
    {
        public Attribute attribute => _attribute;
        internal Attribute _attribute;

        public InspectorProperty property => _inspectorProperty;
        internal InspectorProperty _inspectorProperty;

        public LocalPersistentData<T> GetLocalPersistentData<T>(string id)
        {
            return LucidEditorPrefs.CreateLocalPersistentData<T>(
                "LucidEditor_AttributeProcessor_" +
                GlobalObjectId.GetGlobalObjectIdSlow((property.serializedObject.targetObject)) + "_" +
                property.name + "_" +
                attribute.GetType().Name + "_" +
                "id"
            );
        }

        public virtual void Initialize() { }
        public virtual void OnBeforeInspectorGUI() { }
        public virtual void OnAfterInspectorGUI() { }
        public virtual void OnBeforeDrawProperty() { }
        public virtual void OnAfterDrawProperty() { }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public sealed class CustomAttributeProcessorAttribute : Attribute
    {
        public readonly Type type;
        public CustomAttributeProcessorAttribute(Type type)
        {
            this.type = type;
        }
    }
}