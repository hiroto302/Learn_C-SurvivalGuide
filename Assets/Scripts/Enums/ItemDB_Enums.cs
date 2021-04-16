using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB_Enums : MonoBehaviour
{
    public List<Item_Enums> itemDB = new List<Item_Enums>();

    void Update()
    {
        itemDB[0].Action();
    }
}
