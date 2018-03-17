using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACard : ScriptableObject {

    //card type array
    //spell, power,invoke,echo, echo/invoke
    //istargeted boolean
    public int cardType;
    public int cardHero;

    public string cardName;
    public string refName;
    public string description;

    public Sprite artwork;
    public bool manaIsX;

    public int manaCost;
    public int range;
    public int targetArea;

    //public target type
    //enum targetType {single, line, cone, circle};
    public int targetType;

    //each element in the array has instructions for each effect in array form
    public int[][] effects;
    //restriction for echo
    public int[] restrictions;

}
