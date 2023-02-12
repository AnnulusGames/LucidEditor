# Lucid Editor
Powerful Editor Extensions for Unity

<img src="https://github.com/AnnulusGames/LucidEditor/blob/main/Assets/LucidEditor/Documentation~/Header.png" width="800">

[![license](https://img.shields.io/badge/LICENSE-MIT-green.svg)](LICENSE)

[日本語版READMEはこちら](README_JP.md)

## Overview
The Lucid Editor customizes Unity's Inspector and enables powerful editor extensions using attributes. Over 30 attributes will be available to make the Inspector easier to use, and many more features will be added to make it easier to extend the editor.

### Features
* Over 30 attributes to customize your inspector
* Interface/abstract class can be edited with SerializeReference
* Add custom attributes using PropertyProcessor
* LucidEditorGUI, an extension of EditorGUI
* LucidGUIEvent to handle input on the GUI
* LucidEditorPrefs to store editor preferences
* EditorIcons class that can get editor icons as properties
* EditorColors class that can get editor colors as properties
* Extension methods that improve the functionality of SerializedProperty

## Setup

### Requirement
* Unity 2020.1 or higher

### Install
1. Open the Package Manager from Window > Package Manager
2. "+" button > Add package from git URL
3. Enter the following to install
   * https://github.com/AnnulusGames/LucidEditor.git?path=/Assets/LucidEditor


or open Packages/manifest.json and add the following to the dependencies block.

```json
{
    "dependencies": {
        "com.annulusgames.lucid-editor": "https://github.com/AnnulusGames/LucidEditor.git?path=/Assets/LucidEditor"
    }
}
```

### Namespace
To use attributes for Inspector, add the following line at the beginning of the file.

```cs
using AnnulusGames.LucidTools.Inspector;
```

To use functions that operate only on the editor, such as LucidEditorGUI, add the following line at the beginning of the file.

```cs
using AnnulusGames.LucidTools.Editor;
```


## Add Attributes
To customize the display in the Inspector, add attributes to the fields.

```cs
using UnityEngine;
using AnnulusGames.LucidTools.Inspector;

public class AttributeExample : MonoBehaviour
{
     [BoxGroup("Group")] public int foo;
     [BoxGroup("Group")] public string bar;
     [BoxGroup("Group")] public float baz;
     [BoxGroup("Group")] public Vector3 qux;
}
```

For example, by adding the BoxGroup attribute, fields can be grouped and displayed as shown below.

<img src="https://github.com/AnnulusGames/LucidEditor/blob/main/Assets/LucidEditor/Documentation~/img1.png" width="600">

It is also possible to display a button by adding the Button attribute to the methods.

```cs
using UnityEngine;
using AnnulusGames.LucidTools.Inspector;

public class AttributeExample : MonoBehaviour
{
     [Button("Small")]
     private void ButtonSmall()
     {
         Debug.Log("Small!");
     }

     [Button("Medium", InspectorButtonSize.Medium)]
     private void ButtonMedium()
     {
         Debug.Log("Medium!");
     }

     [Button("Large", InspectorButtonSize.Large)]
     private void ButtonLarge()
     {
         Debug.Log("Large!");
     }

     [Button("Extra Large", InspectorButtonSize.ExtraLarge)]
     private void ButtonExtraLarge()
     {
         Debug.Log("Extra Large!");
     }
}
```

<img src="https://github.com/AnnulusGames/LucidEditor/blob/main/Assets/LucidEditor/Documentation~/img2.png" width="600">

Various other attributes are available, such as the ReadOnly attribute, which prevents editing of values, and the ValidateInput attribute, which monitors input of invalid values.

```cs
using UnityEngine;
using AnnulusGames.LucidTools.Inspector;

[HideMonoScript]
public class AttributeExample : MonoBehaviour
{
     [TabGroup("Group", "Tab A")] public int intA;
     [TabGroup("Group", "Tab A")] public string stringA;
     [TabGroup("Group", "Tab B")] public Vector3 vectorB;
     [TabGroup("Group", "Tab B")] public GameObject gameObjectB;

     [TitleHeader("Header")]
     [ReadOnly]
     public string message = "Read Only!";

     [ValidateInput("IsNotNull")]
     public GameObject obj;

     private bool IsNotNull(GameObject obj)
     {
         return obj != null;
     }
}
```

<img src="https://github.com/AnnulusGames/LucidEditor/blob/main/Assets/LucidEditor/Documentation~/img3.png" width="600">

Also, add the DisableLucidEditor attribute if you want to disable the Lucid Editor for a specific class.

```cs
using UnityEngine;
using AnnulusGames.LucidTools.Inspector;

[DisableLucidEditor]
public class AttributeExample : MonoBehaviour
{
     public int foo;
     public string bar;
}
```

A list of available attributes can be found here.

## Edit interfaces/abstract classes
You can edit interfaces and abstract classes on the Inspector by adding the SerializeReference attribute.

```cs
using System;
using UnityEngine;
using AnnulusGames.LucidTools.Inspector;

public class SerializeReferenceExample : MonoBehaviour
{
     [SerializeReference] public ITest iTest = new TestClassA();
}

public interface ITest
{
    
}

[Serializable]
public class TestClassA : ITest
{
     [HorizontalGroup("Horizontal")] public int a1;
     [HorizontalGroup("Horizontal")] public int a2;
     [HorizontalGroup("Horizontal")] public int a3;
}

[Serializable]
public class TestClassB : ITest
{
     [TabGroup("Tab", "Tab 1")] public string b1;
     [TabGroup("Tab", "Tab 2")] public string b2;
     [TabGroup("Tab", "Tab 3")] public string b3;
}

[Serializable]
public class TestClassC : ITest
{
     [FoldoutGroup("Foldout")] public Vector3 c1;
     [FoldoutGroup("Foldout")] public Vector3 c2;
     [FoldoutGroup("Foldout")] public Vector3 c3;
}
```

<img src="https://github.com/AnnulusGames/LucidEditor/blob/main/Assets/LucidEditor/Documentation~/img4.png" width="600">

The interface/abstract class is shown above, and you can select a child class from the dropdown.

## Extend LucidEditor
Lucid Editor attributes will not work if the target MonoBehaviour or ScriptableObject has its own Editor class.
To combine your own editor extension with the Lucid Editor, you should inherit LucidEditor instead of UnityEngine.Editor.

```cs
using UnityEditor;
using AnnulusGames.LucidTools.Editor;

[CustomEditor(typeof(Example))]
public class EditorExample : LucidEditor
{
    public override void OnInspectorGUI()
    {
        // remember to call base.OnInspectorGUI()
        base.OnInspectorGUI();

        ...
    }
}
```

## LucidEditorGUI & LucidEditorGUILayout
Lucid Editor provides classes LucidEditorGUI and LucidEditorGUILayout for drawing the GUI on the editor. These are basically used for drawing inside LucidEditor, but they can also be used for your own editor extension.

LucidEditorGUI and LucidEditorGUILayout are implemented as wrapper classes for EditorGUI and EditorGUILayout and can be used in the same way.

```cs
void OnGUI()
{
    LucidEditorGUILayout.BeginBoxGroup("Box");
    LucidEditorGUILayout.TitleHeader("Title");
    LucidEditorGUILayout.PropertyField(property);
    LucidEditorGUILayout.EndBoxGroup();
}
```

There are also several GUI Scopes defined within the LucidEditorGUILayout class. These are mainly used to draw group attributes, but they can also be used in custom editor.

```cs
private int selectedTab = 0;
private string[] tabItems = new string[]
{
    "Tab A",
    "Tab B",
    "Tab C"
};

public override void OnInspectorGUI()
{
    // show tab group
    using (var scope = new LucidEditorGUILayout.TabGroupScope(selectedTab, tabItems))
    {
        selectedTab = scope.selected;
    }
}
```

## LucidGUIEvent
By using the LucidGUIEvent, you can easily handle events on the GUI.

Use GetMouseButtonDown / GetMouseButtonUp to get mouse input.

```cs
// when right clicked
if (LucidGUIEvent.GetMouseButtonDown(1))
{
     Debug.Log("right click");
}

// set the event to used by specifying true for the argument: use
if (LucidGUIEvent.GetMouseButtonUp(0, true))
{
     Debug.Log("left click");
}

// get input only within the specified Rect
if (LucidGUIEvent.GetMouseButtonDown(1, rect, true))
{
     Debug.Log("right click");
}

// get double click
if (LucidGUIEvent.GetMouseButtonMultiClick(0, 2))
{
     Debug.Log("double click");
}
```

Use GetKeyDown / GetKeyUp to get key input.

```cs
// when space key is pressed
if (LucidGUIEvent.GetKeyDown(KeyCode.Space))
{
     Debug.Log("space key was pressed");
}

// set the event to used by specifying true for the argument: use
if (LucidGUIEvent.GetKeyUp(KeyCode.A, true))
{
     Debug.Log("a key was released");
}
```

## LucidEditorPrefs
You can use LucidEditorPrefs when saving values on the editor.

To save data across projects, use Get/Set.

```cs
// get value
int foo = LucidEditorPrefs.Get<int>("foo");

// set value
LucidEditorPrefs.Set<int>("foo", 10);
```

To save data in the project, use Get/SetConfigValue.

```cs
// get value
int foo = LucidEditorPrefs.GetConfigValue<int>("foo");

// set value
LucidEditorPrefs.SetConfigValue<int>("foo", 10);
```

GlobalPersistentData and LocalPersistentData that automatically manage and save values are also provided.

```cs
// specify the key as an argument
GlobalPersistentData<string> foo = LucidEditorPrefs.CreateGlobalPersistentData<string>("foo");

// automatically call LucidEditorPrefs.Set when the value changes
foo.Value = 20;

// specify the key as an argument
LocalPersistentData<int> bar = LucidEditorPrefs.CreateLocalPersistentData<int>("bar");

// automatically call LucidEditorPrefs.SetConfigValue when the value changes
bar.Value = 20;
```

LucidEditorPrefs can save int, long, float, double, bool, string, and any other type supported by EditorJsonUtility.

## Editor Icons
By using EditorIcons class, you can get built-in editor icons as properties.

```cs
// get help icon
GUIContent icon = EditorIcons.Help;

// it is also possible to get the icon of the component
GUIContent icon = EditorIcons.GetComponentIcon<Rigidbody>();
```

UnityEditorIcons is also released as an independent library.

[UnityEditorIcons](https://github.com/AnnulusGames/UnityEditorIcons)

## EditorColors
By using EditorColors, you can get the colors on the editor.

```cs
// draw a rect with the background color of the editor
LucidEditorGUI.DrawRect(rect, EditorColors.background);

// draw line with editor line color
LucidEditorGUI.Line(rect, EditorColors.line);
```

The colors that can be obtained by EditorColors change depending on the skin of the editor, so you can use it without worrying about which skin it is currently.
However, please note that these colors are for the version of the editor when the library was created, and the color scheme may differ depending on the version.


## Extension Methods for SerializedProperty
Lucid Editor provides some extension methods for SerializedProperty.

#### GetHeight
Gets the height of the SerializedProperty.

```cs
public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
{
    // get height of SerializedProperty
    property.GetHeight();

    // the return value is the same as the code above
    EditorGUI.GetPropertyHeight(property);
}
```

#### GetAttribute / TryGetAttribute
Gets the attributes that a SerializedProperty has.

```cs
public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
{
    // Get LabelAttribute of SerializedProperty
    LabelAttribute attribute = property.GetAttribute<LabelAttribute>();
}
```

#### Get Attributes
Gets all the attributes that SerializedProperty has.

#### GetValue / SetValue
Get/Set the value of SerializedProperty by specifying its type. It is also possible to specify a user-defined class.

```cs
using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] private User user;
}

[System.Serializable]
public class User
{
    public string name;
    public int id;
}
```

```cs
using UnityEngine;
using UnityEditor;
using AnnulusGames.LucidTools.Editor;

// Editor class for editor extension
[CustomEditor(typeof(Example))]
public class ExampleEditor : LucidEditor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        SerializedProperty userProperty = serializedObject.FindProperty("user");

        // eeproduce original value from SerializedProperty that handles User type
        User user = userProperty.GetValue<User>();
        Debug.Log(user.name);

        if (GUILayout.Button("Set Random ID"))
        {
            user.id = Random.Range(0, 10);

            // set User type value to SerializedProperty
            userProperty.SetValue<User>(user);
        }
    }
}
```

#### GetFieldInfo
Get fieldInfo from SerializedProperty.

```cs
FieldInfo fieldInfo = serializedProperty.GetFieldInfo();
```

#### GetPropertyType
Get the Type of the value of the SerializedProperty.

```cs
Type type = serializedProperty.GetPropertyType();

// Wwen the value is an array, get the array type if the argument is true
Type arrayType = serializedProperty.GetPropertyType(true);
// get the element type if the argument is false
Type elementType = serializedProperty.GetPropertyType(false);
```

## Experimental
AnnulusGames.LucidTools.Editor.Experimental contains classes currently in development.

Although it is possible to use these features, I recommend that you do not use them until they are officially released, as they may be subject to breaking changes or namespace moves without notice.

## License

[MIT License] (LICENSE)