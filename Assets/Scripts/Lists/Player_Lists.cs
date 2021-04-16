using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Lists : MonoBehaviour
{
    public PlayerItem.Item[] inventory = new PlayerItem.Item[10];
    ItemDB _ItemDB;

    // Start is called before the first frame update
    void Start()
    {
        _ItemDB = GameObject.Find("God").GetComponent<ItemDB>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            // only this means this Script class
            _ItemDB.AddItem(0, this);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            _ItemDB.RemoveItem(0, this);
        }
    }
}
