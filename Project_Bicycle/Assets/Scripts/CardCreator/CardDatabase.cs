using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardDatabase : ScriptableObject {
    [SerializeField]
    private List<Card> database;

    void OnEnable() {
        if (database == null)
            database = new List<Card>();
    }

    public void Add(Card card) {
        database.Add(card);
    }

    public void Remove(Card card) {
        database.Remove(card);
    }

    public void RemoveAt(int index) {
        database.RemoveAt(index);
    }

    public int COUNT {
        get { return database.Count; }
    }

    //.ElementAt() requires the System.Linq
    public Card Card(int index) {
        return database.ElementAt(index);
    }

    public void SortAlphabeticallyAtoZ() {
        database.Sort((x, y) => string.Compare(x.cardName, y.cardName));
    }

    public void SetAtIndex(int id, Card c) {
        database[id] = c;
    }
}
