using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using PlayerItem;

public class ItemDB : MonoBehaviour
{

    public List<PlayerItem.Item> itemDatabase = new List<PlayerItem.Item>();
    public List<Item> itemDatabase2 = new List<Item>();

    public void AddItem(int itemID, Player_Lists player)
    {
        foreach(var item in itemDatabase)
        {
            if(item.id == itemID)
            {
                Debug.Log("we have a match");
                player.inventory[0] = item;
                return;
            }
        }
        Debug.Log("Item dose not exist");
    }
    public void RemoveItem(int itemID, Player_Lists player)
    {
        foreach(var item in itemDatabase)
        {
            if(item.id == itemID)
            {
                player.inventory[0] = null;
            }
        }
    }
}
