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
        Item_D bread = new Item_D("bread", 1);

        itemList.Add(sword);
        itemList.Add(bread);
        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, bread);

        var dictionaryItem0 = itemDictionary[0];
        // Debug.Log(dictionaryItem0.name);
        // Debug.Log(dictionaryItem0.id);

        for(int i = 0; i < itemList.Count; i++)
        {
            // Debug.Log(itemList[i].id);
            // Debug.Log(itemList[i].name);
        }

        for(int i = 0; i < itemDictionary.Count; i++)
        {
            // Debug.Log(itemDictionary[i].id);
            // Debug.Log(itemDictionary[i].name);
        }


        /* How to access using foreach */

        // foreach(var item in itemDictionary)
        foreach(KeyValuePair<int, Item_D> item in itemDictionary)
        {
            // Debug.Log(item.Key);
            // Debug.Log(item.Value.id);
            // Debug.Log(item.Value.name);
        }

        foreach(int key in itemDictionary.Keys)
        {
            // Debug.Log(key);
        }
        foreach(Item_D item in itemDictionary.Values)
        {
            // Debug.Log("item name : " + item.name);
        }

        /* How to use ths ContainKey Method */
        if(itemDictionary.ContainsKey(60))
        {
            Debug.Log("You found the Key !!");
            var randomItem = itemDictionary[60].name;
        }
        else
        {
            Debug.Log("Key dose not exist !!");
        }
    }
}
