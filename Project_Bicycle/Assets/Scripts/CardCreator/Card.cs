﻿/**
 * File: Card.cs
 * 
 * Author: Erik Cerini
 * 
 * A File representation of a card object.
 * 
 * Version History:
 *      1.0: 
 * 
**/ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "Game Objects", order = 0)]
public class Card : ScriptableObject {

    public string cardName;
    public string[] randomFields;

}
