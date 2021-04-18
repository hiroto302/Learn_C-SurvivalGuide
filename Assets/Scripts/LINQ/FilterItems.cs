using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Item_Linq
{
    public string name;
    public int itemID;
    public int buff;

    public Item_Linq(string name, int itemID, int buff)
    {
        this.name = name;
        this.itemID = itemID;
        this.buff = buff;
    }
}

public class FilterItems : MonoBehaviour
{
    public List<Item_Linq> items;
    void Start()
    {
        items.Add(new Item_Linq("sword", 0, 10));
        items.Add(new Item_Linq("bread", 1, 3));
        items.Add(new Item_Linq("water", 2, 1));

        // Average
        var buffAverage = items.Average(item => item.buff);
        // Debug.Log("Average : " + buffAverage);

        // Define ths query expression : where
        var result =
            from item in items
            where item.itemID > 0
            select item;

        foreach(var item in result)
        {
            Debug.Log(item.name);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
