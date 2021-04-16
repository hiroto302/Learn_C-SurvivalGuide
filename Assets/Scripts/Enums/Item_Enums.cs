using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item_Enums
{
    public string name;
    public int id;

    public enum ItemType
    {
        None,
        Weapon,
        Consumable
    }

    public ItemType itemType;

    public void Action()
    {
        switch(itemType)
        {
            case Item_Enums.ItemType.Weapon:
                Debug.Log("This is a Weapon");
                break;
            case ItemType.Consumable:
                Debug.Log("This is a Consumable");
                break;
        }
    }
}
