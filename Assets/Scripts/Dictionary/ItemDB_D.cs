using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB_D : MonoBehaviour
{
    public List<Item_D> itemList = new List<Item_D>();
    public Dictionary<int, Item_D> itemDictionary = new Dictionary<int, Item_D>();

    private void Start()
    {
        Item_D sword = new Item_D("sword", 0);

        // itemList.Add(sword);
        itemDictionary.Add(0, sword);

        var dictionaryItem0 = itemDictionary[0];
        Debug.Log(dictionaryItem0.name);
        Debug.Log(dictionaryItem0.id);
    }
}
