using System;
using System.Linq;
using UnityEngine;
using UnityEditor;
using Object = UnityEngine.Object;

namespace AnnulusGames.LucidTools.Editor
{
    public static class LucidEditorGUILayout
    {
        public static Rect GetControlRect(params GUILayoutOption[] options) => EditorGUILayout.GetControlRect(options);
        public static Rect GetControlRect(bool hasLabel, params GUILayoutOption[] options) => EditorGUILayout.GetControlRect(hasLabel, options);
        public static Rect GetControlRect(bool hasLabel, float height, params GUILayoutOption[] options) => EditorGUILayout.GetControlRect(hasLabel, height, options);
        public static Rect GetControlRect(bool hasLabel, float height, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.GetControlRect(hasLabel, height, style, options);

        public static T Field<T>(T value, params GUILayoutOption[] options) => LucidEditorGUI.Field(EditorGUILayout.GetControlRect(options), value);
        public static T Field<T>(string label, T value, params GUILayoutOption[] options) => LucidEditorGUI.Field(EditorGUILayout.GetControlRect(options), label, value);
        public static T Field<T>(GUIContent label, T value, params GUILayoutOption[] options) => LucidEditorGUI.Field(EditorGUILayout.GetControlRect(options), label, value);

        public static object Field(object value, Type objType, params GUILayoutOption[] options) => LucidEditorGUI.Field(EditorGUILayout.GetControlRect(options), value, objType);
        public static object Field(string label, object value, Type objType, params GUILayoutOption[] options) => LucidEditorGUI.Field(EditorGUILayout.GetControlRect(options), label, value, objType);
        public static object Field(GUIContent label, object value, Type objType, params GUILayoutOption[] options) => LucidEditorGUI.Field(EditorGUILayout.GetControlRect(options), label, value, objType);

        public static void ReadOnlyField<T>(T value, params GUILayoutOption[] options) => LucidEditorGUI.ReadOnlyField(EditorGUILayout.GetControlRect(options), value);
        public static void ReadOnlyField<T>(string label, T value, params GUILayoutOption[] options) => LucidEditorGUI.ReadOnlyField(EditorGUILayout.GetControlRect(options), label, value);
        public static void ReadOnlyField<T>(GUIContent label, T value, params GUILayoutOption[] options) => LucidEditorGUI.ReadOnlyField(EditorGUILayout.GetControlRect(options), label, value);

        public static void ReadOnlyField(object value, Type objType, params GUILayoutOption[] options) => LucidEditorGUI.ReadOnlyField(EditorGUILayout.GetControlRect(options), value, objType);
        public static void ReadOnlyField(string label, object value, Type objType, params GUILayoutOption[] options) => LucidEditorGUI.ReadOnlyField(EditorGUILayout.GetControlRect(options), label, value, objType);
        public static void ReadOnlyField(GUIContent label, object value, Type objType, params GUILayoutOption[] options) => LucidEditorGUI.ReadOnlyField(EditorGUILayout.GetControlRect(options), label, value, objType);

        public static bool PropertyField(SerializedProperty property, params GUILayoutOption[] options) => EditorGUILayout.PropertyField(property, options);
        public static bool PropertyField(SerializedProperty property, bool includeChildren, params GUILayoutOption[] options) => EditorGUILayout.PropertyField(property, includeChildren, options);
        public static bool PropertyField(SerializedProperty property, GUIContent label, params GUILayoutOption[] options) => EditorGUILayout.PropertyField(property, label, options);
        public static bool PropertyField(SerializedProperty property, GUIContent label, bool includeChildren, params GUILayoutOption[] options) => EditorGUILayout.PropertyField(property, label, includeChildren, options);

        public static string TextField(string value, params GUILayoutOption[] options) => EditorGUILayout.TextField(value, options);
        public static string TextField(string value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.TextField(value, style, options);
        public static string TextField(string label, string value, params GUILayoutOption[] options) => EditorGUILayout.TextField(label, value, options);
        public static string TextField(string label, string value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.TextField(label, value, style, options);
        public static string TextField(GUIContent label, string value, params GUILayoutOption[] options) => EditorGUILayout.TextField(label, value, options);
        public static string TextField(GUIContent label, string value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.TextField(label, value, style, options);

        public static string DelayedTextField(string value, params GUILayoutOption[] options) => EditorGUILayout.DelayedTextField(value, options);
        public static string DelayedTextField(string value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.DelayedTextField(value, style, options);
        public static string DelayedTextField(string label, string value, params GUILayoutOption[] options) => EditorGUILayout.DelayedTextField(label, value, options);
        public static string DelayedTextField(string label, string value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.DelayedTextField(label, value, style, options);
        public static string DelayedTextField(GUIContent label, string value, params GUILayoutOption[] options) => EditorGUILayout.DelayedTextField(label, value, options);
        public static string DelayedTextField(GUIContent label, string value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.DelayedTextField(label, value, style, options);

        public static string TextArea(string text, params GUILayoutOption[] options) => EditorGUILayout.TextArea(text, options);
        public static string TextArea(string text, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.TextArea(text, style, options);

        public static string PasswordField(string password, params GUILayoutOption[] options) => EditorGUILayout.PasswordField(password, options);
        public static string PasswordField(string password, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.PasswordField(password, style, options);
        public static string PasswordField(string label, string password, params GUILayoutOption[] options) => EditorGUILayout.PasswordField(label, password, options);
        public static string PasswordField(string label, string password, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.PasswordField(label, password, style, options);
        public static string PasswordField(GUIContent label, string password, params GUILayoutOption[] options) => EditorGUILayout.PasswordField(label, password, options);
        public static string PasswordField(GUIContent label, string password, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.PasswordField(label, password, style, options);

        public static int IntField(int value, params GUILayoutOption[] options) => EditorGUILayout.IntField(value, options);
        public static int IntField(int value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.IntField(value, style, options);
        public static int IntField(string label, int value, params GUILayoutOption[] options) => EditorGUILayout.IntField(label, value, options);
        public static int IntField(string label, int value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.IntField(label, value, style, options);
        public static int IntField(GUIContent label, int value, params GUILayoutOption[] options) => EditorGUILayout.IntField(label, value, options);
        public static int IntField(GUIContent label, int value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.IntField(label, value, style, options);

        public static int DelayedIntField(int value, params GUILayoutOption[] options) => EditorGUILayout.DelayedIntField(value, options);
        public static int DelayedIntField(int value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.DelayedIntField(value, style, options);
        public static int DelayedIntField(string label, int value, params GUILayoutOption[] options) => EditorGUILayout.DelayedIntField(label, value, options);
        public static int DelayedIntField(string label, int value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.DelayedIntField(label, value, style, options);
        public static int DelayedIntField(GUIContent label, int value, params GUILayoutOption[] options) => EditorGUILayout.DelayedIntField(label, value, options);
        public static int DelayedIntField(GUIContent label, int value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.DelayedIntField(label, value, style, options);

        public static int IntPopup(int selectedValue, string[] displayedOptions, int[] optionValues, params GUILayoutOption[] options) => EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, options);
        public static int IntPopup(int selectedValue, string[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, style, options);
        public static int IntPopup(int selectedValue, GUIContent[] displayedOptions, int[] optionValues, params GUILayoutOption[] options) => EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, options);
        public static int IntPopup(int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, style, options);
        public static int IntPopup(string label, int selectedValue, string[] displayedOptions, int[] optionValues, params GUILayoutOption[] options) => EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, options);
        public static int IntPopup(string label, int selectedValue, string[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, style, options);
        public static int IntPopup(GUIContent label, int selectedValue, GUIContent[] displayedOptions, int[] optionValues, params GUILayoutOption[] options) => EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, options);
        public static int IntPopup(GUIContent label, int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, style, options);
        public static void IntPopup(SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues, params GUILayoutOption[] options) => EditorGUILayout.IntPopup(property, displayedOptions, optionValues, options);
        public static void IntPopup(SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues, GUIContent label, params GUILayoutOption[] options) => EditorGUILayout.IntPopup(property, displayedOptions, optionValues, label, options);

        public static int IntSlider(int value, int leftValue, int rightValue, params GUILayoutOption[] options) => EditorGUILayout.IntSlider(value, leftValue, rightValue, options);
        public static int IntSlider(string label, int value, int leftValue, int rightValue, params GUILayoutOption[] options) => EditorGUILayout.IntSlider(label, value, leftValue, rightValue, options);
        public static int IntSlider(GUIContent label, int value, int leftValue, int rightValue, params GUILayoutOption[] options) => EditorGUILayout.IntSlider(label, value, leftValue, rightValue, options);
        public static void IntSlider(SerializedProperty property, int leftValue, int rightValue, params GUILayoutOption[] options) => EditorGUILayout.IntSlider(property, leftValue, rightValue, options);
        public static void IntSlider(SerializedProperty property, int leftValue, int rightValue, string label, params GUILayoutOption[] options) => EditorGUILayout.IntSlider(property, leftValue, rightValue, label, options);
        public static void IntSlider(SerializedProperty property, int leftValue, int rightValue, GUIContent label, params GUILayoutOption[] options) => EditorGUILayout.IntSlider(property, leftValue, rightValue, label, options);

        public static float FloatField(float value, params GUILayoutOption[] options) => EditorGUILayout.FloatField(value, options);
        public static float FloatField(float value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.FloatField(value, style, options);
        public static float FloatField(string label, float value, params GUILayoutOption[] options) => EditorGUILayout.FloatField(label, value, options);
        public static float FloatField(string label, float value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.FloatField(label, value, style, options);
        public static float FloatField(GUIContent label, float value, params GUILayoutOption[] options) => EditorGUILayout.FloatField(label, value, options);
        public static float FloatField(GUIContent label, float value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.FloatField(label, value, style, options);

        public static float FloatSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options) => EditorGUILayout.Slider(value, leftValue, rightValue, options);
        public static float FloatSlider(string label, float value, float leftValue, float rightValue, params GUILayoutOption[] options) => EditorGUILayout.Slider(label, value, leftValue, rightValue, options);
        public static float FloatSlider(GUIContent label, float value, float leftValue, float rightValue, params GUILayoutOption[] options) => EditorGUILayout.Slider(label, value, leftValue, rightValue, options);
        public static void FloatSlider(SerializedProperty property, float leftValue, float rightValue, params GUILayoutOption[] options) => EditorGUILayout.Slider(property, leftValue, rightValue, options);
        public static void FloatSlider(SerializedProperty property, float leftValue, float rightValue, string label, params GUILayoutOption[] options) => EditorGUILayout.Slider(property, leftValue, rightValue, label, options);
        public static void FloatSlider(SerializedProperty property, float leftValue, float rightValue, GUIContent label, params GUILayoutOption[] options) => EditorGUILayout.Slider(property, leftValue, rightValue, label, options);

        public static float DelayedFloatField(float value, params GUILayoutOption[] options) => EditorGUILayout.DelayedFloatField(value, options);
        public static float DelayedFloatField(float value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.DelayedFloatField(value, style, options);
        public static float DelayedFloatField(string label, float value, params GUILayoutOption[] options) => EditorGUILayout.DelayedFloatField(label, value, options);
        public static float DelayedFloatField(string label, float value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.DelayedFloatField(label, value, style, options);
        public static float DelayedFloatField(GUIContent label, float value, params GUILayoutOption[] options) => EditorGUILayout.DelayedFloatField(label, value, options);
        public static float DelayedFloatField(GUIContent label, float value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.DelayedFloatField(label, value, style, options);

        public static double DoubleField(double value, params GUILayoutOption[] options) => EditorGUILayout.DoubleField(value, options);
        public static double DoubleField(double value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.DoubleField(value, style, options);
        public static double DoubleField(string label, double value, params GUILayoutOption[] options) => EditorGUILayout.DoubleField(label, value, options);
        public static double DoubleField(string label, double value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.DoubleField(label, value, style, options);
        public static double DoubleField(GUIContent label, double value, params GUILayoutOption[] options) => EditorGUILayout.DoubleField(label, value, options);
        public static double DoubleField(GUIContent label, double value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.DoubleField(label, value, style, options);

        public static double DelayedDoubleField(double value, params GUILayoutOption[] options) => EditorGUILayout.DelayedDoubleField(value, options);
        public static double DelayedDoubleField(double value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.DelayedDoubleField(value, style, options);
        public static double DelayedDoubleField(string label, double value, params GUILayoutOption[] options) => EditorGUILayout.DelayedDoubleField(label, value, options);
        public static double DelayedDoubleField(string label, double value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.DelayedDoubleField(label, value, style, options);
        public static double DelayedDoubleField(GUIContent label, double value, params GUILayoutOption[] options) => EditorGUILayout.DelayedDoubleField(label, value, options);
        public static double DelayedDoubleField(GUIContent label, double value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.DelayedDoubleField(label, value, style, options);

        public static long LongField(long value, params GUILayoutOption[] options) => EditorGUILayout.LongField(value, options);
        public static long LongField(long value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.LongField(value, style, options);
        public static long LongField(string label, long value, params GUILayoutOption[] options) => EditorGUILayout.LongField(label, value, options);
        public static long LongField(string label, long value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.LongField(label, value, style, options);
        public static long LongField(GUIContent label, long value, params GUILayoutOption[] options) => EditorGUILayout.LongField(label, value, options);
        public static long LongField(GUIContent label, long value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.LongField(label, value, style, options);

        public static bool Toggle(bool value, params GUILayoutOption[] options) => EditorGUILayout.Toggle(value, options);
        public static bool Toggle(bool value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.Toggle(value, style, options);
        public static bool Toggle(string label, bool value, params GUILayoutOption[] options) => EditorGUILayout.Toggle(label, value, options);
        public static bool Toggle(string label, bool value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.Toggle(label, value, style, options);
        public static bool Toggle(GUIContent label, bool value, params GUILayoutOption[] options) => EditorGUILayout.Toggle(label, value, options);
        public static bool Toggle(GUIContent label, bool value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.Toggle(label, value, style, options);

        public static bool ToggleLeft(string label, bool value, params GUILayoutOption[] options) => EditorGUILayout.ToggleLeft(label, value, options);
        public static bool ToggleLeft(string label, bool value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.ToggleLeft(label, value, style, options);
        public static bool ToggleLeft(GUIContent label, bool value, params GUILayoutOption[] options) => EditorGUILayout.ToggleLeft(label, value, options);
        public static bool ToggleLeft(GUIContent label, bool value, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.ToggleLeft(label, value, style, options);

        public static Vector2 Vector2Field(string label, Vector2 value, params GUILayoutOption[] options) => EditorGUILayout.Vector2Field(label, value, options);
        public static Vector2 Vector2Field(GUIContent label, Vector2 value, params GUILayoutOption[] options) => EditorGUILayout.Vector2Field(label, value, options);
        public static Vector2Int Vector2IntField(string label, Vector2Int value, params GUILayoutOption[] options) => EditorGUILayout.Vector2IntField(label, value, options);
        public static Vector2Int Vector2IntField(GUIContent label, Vector2Int value, params GUILayoutOption[] options) => EditorGUILayout.Vector2IntField(label, value, options);
        public static Vector3 Vector3Field(string label, Vector3 value, params GUILayoutOption[] options) => EditorGUILayout.Vector3Field(label, value, options);
        public static Vector3 Vector3Field(GUIContent label, Vector3 value, params GUILayoutOption[] options) => EditorGUILayout.Vector3Field(label, value, options);
        public static Vector3Int Vector3IntField(string label, Vector3Int value, params GUILayoutOption[] options) => EditorGUILayout.Vector3IntField(label, value, options);
        public static Vector3Int Vector3IntField(GUIContent label, Vector3Int value, params GUILayoutOption[] options) => EditorGUILayout.Vector3IntField(label, value, options);
        public static Vector4 Vector4Field(string label, Vector4 value, params GUILayoutOption[] options) => EditorGUILayout.Vector4Field(label, value, options);
        public static Vector4 Vector4Field(GUIContent label, Vector4 value, params GUILayoutOption[] options) => EditorGUILayout.Vector4Field(label, value, options);

        public static Color ColorField(Color value, params GUILayoutOption[] options) => EditorGUILayout.ColorField(value, options);
        public static Color ColorField(string label, Color value, params GUILayoutOption[] options) => EditorGUILayout.ColorField(label, value, options);
        public static Color ColorField(GUIContent label, Color value, params GUILayoutOption[] options) => EditorGUILayout.ColorField(label, value, options);
        public static Color ColorField(GUIContent label, Color value, bool showEyedropper, bool showAlpha, bool hdr, params GUILayoutOption[] options) => EditorGUILayout.ColorField(label, value, showEyedropper, showAlpha, hdr, options);

        public static Gradient GradientField(Gradient gradient, params GUILayoutOption[] options) => EditorGUILayout.GradientField(gradient, options);
        public static Gradient GradientField(string label, Gradient gradient, params GUILayoutOption[] options) => EditorGUILayout.GradientField(label, gradient, options);
        public static Gradient GradientField(GUIContent label, Gradient gradient, params GUILayoutOption[] options) => EditorGUILayout.GradientField(label, gradient, options);
        public static Gradient GradientField(GUIContent label, Gradient gradient, bool hdr, params GUILayoutOption[] options) => EditorGUILayout.GradientField(label, gradient, hdr, options);

        public static AnimationCurve CurveField(AnimationCurve value, params GUILayoutOption[] options) => EditorGUILayout.CurveField(value, options);
        public static AnimationCurve CurveField(string label, AnimationCurve value, params GUILayoutOption[] options) => EditorGUILayout.CurveField(label, value, options);
        public static AnimationCurve CurveField(GUIContent label, AnimationCurve value, params GUILayoutOption[] options) => EditorGUILayout.CurveField(label, value, options);
        public static AnimationCurve CurveField(AnimationCurve value, Color color, Rect ranges, params GUILayoutOption[] options) => EditorGUILayout.CurveField(value, color, ranges, options);
        public static AnimationCurve CurveField(string label, AnimationCurve value, Color color, Rect ranges, params GUILayoutOption[] options) => EditorGUILayout.CurveField(label, value, color, ranges, options);
        public static AnimationCurve CurveField(GUIContent label, AnimationCurve value, Color color, Rect ranges, params GUILayoutOption[] options) => EditorGUILayout.CurveField(label, value, color, ranges, options);
        public static void CurveField(SerializedProperty property, Color color, Rect ranges, params GUILayoutOption[] options) => EditorGUILayout.CurveField(property, color, ranges, options);
        public static void CurveField(SerializedProperty property, Color color, Rect ranges, GUIContent label, params GUILayoutOption[] options) => EditorGUILayout.CurveField(property, color, ranges, label, options);

        public static Bounds BoundsField(Bounds value, params GUILayoutOption[] options) => EditorGUILayout.BoundsField(value, options);
        public static Bounds BoundsField(string label, Bounds value, params GUILayoutOption[] options) => EditorGUILayout.BoundsField(label, value, options);
        public static Bounds BoundsField(GUIContent label, Bounds value, params GUILayoutOption[] options) => EditorGUILayout.BoundsField(label, value, options);

        public static BoundsInt BoundsIntField(BoundsInt value, params GUILayoutOption[] options) => EditorGUILayout.BoundsIntField(value, options);
        public static BoundsInt BoundsIntField(string label, BoundsInt value, params GUILayoutOption[] options) => EditorGUILayout.BoundsIntField(label, value, options);
        public static BoundsInt BoundsIntField(GUIContent label, BoundsInt value, params GUILayoutOption[] options) => EditorGUILayout.BoundsIntField(label, value, options);

        public static Rect RectField(Rect value, params GUILayoutOption[] options) => EditorGUILayout.RectField(value, options);
        public static Rect RectField(string label, Rect value, params GUILayoutOption[] options) => EditorGUILayout.RectField(label, value, options);
        public static Rect RectField(GUIContent label, Rect value, params GUILayoutOption[] options) => EditorGUILayout.RectField(label, value, options);

        public static RectInt RectIntField(RectInt value, params GUILayoutOption[] options) => EditorGUILayout.RectIntField(value, options);
        public static RectInt RectIntField(string label, RectInt value, params GUILayoutOption[] options) => EditorGUILayout.RectIntField(label, value, options);
        public static RectInt RectIntField(GUIContent label, RectInt value, params GUILayoutOption[] options) => EditorGUILayout.RectIntField(label, value, options);

        public static Enum EnumFlagsField(Enum enumValue, params GUILayoutOption[] options) => EditorGUILayout.EnumFlagsField(enumValue, options);
        public static Enum EnumFlagsField(Enum enumValue, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.EnumFlagsField(enumValue, style, options);
        public static Enum EnumFlagsField(string label, Enum enumValue, params GUILayoutOption[] options) => EditorGUILayout.EnumFlagsField(label, enumValue, options);
        public static Enum EnumFlagsField(string label, Enum enumValue, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.EnumFlagsField(label, enumValue, style, options);
        public static Enum EnumFlagsField(GUIContent label, Enum enumValue, params GUILayoutOption[] options) => EditorGUILayout.EnumFlagsField(label, enumValue, options);
        public static Enum EnumFlagsField(GUIContent label, Enum enumValue, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.EnumFlagsField(label, enumValue, style, options);
        public static Enum EnumFlagsField(GUIContent label, Enum enumValue, bool includeObsolete, params GUILayoutOption[] options) => EditorGUILayout.EnumFlagsField(label, enumValue, includeObsolete, options);
        public static Enum EnumFlagsField(GUIContent label, Enum enumValue, bool includeObsolete, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.EnumFlagsField(label, enumValue, includeObsolete, style, options);

        public static TEnum EnumFlagsField<TEnum>(TEnum enumValue, params GUILayoutOption[] options) where TEnum : Enum => (TEnum)EditorGUILayout.EnumFlagsField(enumValue, options);
        public static TEnum EnumFlagsField<TEnum>(TEnum enumValue, GUIStyle style, params GUILayoutOption[] options) where TEnum : Enum => (TEnum)EditorGUILayout.EnumFlagsField(enumValue, style, options);
        public static TEnum EnumFlagsField<TEnum>(string label, TEnum enumValue, params GUILayoutOption[] options) where TEnum : Enum => (TEnum)EditorGUILayout.EnumFlagsField(label, enumValue, options);
        public static TEnum EnumFlagsField<TEnum>(string label, TEnum enumValue, GUIStyle style, params GUILayoutOption[] options) where TEnum : Enum => (TEnum)EditorGUILayout.EnumFlagsField(label, enumValue, style, options);
        public static TEnum EnumFlagsField<TEnum>(GUIContent label, TEnum enumValue, params GUILayoutOption[] options) where TEnum : Enum => (TEnum)EditorGUILayout.EnumFlagsField(label, enumValue, options);
        public static TEnum EnumFlagsField<TEnum>(GUIContent label, TEnum enumValue, GUIStyle style, params GUILayoutOption[] options) where TEnum : Enum => (TEnum)EditorGUILayout.EnumFlagsField(label, enumValue, style, options);
        public static TEnum EnumFlagsField<TEnum>(GUIContent label, TEnum enumValue, bool includeObsolete, params GUILayoutOption[] options) where TEnum : Enum => (TEnum)EditorGUILayout.EnumFlagsField(label, enumValue, includeObsolete, options);
        public static TEnum EnumFlagsField<TEnum>(GUIContent label, TEnum enumValue, bool includeObsolete, GUIStyle style, params GUILayoutOption[] options) where TEnum : Enum => (TEnum)EditorGUILayout.EnumFlagsField(label, enumValue, includeObsolete, style, options);

        public static Enum EnumPopup(Enum selected, params GUILayoutOption[] options) => EditorGUILayout.EnumPopup(selected, options);
        public static Enum EnumPopup(Enum selected, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.EnumPopup(selected, style, options);
        public static Enum EnumPopup(string label, Enum selected, params GUILayoutOption[] options) => EditorGUILayout.EnumPopup(label, selected, options);
        public static Enum EnumPopup(string label, Enum selected, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.EnumPopup(label, selected, style, options);
        public static Enum EnumPopup(GUIContent label, Enum selected, params GUILayoutOption[] options) => EditorGUILayout.EnumPopup(label, selected, options);
        public static Enum EnumPopup(GUIContent label, Enum selected, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.EnumPopup(label, selected, style, options);
        public static Enum EnumPopup(GUIContent label, Enum selected, Func<Enum, bool> checkEnabled, bool includeObsolete, params GUILayoutOption[] options) => EditorGUILayout.EnumPopup(label, selected, checkEnabled, includeObsolete, options);
        public static Enum EnumPopup(GUIContent label, Enum selected, Func<Enum, bool> checkEnabled, bool includeObsolete, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.EnumPopup(label, selected, checkEnabled, includeObsolete, style, options);

        public static TEnum EnumPopup<TEnum>(TEnum selected, params GUILayoutOption[] options) where TEnum : Enum => (TEnum)EditorGUILayout.EnumPopup(selected, options);
        public static TEnum EnumPopup<TEnum>(TEnum selected, GUIStyle style, params GUILayoutOption[] options) where TEnum : Enum => (TEnum)EditorGUILayout.EnumPopup(selected, style, options);
        public static TEnum EnumPopup<TEnum>(string label, TEnum selected, params GUILayoutOption[] options) where TEnum : Enum => (TEnum)EditorGUILayout.EnumPopup(label, selected, options);
        public static TEnum EnumPopup<TEnum>(string label, TEnum selected, GUIStyle style, params GUILayoutOption[] options) where TEnum : Enum => (TEnum)EditorGUILayout.EnumPopup(label, selected, style, options);
        public static TEnum EnumPopup<TEnum>(GUIContent label, TEnum selected, params GUILayoutOption[] options) where TEnum : Enum => (TEnum)EditorGUILayout.EnumPopup(label, selected, options);
        public static TEnum EnumPopup<TEnum>(GUIContent label, TEnum selected, GUIStyle style, params GUILayoutOption[] options) where TEnum : Enum => (TEnum)EditorGUILayout.EnumPopup(label, selected, style, options);
        public static TEnum EnumPopup<TEnum>(GUIContent label, TEnum selected, Func<Enum, bool> checkEnabled, bool includeObsolete, params GUILayoutOption[] options) where TEnum : Enum => (TEnum)EditorGUILayout.EnumPopup(label, selected, checkEnabled, includeObsolete, options);
        public static TEnum EnumPopup<TEnum>(GUIContent label, TEnum selected, Func<Enum, bool> checkEnabled, bool includeObsolete, GUIStyle style, params GUILayoutOption[] options) where TEnum : Enum => (TEnum)EditorGUILayout.EnumPopup(label, selected, checkEnabled, includeObsolete, style, options);

        public static Object ObjectField(Object obj, Type objType, bool allowSceneObjects, params GUILayoutOption[] options) => EditorGUILayout.ObjectField(obj, objType, allowSceneObjects, options);
        public static Object ObjectField(string label, Object obj, Type objType, bool allowSceneObjects, params GUILayoutOption[] options) => EditorGUILayout.ObjectField(label, obj, objType, allowSceneObjects, options);
        public static Object ObjectField(GUIContent label, Object obj, Type objType, bool allowSceneObjects, params GUILayoutOption[] options) => EditorGUILayout.ObjectField(label, obj, objType, allowSceneObjects, options);
        public static T ObjectField<T>(T obj, bool allowSceneObjects, params GUILayoutOption[] options) where T : Object => (T)EditorGUILayout.ObjectField(obj, typeof(T), allowSceneObjects, options);
        public static T ObjectField<T>(string label, T obj, bool allowSceneObjects, params GUILayoutOption[] options) where T : Object => (T)EditorGUILayout.ObjectField(label, obj, typeof(T), allowSceneObjects, options);
        public static T ObjectField<T>(GUIContent label, T obj, bool allowSceneObjects, params GUILayoutOption[] options) where T : Object => (T)EditorGUILayout.ObjectField(label, obj, typeof(T), allowSceneObjects, options);
        public static void ObjectField(SerializedProperty property, params GUILayoutOption[] options) => EditorGUILayout.ObjectField(property, options);
        public static void ObjectField(SerializedProperty property, GUIContent label, params GUILayoutOption[] options) => EditorGUILayout.ObjectField(property, label, options);
        public static void ObjectField(SerializedProperty property, Type objType, params GUILayoutOption[] options) => EditorGUILayout.ObjectField(property, objType, options);
        public static void ObjectField(SerializedProperty property, Type objType, GUIContent label, params GUILayoutOption[] options) => EditorGUILayout.ObjectField(property, objType, label, options);
        public static void ObjectField<T>(SerializedProperty property, params GUILayoutOption[] options) => EditorGUILayout.ObjectField(property, typeof(T), options);
        public static void ObjectField<T>(SerializedProperty property, GUIContent label, params GUILayoutOption[] options) => EditorGUILayout.ObjectField(property, typeof(T), label, options);

        public static string TagField(string tag, params GUILayoutOption[] options) => EditorGUILayout.TagField(tag, options);
        public static string TagField(string tag, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.TagField(tag, style, options);
        public static string TagField(string label, string tag, params GUILayoutOption[] options) => EditorGUILayout.TagField(label, tag, options);
        public static string TagField(string label, string tag, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.TagField(label, tag, style, options);
        public static string TagField(GUIContent label, string tag, params GUILayoutOption[] options) => EditorGUILayout.TagField(label, tag, options);
        public static string TagField(GUIContent label, string tag, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.TagField(label, tag, style, options);

        public static int LayerField(int layer, params GUILayoutOption[] options) => EditorGUILayout.LayerField(layer, options);
        public static int LayerField(int layer, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.LayerField(layer, style, options);
        public static int LayerField(string label, int layer, params GUILayoutOption[] options) => EditorGUILayout.LayerField(label, layer, options);
        public static int LayerField(string label, int layer, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.LayerField(label, layer, style, options);
        public static int LayerField(GUIContent label, int layer, params GUILayoutOption[] options) => EditorGUILayout.LayerField(label, layer, options);
        public static int LayerField(GUIContent label, int layer, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.LayerField(label, layer, style, options);

        public static int MaskField(GUIContent label, int mask, string[] displayedOptions, params GUILayoutOption[] options) => EditorGUILayout.MaskField(label, mask, displayedOptions, options);
        public static int MaskField(GUIContent label, int mask, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.MaskField(label, mask, displayedOptions, style, options);
        public static int MaskField(string label, int mask, string[] displayedOptions, params GUILayoutOption[] options) => EditorGUILayout.MaskField(label, mask, displayedOptions, options);
        public static int MaskField(string label, int mask, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.MaskField(label, mask, displayedOptions, style, options);
        public static int MaskField(int mask, string[] displayedOptions, params GUILayoutOption[] options) => EditorGUILayout.MaskField(mask, displayedOptions, options);
        public static int MaskField(int mask, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.MaskField(mask, displayedOptions, style, options);

        public static int Popup(int selectedIndex, string[] displayedOptions, params GUILayoutOption[] options) => EditorGUILayout.Popup(selectedIndex, displayedOptions, options);
        public static int Popup(int selectedIndex, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.Popup(selectedIndex, displayedOptions, style, options);
        public static int Popup(int selectedIndex, GUIContent[] displayedOptions, params GUILayoutOption[] options) => EditorGUILayout.Popup(selectedIndex, displayedOptions, options);
        public static int Popup(int selectedIndex, GUIContent[] displayedOptions, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.Popup(selectedIndex, displayedOptions, style, options);
        public static int Popup(string label, int selectedIndex, string[] displayedOptions, params GUILayoutOption[] options) => EditorGUILayout.Popup(label, selectedIndex, displayedOptions, options);
        public static int Popup(string label, int selectedIndex, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.Popup(label, selectedIndex, displayedOptions, style, options);
        public static int Popup(GUIContent label, int selectedIndex, GUIContent[] displayedOptions, params GUILayoutOption[] options) => EditorGUILayout.Popup(label, selectedIndex, displayedOptions, options);
        public static int Popup(GUIContent label, int selectedIndex, GUIContent[] displayedOptions, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.Popup(label, selectedIndex, displayedOptions, style, options);

        public static void LabelField(string label, params GUILayoutOption[] options) => EditorGUILayout.LabelField(label, options);
        public static void LabelField(string label, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.LabelField(label, style, options);
        public static void LabelField(GUIContent label, params GUILayoutOption[] options) => EditorGUILayout.LabelField(label, options);
        public static void LabelField(GUIContent label, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.LabelField(label, style, options);
        public static void LabelField(string label, string label2, params GUILayoutOption[] options) => EditorGUILayout.LabelField(label, label2, options);
        public static void LabelField(string label, string label2, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.LabelField(label, label2, style, options);
        public static void LabelField(GUIContent label, GUIContent label2, params GUILayoutOption[] options) => EditorGUILayout.LabelField(label, label2, options);
        public static void LabelField(GUIContent label, GUIContent label2, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.LabelField(label, label2, style, options);

        public static void PrefixLabel(string label) => EditorGUILayout.PrefixLabel(label);
        public static void PrefixLabel(string label, GUIStyle followingStyle) => EditorGUILayout.PrefixLabel(label, followingStyle);
        public static void PrefixLabel(string label, GUIStyle followingStyle, GUIStyle labelStyle) => EditorGUILayout.PrefixLabel(label, followingStyle, labelStyle);
        public static void PrefixLabel(GUIContent label) => EditorGUILayout.PrefixLabel(label);
        public static void PrefixLabel(GUIContent label, GUIStyle followingStyle) => EditorGUILayout.PrefixLabel(label, followingStyle);
        public static void PrefixLabel(GUIContent label, GUIStyle followingStyle, GUIStyle labelStyle) => EditorGUILayout.PrefixLabel(label, followingStyle, labelStyle);

        public static void SelectableLabel(string text, params GUILayoutOption[] options) => EditorGUILayout.SelectableLabel(text, options);
        public static void SelectableLabel(string text, GUIStyle style, params GUILayoutOption[] options) => EditorGUILayout.SelectableLabel(text, style, options);

        public static bool InspectorTitlebar(bool foldout, Object targetObj, bool expandable) => EditorGUILayout.InspectorTitlebar(foldout, targetObj, expandable);
        public static bool InspectorTitlebar(bool foldout, Object[] targetObjs, bool expandable) => EditorGUILayout.InspectorTitlebar(foldout, targetObjs, expandable);

        public static void MinMaxSlider(ref float minValue, ref float maxValue, float minLimit, float maxLimit, params GUILayoutOption[] options) => EditorGUILayout.MinMaxSlider(ref minValue, ref maxValue, minLimit, maxLimit, options);
        public static void MinMaxSlider(string label, ref float minValue, ref float maxValue, float minLimit, float maxLimit, params GUILayoutOption[] options) => EditorGUILayout.MinMaxSlider(label, ref minValue, ref maxValue, minLimit, maxLimit, options);
        public static void MinMaxSlider(GUIContent label, ref float minValue, ref float maxValue, float minLimit, float maxLimit, params GUILayoutOption[] options) => EditorGUILayout.MinMaxSlider(label, ref minValue, ref maxValue, minLimit, maxLimit, options);

        public static void ProgressBar(float value, string text)
        {
            Rect position = EditorGUILayout.GetControlRect();
            EditorGUI.ProgressBar(position, value, text);
        }

        public static void HelpBox(string message, MessageType type) => EditorGUILayout.HelpBox(message, type);
        public static void HelpBox(string message, MessageType type, bool wide) => EditorGUILayout.HelpBox(message, type, wide);

        public static bool Foldout(bool foldout, string content) => EditorGUILayout.Foldout(foldout, content);
        public static bool Foldout(bool foldout, string content, GUIStyle style) => EditorGUILayout.Foldout(foldout, content, style);
        public static bool Foldout(bool foldout, string content, bool toggleOnLabelClick) => EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick);
        public static bool Foldout(bool foldout, string content, bool toggleOnLabelClick, GUIStyle style) => EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick, style);
        public static bool Foldout(bool foldout, GUIContent content) => EditorGUILayout.Foldout(foldout, content);
        public static bool Foldout(bool foldout, GUIContent content, GUIStyle style) => EditorGUILayout.Foldout(foldout, content, style);
        public static bool Foldout(bool foldout, GUIContent content, bool toggleOnLabelClick) => EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick);
        public static bool Foldout(bool foldout, GUIContent content, bool toggleOnLabelClick, GUIStyle style) => EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick, style);

        public static bool FolderFoldout(bool foldout, string text, bool toggleOnLabelClick = true)
        {
            GUIContent folderContent = foldout ? EditorIcons.FolderOpenedIcon : EditorIcons.FolderIcon;
            folderContent.text = text;
            return EditorGUILayout.Foldout(foldout, folderContent, toggleOnLabelClick);
        }

        public static bool ToggleFoldout(bool foldout, ref bool toggle, string text, bool toggleOnLabelClick = true)
        {
            Rect position = EditorGUILayout.GetControlRect();
            return LucidEditorGUI.ToggleFoldout(position, foldout, ref toggle, text, toggleOnLabelClick);
        }

        public static bool FoldoutHeader(bool foldout, string content) => EditorGUILayout.Foldout(foldout, content, EditorStyles.foldoutHeader);
        public static bool FoldoutHeader(bool foldout, string content, bool toggleOnLabelClick) => EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick, EditorStyles.foldoutHeader);
        public static bool FoldoutHeader(bool foldout, GUIContent content) => EditorGUILayout.Foldout(foldout, content, EditorStyles.foldoutHeader);
        public static bool FoldoutHeader(bool foldout, GUIContent content, bool toggleOnLabelClick) => EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick, EditorStyles.foldoutHeader);

        public static bool Button(string content, params GUILayoutOption[] options) => GUILayout.Button(content, options);
        public static bool Button(string content, Action action, params GUILayoutOption[] options)
        {
            bool value = GUILayout.Button(content, options);
            if (value) action?.Invoke();
            return value;
        }
        public static bool Button(string content, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Button(content, style, options);
        public static bool Button(string content, GUIStyle style, Action action, params GUILayoutOption[] options)
        {
            bool value = GUILayout.Button(content, style, options);
            if (value) action?.Invoke();
            return value;
        }
        public static bool Button(Texture image, params GUILayoutOption[] options) => GUILayout.Button(image, options);
        public static bool Button(Texture image, Action action, params GUILayoutOption[] options)
        {
            bool value = GUILayout.Button(image, options);
            if (value) action?.Invoke();
            return value;
        }
        public static bool Button(Texture image, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Button(image, style, options);
        public static bool Button(Texture image, GUIStyle style, Action action, params GUILayoutOption[] options)
        {
            bool value = GUILayout.Button(image, style, options);
            if (value) action?.Invoke();
            return value;
        }
        public static bool Button(GUIContent content, params GUILayoutOption[] options) => GUILayout.Button(content, options);
        public static bool Button(GUIContent content, Action action, params GUILayoutOption[] options)
        {
            bool value = GUILayout.Button(content, options);
            if (value) action?.Invoke();
            return value;
        }
        public static bool Button(GUIContent content, GUIStyle style, params GUILayoutOption[] options) => GUILayout.Button(content, style, options);
        public static bool Button(GUIContent content, GUIStyle style, Action action, params GUILayoutOption[] options)
        {
            bool value = GUILayout.Button(content, style, options);
            if (value) action?.Invoke();
            return value;
        }

        public static bool RepeatButton(string content, params GUILayoutOption[] options) => GUILayout.RepeatButton(content, options);
        public static bool RepeatButton(string content, Action action, params GUILayoutOption[] options)
        {
            bool value = GUILayout.RepeatButton(content, options);
            if (value) action?.Invoke();
            return value;
        }
        public static bool RepeatButton(string content, GUIStyle style, params GUILayoutOption[] options) => GUILayout.RepeatButton(content, style, options);
        public static bool RepeatButton(string content, GUIStyle style, Action action, params GUILayoutOption[] options)
        {
            bool value = GUILayout.RepeatButton(content, style, options);
            if (value) action?.Invoke();
            return value;
        }
        public static bool RepeatButton(Texture image, params GUILayoutOption[] options) => GUILayout.RepeatButton(image, options);
        public static bool RepeatButton(Texture image, Action action, params GUILayoutOption[] options)
        {
            bool value = GUILayout.RepeatButton(image, options);
            if (value) action?.Invoke();
            return value;
        }
        public static bool RepeatButton(Texture image, GUIStyle style, params GUILayoutOption[] options) => GUILayout.RepeatButton(image, style, options);
        public static bool RepeatButton(Texture image, GUIStyle style, Action action, params GUILayoutOption[] options)
        {
            bool value = GUILayout.RepeatButton(image, style, options);
            if (value) action?.Invoke();
            return value;
        }
        public static bool RepeatButton(GUIContent content, params GUILayoutOption[] options) => GUILayout.RepeatButton(content, options);
        public static bool RepeatButton(GUIContent content, Action action, params GUILayoutOption[] options)
        {
            bool value = GUILayout.RepeatButton(content, options);
            if (value) action?.Invoke();
            return value;
        }
        public static bool RepeatButton(GUIContent content, GUIStyle style, params GUILayoutOption[] options) => GUILayout.RepeatButton(content, style, options);
        public static bool RepeatButton(GUIContent content, GUIStyle style, Action action, params GUILayoutOption[] options)
        {
            bool value = GUILayout.RepeatButton(content, style, options);
            if (value) action?.Invoke();
            return value;
        }

        public static bool LinkButton(string text, params GUILayoutOption[] options)
        {
            Rect position = EditorGUILayout.GetControlRect(options);
            LucidEditorGUI.Line(new Rect(position.x, position.y + position.height, position.width, position.height), EditorStyles.linkLabel.normal.textColor);
            return LucidEditorGUI.Button(position, text, EditorStyles.linkLabel);
        }

        public static bool LinkButton(string text, Action action, params GUILayoutOption[] options)
        {
            Rect position = EditorGUILayout.GetControlRect(options);
            LucidEditorGUI.Line(new Rect(position.x, position.y + position.height, position.width, position.height), EditorStyles.linkLabel.normal.textColor);
            bool value = LucidEditorGUI.Button(position, text, EditorStyles.linkLabel);
            if (value) action?.Invoke();
            return value;
        }

        public static void Line(params GUILayoutOption[] options)
        {
            Line(1f, EditorColors.line, options);
        }

        public static void Line(Color color, params GUILayoutOption[] options)
        {
            Line(1f, color, options);
        }

        public static void Line(float height, Color color, params GUILayoutOption[] options)
        {
            Rect rect = EditorGUILayout.GetControlRect(false, 1f, options);
            rect.height = height;
            EditorGUI.DrawRect(rect, color);
        }

        public static void Header(string label, params GUILayoutOption[] options)
        {
            EditorGUILayout.LabelField(label, EditorStyles.boldLabel, options);
        }

        public static void Header(GUIContent label, params GUILayoutOption[] options)
        {
            EditorGUILayout.LabelField(label, EditorStyles.boldLabel, options);
        }

        public static void BoxHeader(GUIContent label, params GUILayoutOption[] options)
        {
            Rect rect = EditorGUILayout.GetControlRect(options);
            LucidEditorGUI.BoxHeader(rect, label);
        }

        public static void BoxHeader(string label, params GUILayoutOption[] options)
        {
            Rect rect = EditorGUILayout.GetControlRect(options);
            LucidEditorGUI.BoxHeader(rect, label);
        }

        public static void TitleHeader(string label, params GUILayoutOption[] options)
        {
            TitleHeader(label, EditorColors.line, options);
        }

        public static void TitleHeader(GUIContent label, params GUILayoutOption[] options)
        {
            TitleHeader(label, EditorColors.line, options);
        }

        public static void TitleHeader(string label, Color lineColor, params GUILayoutOption[] options)
        {
            Rect position = EditorGUILayout.GetControlRect(options);
            Rect lineRect = position;
            lineRect.xMin += EditorGUI.indentLevel * 15f;
            lineRect.y = position.yMax - 1;
            LucidEditorGUI.Line(lineRect, lineColor);
            EditorGUI.LabelField(position, label, EditorStyles.boldLabel);
            Space(3);
        }

        public static void TitleHeader(GUIContent label, Color lineColor, params GUILayoutOption[] options)
        {
            Rect position = EditorGUILayout.GetControlRect(options);
            Rect lineRect = position;
            lineRect.xMin += EditorGUI.indentLevel * 15f;
            lineRect.y = position.yMax - 1;
            LucidEditorGUI.Line(lineRect, lineColor);
            EditorGUI.LabelField(position, label, EditorStyles.boldLabel);
            Space(3);
        }

        public static void SectionHeader(GUIContent label, params GUILayoutOption[] options)
        {
            SectionHeader(label, EditorColors.helpBox, EditorColors.thinLine, options);
        }

        public static void SectionHeader(string label, params GUILayoutOption[] options)
        {
            SectionHeader(label, EditorColors.helpBox, EditorColors.thinLine, options);
        }

        public static void SectionHeader(GUIContent label, Color backgroundColor, params GUILayoutOption[] options)
        {
            SectionHeader(label, backgroundColor, EditorColors.thinLine, options);
        }

        public static void SectionHeader(string label, Color backgroundColor, params GUILayoutOption[] options)
        {
            SectionHeader(label, backgroundColor, EditorColors.thinLine, options);
        }

        public static void SectionHeader(string label, Color backgroundColor, Color lineColor, params GUILayoutOption[] options)
        {
            Rect position = EditorGUILayout.GetControlRect(false, EditorGUIUtility.singleLineHeight + 5f, options);
            position.xMin += EditorGUI.indentLevel * 15f;
            LucidEditorGUI.SectionHeader(position, label, backgroundColor, lineColor);
            Space(1);
        }

        public static void SectionHeader(GUIContent label, Color backgroundColor, Color lineColor, params GUILayoutOption[] options)
        {
            Rect position = EditorGUILayout.GetControlRect(false, EditorGUIUtility.singleLineHeight + 5f, options);
            position.xMin += EditorGUI.indentLevel * 15f;
            LucidEditorGUI.SectionHeader(position, label, backgroundColor, lineColor);
            Space(1);
        }

        public static bool SectionFoldout(bool foldout, string label, params GUILayoutOption[] options)
        {
            return SectionFoldout(foldout, label, EditorColors.tab, EditorColors.thinLine, true);
        }

        public static bool SectionFoldout(bool foldout, GUIContent label, params GUILayoutOption[] options)
        {
            return SectionFoldout(foldout, label, EditorColors.tab, EditorColors.thinLine, true);
        }

        public static bool SectionFoldout(bool foldout, string label, bool toggleOnLabelClick, params GUILayoutOption[] options)
        {
            return SectionFoldout(foldout, label, EditorColors.tab, EditorColors.thinLine, toggleOnLabelClick);
        }

        public static bool SectionFoldout(bool foldout, GUIContent label, bool toggleOnLabelClick, params GUILayoutOption[] options)
        {
            return SectionFoldout(foldout, label, EditorColors.tab, EditorColors.thinLine, toggleOnLabelClick);
        }

        public static bool SectionFoldout(bool foldout, string label, Color backgroundColor, Color lineColor, bool toggleOnLabelClick, params GUILayoutOption[] options)
        {
            Rect position = EditorGUILayout.GetControlRect(false, EditorGUIUtility.singleLineHeight + 5f, options);
            bool value = LucidEditorGUI.SectionFoldout(position, foldout, label, backgroundColor, lineColor, toggleOnLabelClick);
            Space(3);
            return value;
        }

        public static bool SectionFoldout(bool foldout, GUIContent label, Color backgroundColor, Color lineColor, bool toggleOnLabelClick, params GUILayoutOption[] options)
        {
            Rect position = EditorGUILayout.GetControlRect(false, EditorGUIUtility.singleLineHeight + 5f, options);
            bool value = LucidEditorGUI.SectionFoldout(position, foldout, label, backgroundColor, lineColor, toggleOnLabelClick);
            Space(3);
            return value;
        }

        public static void Blockquote(string label, params GUILayoutOption[] options)
        {
            Blockquote(label, EditorStyles.label, options);
        }

        public static void Blockquote(GUIContent label, params GUILayoutOption[] options)
        {
            Blockquote(label, EditorStyles.label, options);
        }

        public static void Blockquote(string label, GUIStyle style, params GUILayoutOption[] options)
        {
            Blockquote(new GUIContent(label), style, options);
        }

        public static void Blockquote(GUIContent label, GUIStyle style, params GUILayoutOption[] options)
        {
            Rect position = GUILayoutUtility.GetRect(label, style, options);
            position.height += EditorGUIUtility.singleLineHeight * 0.5f;
            EditorGUILayout.GetControlRect(false, EditorGUIUtility.singleLineHeight * 0.5f);
            
            LucidEditorGUI.DrawQuoteLine(position, style);

            Rect labelPosition = position;
            labelPosition.xMin += 7f;
            EditorGUI.LabelField(labelPosition, label, style);
        }

        public static void ScriptField(Object target, params GUILayoutOption[] options)
        {
            LucidEditorGUI.ScriptField(EditorGUILayout.GetControlRect(options), target);
        }

        public static int Toolbar(int selectedIndex, string[] displayedOptions, params GUILayoutOption[] options)
        {
            int value = Toolbar(selectedIndex, displayedOptions, GUI.ToolbarButtonSize.Fixed, options);
            Space(5);
            return value;
        }

        public static int Toolbar(int selectedIndex, string[] displayedOptions, GUI.ToolbarButtonSize toolbarButtonSize, params GUILayoutOption[] options)
        {
            Rect position = EditorGUILayout.GetControlRect(options);
            int value = LucidEditorGUI.Toolbar(position, selectedIndex, displayedOptions, toolbarButtonSize);
            Space(5);
            return value;
        }

        public static void Space() => EditorGUILayout.Space();
        public static void Space(float width) => EditorGUILayout.Space(width);
        public static void Space(float width, bool expand) => EditorGUILayout.Space(width, expand);


        public static Rect BeginVertical()
        {
            return EditorGUILayout.BeginVertical();
        }

        public static Rect BeginVertical(params GUILayoutOption[] options)
        {
            return EditorGUILayout.BeginVertical(options);
        }

        public static Rect BeginVertical(GUIStyle style, params GUILayoutOption[] options)
        {
            return EditorGUILayout.BeginVertical(style, options);
        }

        public static void EndVertical()
        {
            EditorGUILayout.EndVertical();
        }

        public static Rect BeginHorizontal()
        {
            return EditorGUILayout.BeginHorizontal();
        }

        public static Rect BeginHorizontal(params GUILayoutOption[] options)
        {
            return EditorGUILayout.BeginHorizontal(options);
        }

        public static Rect BeginHorizontal(GUIStyle style, params GUILayoutOption[] options)
        {
            return EditorGUILayout.BeginHorizontal(style, options);
        }

        public static void EndHorizontal()
        {
            EditorGUILayout.EndHorizontal();
        }

        public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options)
        {
            return EditorGUILayout.BeginScrollView(scrollPosition, options);
        }

        public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
        {
            return EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, options);
        }

        public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options)
        {
            return EditorGUILayout.BeginScrollView(scrollPosition, style, options);
        }

        public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
        {
            return EditorGUILayout.BeginScrollView(scrollPosition, horizontalScrollbar, verticalScrollbar, options);
        }

        public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
        {
            return EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, options);
        }

        public static void EndScrollView()
        {
            EditorGUILayout.EndScrollView();
        }

        public static bool BeginFadeGroup(float value)
        {
            return EditorGUILayout.BeginFadeGroup(value);
        }

        public static void EndFadeGroup()
        {
            EditorGUILayout.EndFadeGroup();
        }

        public static BuildTargetGroup BeginBuildTargetSelectionGrouping()
        {
            return EditorGUILayout.BeginBuildTargetSelectionGrouping();
        }

        public static void EndBuildTargetSelectionGrouping()
        {
            EditorGUILayout.EndBuildTargetSelectionGrouping();
        }

        public static void BeginLayoutIndent(int indentLevel)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Space(LucidEditorUtility.singleIndentWidth * indentLevel);

            LucidEditorUtility.PushIndentLevel(0);
            GUILayout.BeginVertical();
        }

        public static void EndLayoutIndent()
        {
            GUILayout.EndVertical();
            LucidEditorUtility.PopIndentLevel();
            GUILayout.EndHorizontal();
        }

        public static void BeginBoxGroup(string content, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            Rect headerRect = EditorGUILayout.GetControlRect(false, 20f, options);
            headerRect.yMin -= 4f;
            headerRect.xMin -= 4f;
            headerRect.xMax += 4f;
            EditorGUI.LabelField(headerRect, GUIContent.none, GUI.skin.button);
            headerRect.xMin += 4f;
            EditorGUI.LabelField(headerRect, content);
        }

        public static void EndBoxGroup()
        {
            EditorGUILayout.EndVertical();
        }

        public static bool BeginFoldoutGroup(bool foldout, string content, params GUILayoutOption[] options)
        {
            bool expanded = foldout;
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            Rect position = EditorGUILayout.GetControlRect(options);

            Rect headerRect = position;
            headerRect.yMin -= 3f;
            headerRect.yMax += 3f;
            headerRect.xMin -= 4f;
            headerRect.xMax += 4f;
            EditorGUI.LabelField(headerRect, GUIContent.none, GUI.skin.button);

            position.x += 15f;
            position.y -= 1f;
            expanded = LucidEditorGUI.FoldoutToggle(position, foldout);
            position.x += 2f;
            position.y += 1f;
            LucidEditorGUI.Header(position, content);
            LucidGUIEvent.MouseDownEvent(position, () => expanded = !expanded);

            if (expanded) EditorGUILayout.Space(2);

            return expanded;
        }

        public static void EndFoldoutGroup()
        {
            EditorGUILayout.EndVertical();
        }

        public static int BeginTabGroup(int selected, string[] items, params GUILayoutOption[] options)
        {
            return BeginTabGroup(selected, EditorStyles.helpBox, items);
        }

        public static int BeginTabGroup(int selected, GUIStyle style, string[] items, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginVertical(style);
            Rect position = EditorGUILayout.GetControlRect(false, EditorGUIUtility.singleLineHeight + 2f, options.Append(GUILayout.MinWidth(0f)).ToArray());
            position.xMin -= 4.2f;
            position.xMax += 4.2f;
            position.y -= 4.2f;
            int value = LucidEditorGUI.Toolbar(position, selected, items);
            return value;
        }

        public static void EndTabGroup()
        {
            EditorGUILayout.EndVertical();
        }

        public static bool BeginToggleGroup(string label, bool toggle, params GUILayoutOption[] options)
        {
            return BeginToggleGroup(label, toggle, EditorStyles.helpBox, options);
        }

        public static bool BeginToggleGroup(GUIContent label, bool toggle, params GUILayoutOption[] options)
        {
            return BeginToggleGroup(label, toggle, EditorStyles.helpBox, options);
        }

        public static bool BeginToggleGroup(string label, bool toggle, GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginVertical(style, options);
            bool enabled = ToggleLeft(label, toggle);
            EditorGUI.BeginDisabledGroup(!enabled);
            return enabled;
        }

        public static bool BeginToggleGroup(GUIContent label, bool toggle, GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginVertical(style, options);
            bool enabled = ToggleLeft(label, toggle);
            EditorGUI.BeginDisabledGroup(!enabled);
            return enabled;
        }

        public static void EndToggleGroup()
        {
            EditorGUI.EndDisabledGroup();
            EditorGUILayout.EndVertical();
        }

        public static bool BeginToggleFoldoutGroup(GUIContent label, bool foldout, ref bool toggle, params GUILayoutOption[] options)
        {
            return BeginToggleFoldoutGroup(label, foldout, ref toggle, options);
        }

        public static bool BeginToggleFoldoutGroup(string label, bool foldout, ref bool toggle, params GUILayoutOption[] options)
        {
            return BeginToggleFoldoutGroup(label, foldout, ref toggle, EditorStyles.helpBox, options);
        }

        public static bool BeginToggleFoldoutGroup(GUIContent label, bool foldout, ref bool toggle, GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginVertical(style, options);
            Rect position = EditorGUILayout.GetControlRect();
            foldout = ToggleFoldoutGroupHeader(position, foldout);
            position.x += 17f;
            toggle = LucidEditorGUI.ToggleLeft(position, label, toggle);
            EditorGUI.BeginDisabledGroup(!toggle);
            return foldout;
        }

        public static bool BeginToggleFoldoutGroup(string label, bool foldout, ref bool toggle, GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginVertical(style, options);
            Rect position = EditorGUILayout.GetControlRect();
            foldout = ToggleFoldoutGroupHeader(position, foldout);
            position.x += 17f;
            toggle = LucidEditorGUI.ToggleLeft(position, label, toggle);
            EditorGUI.BeginDisabledGroup(!toggle);
            return foldout;
        }

        public static void EndToggleFoldoutGroup()
        {
            EditorGUI.EndDisabledGroup();
            EditorGUILayout.EndVertical();
        }

        private static bool ToggleFoldoutGroupHeader(Rect position, bool foldout)
        {
            position.xMin += 15f;
            foldout = LucidEditorGUI.FoldoutToggle(position, foldout);
            position.xMin += 17f;
            LucidGUIEvent.MouseDownEvent(position, () => foldout = !foldout);
            return foldout;
        }

        public class BoxGroupScope : GUI.Scope
        {
            public BoxGroupScope(string content)
            {
                BeginBoxGroup(content);
            }

            protected override void CloseScope()
            {
                EndBoxGroup();
            }
        }

        public class FoldoutGroupScope : GUI.Scope
        {
            public bool expanded { get; private set; }

            public FoldoutGroupScope(bool foldout, string content)
            {
                expanded = BeginFoldoutGroup(foldout, content);
            }

            protected override void CloseScope()
            {
                EndFoldoutGroup();
            }
        }

        public class TabGroupScope : GUI.Scope
        {
            public int selected { get; private set; }

            public TabGroupScope(int selected, params string[] items)
            {
                this.selected = BeginTabGroup(selected, items);
            }

            public TabGroupScope(int selected, GUIStyle style, params string[] items)
            {
                this.selected = BeginTabGroup(selected, style, items);
            }

            protected override void CloseScope()
            {
                EndTabGroup();
            }
        }

        public class ToggleFoldoutGroupScope : GUI.Scope
        {
            public bool expanded { get; private set; }
            public bool enabled { get; private set; }

            public ToggleFoldoutGroupScope(string label, bool foldout, bool toggle, GUIStyle style)
            {
                expanded = BeginToggleFoldoutGroup(label, foldout, ref toggle, style);
                enabled = toggle;
            }

            public ToggleFoldoutGroupScope(GUIContent label, bool foldout, bool toggle, GUIStyle style)
            {
                expanded = BeginToggleFoldoutGroup(label, foldout, ref toggle, style);
                enabled = toggle;
            }

            public ToggleFoldoutGroupScope(string label, bool foldout, bool toggle)
            {
                expanded = BeginToggleFoldoutGroup(label, foldout, ref toggle);
                enabled = toggle;
            }

            public ToggleFoldoutGroupScope(GUIContent label, bool foldout, bool toggle)
            {
                expanded = BeginToggleFoldoutGroup(label, foldout, ref toggle);
                enabled = toggle;
            }

            protected override void CloseScope()
            {
                EndToggleFoldoutGroup();
            }
        }

        public class ToggleGroupScope : GUI.Scope
        {
            public bool enabled { get; private set; }

            public ToggleGroupScope(string label, bool toggle, GUIStyle style)
            {
                BeginToggleGroup(label, toggle, style);
            }

            public ToggleGroupScope(GUIContent label, bool toggle, GUIStyle style)
            {
                BeginToggleGroup(label, toggle, style);
            }

            public ToggleGroupScope(string label, bool toggle)
            {
                BeginToggleGroup(label, toggle);
            }

            public ToggleGroupScope(GUIContent label, bool toggle)
            {
                BeginToggleGroup(label, toggle);
            }

            protected override void CloseScope()
            {
                EndToggleGroup();
            }
        }
    }
}
