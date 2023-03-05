using System.Collections.Generic;
using UnityEditor;

namespace AnnulusGames.LucidTools.Editor
{
    public static class LucidEditorPrefs
    {
        public static bool HasKey<T>(string key)
        {
            return EditorPrefs.HasKey(key);
        }

        public static void DeleteKey(string key)
        {
            EditorPrefs.DeleteKey(key);
        }

        public static T Get<T>(string key)
        {
            T defaultValue = default(T);
            string data = EditorPrefs.GetString(key);
            if (string.IsNullOrEmpty(data)) return defaultValue;

            switch (defaultValue)
            {
                case long longValue:
                    return GenericTypeConverter<T>.Convert<long>(long.Parse(data));
                case int intValue:
                    return GenericTypeConverter<T>.Convert<int>(int.Parse(data));
                case float floatValue:
                    return GenericTypeConverter<T>.Convert<float>(float.Parse(data));
                case double doubleValue:
                    return GenericTypeConverter<T>.Convert<double>(double.Parse(data));
                case bool boolValue:
                    return GenericTypeConverter<T>.Convert<bool>(bool.Parse(data));
                case string stringValue:
                    return GenericTypeConverter<T>.Convert<string>(data);
                default:
                    object obj = defaultValue;
                    EditorJsonUtility.FromJsonOverwrite(data, obj);
                    return (T)obj;
            }
        }

        public static void Set<T>(string key, T value)
        {
            string data = null;
            switch (value)
            {
                case long longValue:
                case int intValue:
                case double doubleValue:
                case float floatValue:
                case bool boolValue:
                case string stringValue:
                    data = value.ToString();
                    break;
                default:
                    data = EditorJsonUtility.ToJson(value);
                    break;
            }

            EditorPrefs.SetString(key, data);
        }

        public static bool HasConfigValueKey(string key)
        {
            return EditorUserSettings.GetConfigValue(key) != null;
        }

        public static T GetConfigValue<T>(string key)
        {
            T defaultValue = default(T);
            string data = EditorUserSettings.GetConfigValue(key);
            if (string.IsNullOrEmpty(data)) return defaultValue;

            switch (defaultValue)
            {
                case long longValue:
                    return GenericTypeConverter<T>.Convert<long>(long.Parse(data));
                case int intValue:
                    return GenericTypeConverter<T>.Convert<int>(int.Parse(data));
                case float floatValue:
                    return GenericTypeConverter<T>.Convert<float>(float.Parse(data));
                case double doubleValue:
                    return GenericTypeConverter<T>.Convert<double>(double.Parse(data));
                case bool boolValue:
                    return GenericTypeConverter<T>.Convert<bool>(bool.Parse(data));
                case string stringValue:
                    return GenericTypeConverter<T>.Convert<string>(data);
                default:
                    object obj = defaultValue;
                    EditorJsonUtility.FromJsonOverwrite(data, obj);
                    return (T)obj;
            }
        }

        public static void SetConfigValue<T>(string key, T value)
        {
            string data = null;
            switch (value)
            {
                case long longValue:
                case int intValue:
                case double doubleValue:
                case float floatValue:
                case bool boolValue:
                case string stringValue:
                    data = value.ToString();
                    break;
                default:
                    data = EditorJsonUtility.ToJson(value);
                    break;
            }

            EditorUserSettings.SetConfigValue(key, data);
        }

        public static LocalPersistentData<T> CreateLocalPersistentData<T>(string key)
        {
            return new LocalPersistentData<T>(key);
        }

        public static GlobalPersistentData<T> CreateGlobalPersistentData<T>(string key)
        {
            return new GlobalPersistentData<T>(key);
        }
    }

    public sealed class GlobalPersistentData<T>
    {
        internal GlobalPersistentData(string key)
        {
            this.key = key;
            value = LucidEditorPrefs.Get<T>(key);
        }

        private string key;
        private EqualityComparer<T> comparer = EqualityComparer<T>.Default;
        private T value;

        public T Value
        {
            get
            {
                return value;
            }
            set
            {
                if (!comparer.Equals(this.value, value))
                {
                    LucidEditorPrefs.Set<T>(key, value);
                }
                this.value = value;
            }
        }
    }

    public sealed class LocalPersistentData<T>
    {
        internal LocalPersistentData(string key)
        {
            this.key = key;
            value = LucidEditorPrefs.GetConfigValue<T>(key);
        }

        private string key;
        private EqualityComparer<T> comparer = EqualityComparer<T>.Default;
        private T value;

        public T Value
        {
            get
            {
                return value;
            }
            set
            {
                if (!comparer.Equals(this.value, value))
                {
                    LucidEditorPrefs.SetConfigValue<T>(key, value);
                }
                this.value = value;
            }
        }
    }
}