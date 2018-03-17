using UnityEditor;
using UnityEngine;

public class CardCreator : EditorWindow {

    Card c;
    GUILayoutOption[] noOptions = new GUILayoutOption[0];

    [MenuItem("Dreamscape/Cards/Card Creator")]
    public static void Init() {
        CardCreator window = EditorWindow.GetWindow<CardCreator>("Card Creator");
        window.minSize = new Vector2(600, 400);
        window.Show();
    }

    private void OnEnable() {
        if(c == null)
            c = Card.CreateInstance<Card>();
    }

    private void OnGUI() {
        EditorGUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));

        DisplayCreator();

        EditorGUILayout.EndHorizontal();
    }

    void DisplayCreator() {

        EditorGUILayout.BeginVertical(GUILayout.ExpandHeight(true));

        EditorGUILayout.LabelField("Card Data", EditorStyles.boldLabel);
        c.cardName = EditorGUILayout.TextField("Card Name", c.cardName, GUILayout.MaxWidth(400));
        c.cardClass = (CardClass)EditorGUILayout.EnumPopup("Card Class", c.cardClass, GUILayout.MaxWidth(400));
        c.type = (CardType)EditorGUILayout.EnumPopup("Card Type", c.type, GUILayout.MaxWidth(400));
        c.description = EditorGUILayout.TextField("Card Description", c.description, GUILayout.MaxWidth(400), GUILayout.MaxHeight(60));

        c.isInvoke = EditorGUILayout.Toggle("Invoke?", c.isInvoke);
        c.isEcho = EditorGUILayout.Toggle("Echo?", c.isEcho);
        EditorGUILayout.Space();

        EditorGUILayout.EndVertical();

    }

}
