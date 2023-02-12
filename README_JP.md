# Lucid Editor
Powerful Editor Extensions for Unity

<img src="https://github.com/AnnulusGames/LucidEditor/blob/main/Assets/LucidEditor/Documentation~/Header.png" width="800">

[![license](https://img.shields.io/badge/LICENSE-MIT-green.svg)](LICENSE)

[English README](README.md)

## 概要
Lucid EditorはUnityのInspectorをカスタマイズし、属性を用いた強力なエディタ拡張を可能にします。Inspectorの扱いやすさを向上させる30以上の属性が利用可能になるほか、エディタ拡張を簡単に行うための機能も多数追加されます。

### 特徴
* Inspectorをカスタマイズする30以上の属性
* SerializeReferenceでインターフェース・抽象クラスを編集可能に
* PropertyProcessorを用いて独自の属性を追加可能
* EditorGUIを拡張したLucidEditorGUI
* GUI上での入力を処理するLucidGUIEvent
* エディタ上の設定を保存するLucidEditorPrefs
* エディタのアイコンをプロパティとして取得可能なEditorIconsクラス
* エディタの色をプロパティとして取得可能なEditorColorsクラス
* SerializedPropertyの機能を向上させる拡張メソッド

## セットアップ

### 要件
* Unity 2020.1 以上

### インストール
1. Window > Package ManagerからPackage Managerを開く
2. 「+」ボタン > Add package from git URL
3. 以下を入力する
   * https://github.com/AnnulusGames/LucidEditor.git?path=/Assets/LucidEditor


あるいはPackages/manifest.jsonを開き、dependenciesブロックに以下を追記

```json
{
    "dependencies": {
        "com.annulusgames.lucid-editor": "https://github.com/AnnulusGames/LucidEditor.git?path=/Assets/LucidEditor"
    }
}
```

### Namespace
Inspector用の属性を利用する場合は、ファイルの冒頭に以下の一行を追加します。

```cs
using AnnulusGames.LucidTools.Inspector;
```

LucidEditorGUIなど、エディタ上でのみ動作する機能を利用する際には以下の一行を追加します。

```cs
using AnnulusGames.LucidTools.Editor;
```


## 属性の追加
Inspectorでの表示をカスタマイズしたい場合には、クラスが持つフィールドに属性を付加します。

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

例えばBoxGroup属性を付加することで、下のようにフィールドをグループ化して表示できます。

<img src="https://github.com/AnnulusGames/LucidEditor/blob/main/Assets/LucidEditor/Documentation~/img1.png" width="600">

メソッドにButton属性を付加することで、ボタンを表示することも可能です。

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

他にも、値を編集できないようにするReadOnly属性や、不正な値の入力を監視するValidateInput属性など、様々な属性が利用可能です。

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

また、特定のクラスでLucid Editorを無効化したい場合にはDisableLucidEditor属性を追加します。

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

利用可能な属性の一覧は、こちらから確認できます。

[Attributes](https://github.com/AnnulusGames/LucidEditor/wiki/Attributes)

## インターフェース・抽象クラスを表示する
Lucid Editorが有効な場合、SerializeReference属性を付加することでインターフェースや抽象クラスをInspector上で編集できるようになります。

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

インターフェース・抽象クラスは上のように表示され、ドロップダウンから子クラスを選択して生成することができます。

## LucidEditorを拡張する
対象のMonoBehaviourやScriptableObjectが独自のEditorクラスを持つ場合、Lucid Editorの属性は動作しません。
独自のエディタ拡張とLucid Editorを組み合わせたい場合には、UnityEngine.EditorクラスではなくLucidEditorクラスを継承する必要があります。

```cs
using UnityEditor;
using AnnulusGames.LucidTools.Editor;

[CustomEditor(typeof(Example))]
public class EditorExample : LucidEditor
{
    public override void OnInspectorGUI()
    {
        // 必ず継承元のOnInspectorGUIを呼び出すこと
        base.OnInspectorGUI();

        // ここに独自の処理を記述する
    }
}
```

## LucidEditorGUI & LucidEditorGUILayout
Lucid Editorには、エディタ上のGUIを描画するためのクラスであるLucidEditorGUIとLucidEditorGUILayoutが用意されています。これらは基本的にLucidEditor内部での描画に利用されていますが、独自のエディタ拡張用に利用することも可能です。

LucidEditorGUI・LucidEditorGUILayoutは、EditorGUI・EditorGUILayoutのラッパークラスとして実装されており、同じように使用することができます。

```cs
void OnGUI()
{
    LucidEditorGUILayout.BeginBoxGroup("Box");
    LucidEditorGUILayout.TitleHeader("Title");
    LucidEditorGUILayout.PropertyField(property);
    LucidEditorGUILayout.EndBoxGroup();
}
```

また、LucidEditorGUILayoutクラス内にはいくつかのGUI Scopeが定義されています。これらは主にグループ系の属性の描画に使われていますが、通常のエディタ拡張でも利用可能です。

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
    // Tab Groupを表示する
    using (var scope = new LucidEditorGUILayout.TabGroupScope(selectedTab, tabItems))
    {
        selectedTab = scope.selected;
    }
}
```

## LucidGUIEvent
LucidGUIEventクラスを用いることで、GUI上でのイベントを簡単に処理することができます。

マウスクリックを処理する場合には、GetMouseButtonDown / GetMouseButtonUpを利用します。

```cs
// 右クリックされた時
if (LucidGUIEvent.GetMouseButtonDown(1))
{
    Debug.Log("right click");
}

// 引数:useにtrueを指定することで、イベントを使用済みに設定する
if (LucidGUIEvent.GetMouseButtonUp(0, true))
{
    Debug.Log("left click");
}

// 指定のRect内でのみ入力を取得する
if (LucidGUIEvent.GetMouseButtonDown(1, rect, true))
{
    Debug.Log("right click");
}

// ダブルクリックを取得
if (LucidGUIEvent.GetMouseButtonMultiClick(0, 2))
{
    Debug.Log("double click");
}
```

キーの入力を処理する場合には、GetKeyDown / GetKeyUpを利用します。

```cs
// スペースキーが押された時
if (LucidGUIEvent.GetKeyDown(KeyCode.Space))
{
    Debug.Log("space key was pressed");
}

// 引数:useにtrueを指定することで、イベントを使用済みに設定する
if (LucidGUIEvent.GetKeyUp(KeyCode.A, true))
{
    Debug.Log("a key was released");
}
```

## LucidEditorPrefs
エディタ上で値を保存する際には、LucidEditorPrefsを利用することができます。

プロジェクトをまたいでデータを保存したい場合は、Get/Setを利用します。

```cs
// 値を取得
int foo = LucidEditorPrefs.Get<int>("foo");

// 値を設定
LucidEditorPrefs.Set<int>("foo", 10);
```

プロジェクト内でのデータを保存する際にはGet/SetConfigValueを利用します。

```cs
// 値を取得
int foo = LucidEditorPrefs.GetConfigValue<int>("foo");

// 値を設定
LucidEditorPrefs.SetConfigValue<int>("foo", 10);
```

値の管理と保存を自動で行うGlobalPersistentData、LocalPersistentDataも用意されています。

```cs
// 引数でキーを指定する
GlobalPersistentData<string> foo = LucidEditorPrefs.CreateGlobalPersistentData<string>("foo");

// 値が変更されるたびに自動でLucidEditorPrefs.Setを呼び出す
foo.Value = 20;

// 引数でキーを指定する
LocalPersistentData<int> bar = LucidEditorPrefs.CreateLocalPersistentData<int>("bar");

// 値が変更されるたびに自動でLucidEditorPrefs.SetConfigValueを呼び出す
bar.Value = 20;
```

LucidEditorPrefsは、int、long、float、double、bool、stringのほか、EditorJsonUtilityがサポートしている型であれば保存が可能です。

## EditorIcons
EditorIconsクラスを利用することで、エディタ上で使われているアイコンをプロパティとして取得できます。

```cs
//Helpアイコンを取得
GUIContent icon = EditorIcons.Help;

//コンポーネントのアイコンを取得することも可能
GUIContent icon = EditorIcons.GetComponentIcon<Rigidbody>();
```

また、UnityEditorIconsは独立したライブラリとしても公開されています。

[UnityEditorIcons](https://github.com/AnnulusGames/UnityEditorIcons)

## EditorColors
EditorColorsクラスを利用することで、エディタ上の色を取得できます。

```cs
// エディタの背景色でRectを描画
LucidEditorGUI.DrawRect(rect, EditorColors.background);

// エディタの線の色でラインを描画
LucidEditorGUI.Line(rect, EditorColors.line);
```

EditorColorsによって取得できる色はエディタのスキンによって変わるため、現在どのスキンであるかを気にせず利用することができます。
ただし、これらの色はライブラリ作成時のエディタのバージョンのものであり、バージョンによっては配色が異なる可能性があることに注意してください。

## SerializedPropertyの拡張メソッド
Lucid Editorでは、SerializedProperty向けにいくつかの拡張メソッドが用意されています。これらを利用することで、SerializedPropertyから値や付加されている属性などを取得することができます。

#### GetHeight
SerializedPropertyの高さを取得します。

```cs
public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
{
    // SerializedPropertyの高さを取得
    property.GetHeight();

    // 返す値は上のコードと同じ
    EditorGUI.GetPropertyHeight(property);
}
```

#### GetAttribute / TryGetAttribute
SerializedPropertyが持つ属性を取得します。

```cs
public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
{
    // SerializedPropertyが持つLabelAttributeを取得
    LabelAttribute attribute = property.GetAttribute<LabelAttribute>();
}
```

#### GetAttributes
SerializedPropertyが持つ属性を全て取得します。

#### GetValue / SetValue
SerializedPropertyの持つ値を型を指定して取得・変更します。ユーザー定義のクラスを指定することも可能です。

```cs
using UnityEngine;

// 対象のMonoBehaviour
public class Example : MonoBehaviour
{
    [SerializeField] private User user;
}

// ユーザー定義のクラス
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

// エディタ拡張を行うEditorクラス
[CustomEditor(typeof(Example))]
public class ExampleEditor : LucidEditor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        SerializedProperty userProperty = serializedObject.FindProperty("user");

        // User型を扱うSerializedPropertyから元の値を再現
        User user = userProperty.GetValue<User>();
        Debug.Log(user.name);

        if (GUILayout.Button("Set Random ID"))
        {
            user.id = Random.Range(0, 10);

            // SerializedPropertyにUser型の値を設定
            userProperty.SetValue<User>(user);
        }
    }
}
```

#### GetFieldInfo
SerializedPropertyからFieldInfoを取得します。

```cs
FieldInfo fieldInfo = serializedProperty.GetFieldInfo();
```

#### GetPropertyType
SerializedPropertyの値のTypeを取得します。

```cs
Type type = serializedProperty.GetPropertyType();

// 値が配列の時、引数がtrueの場合は配列の型を取得
Type arrayType = serializedProperty.GetPropertyType(true);
// 引数がfalseの場合は要素の型を取得
Type elementType = serializedProperty.GetPropertyType(false);
```

## Experimental
AnnulusGames.LucidTools.Editor.Experimental以下には、現在開発中のクラスが置かれています。

これらの機能を使用することは可能ですが、予告なく大幅な変更やnamespaceの移動が行われる可能性があるため、正式に公開されるまで使用しないことをお勧めします。

## ライセンス

[MIT License](LICENSE)
