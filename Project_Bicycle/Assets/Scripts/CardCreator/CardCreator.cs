using UnityEditor;
using UnityEngine;

public class CardCreator : EditorWindow {

    string aString = "Hello World!";
    bool toggled;
    bool myBoolean = true;
    float aFloat = 1.23f;
    GUILayoutOption[] noOptions = new GUILayoutOption[0];

    [MenuItem("Window/Card Creator")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(CardCreator));
    }

    private void OnGUI()
    {
        GUILayout.Label("Base Label", EditorStyles.boldLabel);
        aString = EditorGUILayout.TextField("Text Field", aString);

        toggled = EditorGUILayout.BeginToggleGroup("Optional Settings", toggled);
        myBoolean = EditorGUILayout.Toggle("Toggle", myBoolean);
        aFloat = EditorGUILayout.Slider("Slidey Boi", aFloat, -3, 3, noOptions);
        EditorGUILayout.EndToggleGroup();
    }

}
