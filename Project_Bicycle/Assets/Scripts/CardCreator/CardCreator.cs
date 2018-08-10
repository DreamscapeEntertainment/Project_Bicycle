// using UnityEditor;
// using UnityEngine;

// public class CardCreator : EditorWindow {

//     enum STATE {
//         BLANK = 0,
//         ADD,
//         EDIT
//     }

//     Card newCard;
//     CardDatabase cards;
//     Vector2 _scrollPos;

//     int selectedCard;

//     STATE currentState;

//     GUILayoutOption[] noOptions = new GUILayoutOption[0];

//     private const string DATABASE_PATH = @"Assets/Cards/cardDB.asset";

//     [MenuItem("Dreamscape/Cards/Card Creator")]
//     public static void Init() {
//         CardCreator window = EditorWindow.GetWindow<CardCreator>("Card Creator");
//         window.minSize = new Vector2(600, 400);
//         window.Show();
//     }

//     private void OnEnable() {
//         if(cards == null)
//             LoadDatabase();

//         currentState = STATE.BLANK;
//     }

//     private void OnGUI() {
//         EditorGUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));

//         DisplayDatabase();
//         DisplayMain();

//         EditorGUILayout.EndHorizontal();
//     }

//     void LoadDatabase() {
//         cards = (CardDatabase)AssetDatabase.LoadAssetAtPath(DATABASE_PATH, typeof(CardDatabase));

//         if (cards == null)
//             CreateDatabase();
//     }

//     void CreateDatabase() {
//         cards = ScriptableObject.CreateInstance<CardDatabase>();
//         AssetDatabase.CreateAsset(cards, DATABASE_PATH);
//         AssetDatabase.SaveAssets();
//         AssetDatabase.Refresh();
//     }

//     void DisplayMain() {

//         EditorGUILayout.BeginVertical(GUILayout.ExpandWidth(true));
//         EditorGUILayout.Space();

//         switch (currentState) {
//             case STATE.ADD:
//                 DisplayNewMode();
//                 break;
//             case STATE.EDIT:
//                 DisplayEditMode();
//                 break;
//             default:
//                 DisplayBlankArea();
//                 break;
//         }

//         EditorGUILayout.Space();
//         EditorGUILayout.EndVertical();

//     }

//     void DisplayDatabase() {
//         EditorGUILayout.BeginVertical(GUILayout.MaxWidth(250));
//         EditorGUILayout.Space();

//         _scrollPos = EditorGUILayout.BeginScrollView(_scrollPos, "box", GUILayout.ExpandHeight(true));
        
//         for(int cnt = 0; cnt < cards.COUNT; cnt++) {
//             EditorGUILayout.BeginHorizontal();
//             if(GUILayout.Button("-", GUILayout.Width(25))) {
//                 cards.RemoveAt(cnt);
//                 cards.SortAlphabeticallyAtoZ();
//                 EditorUtility.SetDirty(cards);

//                 currentState = STATE.BLANK;
//                 return;
//             }

//             if (GUILayout.Button(cards.Card(cnt).cardName, "box", GUILayout.ExpandWidth(true))){
//                 selectedCard = cnt;

//                 currentState = STATE.EDIT;
//             }
//             EditorGUILayout.EndHorizontal();
//         }

//         EditorGUILayout.EndScrollView();

//         EditorGUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));
//         EditorGUILayout.LabelField("Cards: " + cards.COUNT, GUILayout.Width(100));

//         if (GUILayout.Button("New Card")) {
//             newCard = ScriptableObject.CreateInstance<Card>();
//             currentState = STATE.ADD;
//         }

//         EditorGUILayout.EndHorizontal();
//         EditorGUILayout.Space();
//         EditorGUILayout.EndVertical();
//     }

//     public void DisplayBlankArea() {

//         GUI.skin.label.wordWrap = true;

//         EditorGUILayout.LabelField(
//           "Select a card in the database to the right \n" +
//           "or create a new one!",
//           GUILayout.ExpandHeight(true));
//     }

//     public void DisplayEditMode() {

//         cards.SetAtIndex(selectedCard, DisplayCardCreator(cards.Card(selectedCard)));

//         if (GUILayout.Button("Done", GUILayout.Width(100))) {
//             cards.SortAlphabeticallyAtoZ();
//             EditorUtility.SetDirty(cards);
//             currentState = STATE.BLANK;
//         }
//     }

//     public void DisplayNewMode() {
//         newCard = DisplayCardCreator(newCard);

//         if(GUILayout.Button("Done", GUILayout.Width(100))) {
//             cards.Add(newCard);
//             cards.SortAlphabeticallyAtoZ();

//             EditorUtility.SetDirty(cards);
//             currentState = STATE.BLANK;
//         }
//     }

//     public Card DisplayCardCreator(Card card) {
//         Card c = card;

//         EditorGUILayout.LabelField("Card Data", EditorStyles.boldLabel);
//         c.cardName = EditorGUILayout.TextField("Card Name", c.cardName, GUILayout.MaxWidth(400));
//         c.cardClass = (CardClass)EditorGUILayout.EnumPopup("Card Class", c.cardClass, GUILayout.MaxWidth(400));
//         c.type = (CardType)EditorGUILayout.EnumPopup("Card Type", c.type, GUILayout.MaxWidth(400));
//         c.description = EditorGUILayout.TextField("Card Description", c.description, GUILayout.MaxWidth(400), GUILayout.MaxHeight(60));

//         c.isInvoke = EditorGUILayout.Toggle("Invoke?", c.isInvoke);
//         c.isEcho = EditorGUILayout.Toggle("Echo?", c.isEcho);

//         return c;
//     }

// }
