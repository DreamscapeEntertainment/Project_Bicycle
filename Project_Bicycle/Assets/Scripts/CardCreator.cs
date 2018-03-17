using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class ACardCreator : EditorWindow {

    public ACard card;

    enum cardType { Spell, Invoke, Echo, Power };
    int typeIndex;

    bool cardChosen;

    bool isSpell;
    bool isInvoke;
    bool isEcho;
    bool isPower;

    string refName;
    string cardName;
    string description;

    Sprite cardArt;
    bool manaIsX;

    int manaCost;

    int range;
    int targetArea;


    [MenuItem("Window/ACard Creator")]
    public static void ShowWindow() {

        GetWindow<ACardCreator>("ACard Creator");
    }

    private void OnEnable() {

        cardChosen = false;

        manaCost = 5;
        manaIsX = false;
        cardName = "Example Name";
        refName = "exampleRefID";
        description = "Example Description";

        isSpell = false;
        isInvoke = false;
        isEcho = false;
        isPower = false;

    }

    private void OnGUI() {

        GUI.skin.textField.wordWrap = true;


        cardName = EditorGUILayout.TextField("Card Name", cardName, GUILayout.Height(30));
        refName = EditorGUILayout.TextField("Reference ID", refName, GUILayout.Height(15));
        manaCost = EditorGUILayout.IntSlider("Mana", manaCost, 0, 10);
        manaIsX = EditorGUILayout.Toggle("X Mana Cost?", manaIsX);

        description = EditorGUILayout.TextField("Description", description, GUILayout.Height(100));



        if (card == null) {

            GUILayout.BeginHorizontal(GUILayout.ExpandWidth(false));
                isSpell = GUILayout.Toggle(isSpell, "Spell", "Button");
                isInvoke = GUILayout.Toggle(isInvoke, "Invoke", "Button");
                isEcho = GUILayout.Toggle(isEcho, "Echo", "Button");
                isPower = GUILayout.Toggle(isPower, "Power", "Button");
            GUILayout.EndHorizontal();


            if (GUILayout.Button("Create Card")) {
                CreateCard();  
            }
     

        }

        if (card != null) {

        }

        /**
         * create "create card button"
         *      helper function, doesnt let you create a card with multiple, except for invoke and echo
         * hide the above buttons after
         * 
         * 
         */

        /**
         * save button
         * delete button - warning before?
         *      sort into the correct class and type list, sort alphabetically?
         * cardArt
         * 
         * 
         */

    }

    void CreateCard() {
        /*
         * get a name form user pass it in as indexName
         * indexName = createinstance(Card);
         * if(indexName)
         * if name is new 
         * save in a temp asset list
         * else ask if you want to overwrite
         */
        //Debug.Log(card.cardName);

        //check if refname is in templist
        if (true) {
            string message = "There is already a Card with the Reference ID: " + refName + ". Do you want to overwrite this Card?";
            if(EditorUtility.DisplayDialog("Overwrite Conflict", message, "Overwrite", "Cancel")) {
                //save to temp list
            }
        }

        card = ScriptableObject.CreateInstance<ACard>();
        card.refName = refName;

    }

}
