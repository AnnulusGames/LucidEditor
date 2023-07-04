using System.Linq;
using UnityEngine;
using UnityEditor;
using AnnulusGames.LucidTools.Inspector;

namespace AnnulusGames.LucidTools.Editor
{
    public class LucidEditor : UnityEditor.Editor
    {
        private InspectorProperty[] properties;

        internal bool hideMonoScript;
        internal bool disableEditor;

        protected virtual void OnEnable()
        {
            hideMonoScript = target.GetType().IsDefined(typeof(HideMonoScriptAttribute), true);
            disableEditor = target.GetType().IsDefined(typeof(DisableLucidEditorAttribute), true);
        }

        public override void OnInspectorGUI()
        {
            if (disableEditor)
            {
                base.OnInspectorGUI();
                return;
            }

            serializedObject.Update();
            if (properties == null) InitializeProperties();
            ResetProperties();

            OnBeforeInspectorGUI();

            if (!hideMonoScript) LucidEditorGUILayout.ScriptField(target);
            DrawAllProperties();

            OnAfterInspectorGUI();

            serializedObject.ApplyModifiedProperties();
        }

        private void InitializeProperties()
        {
            properties = InspectorPropertyUtil.GroupProperties(InspectorPropertyUtil.CreateProperties(serializedObject)).ToArray();
            foreach (InspectorProperty property in properties)
            {
                property.Initialize();
            }
        }

        private void ResetProperties()
        {
            try
            {
                foreach (InspectorProperty property in properties)
                {
                    property.Reset();
                }
            }
            catch (System.InvalidOperationException)
            {
                InitializeProperties();
            }
        }

        private void DrawAllProperties()
        {
            foreach (InspectorProperty property in properties.OrderBy(x => x.order))
            {
                property.Draw();
            }
        }

        private void OnBeforeInspectorGUI()
        {
            foreach (InspectorProperty property in properties.OrderBy(x => x.order))
            {
                property.OnBeforeInspectorGUI();
            }
        }

        private void OnAfterInspectorGUI()
        {
            foreach (InspectorProperty property in properties.OrderBy(x => x.order))
            {
                property.OnAfterInspectorGUI();
            }
        }

    }

    [CanEditMultipleObjects]
    [CustomEditor(typeof(MonoBehaviour), true, isFallback = true)]
    internal class MonoBehaviourEditor : LucidEditor { }

    [CanEditMultipleObjects]
    [CustomEditor(typeof(ScriptableObject), true, isFallback = true)]
    internal class ScriptableObjectEditor : LucidEditor { }

}