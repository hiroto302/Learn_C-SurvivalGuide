using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 品物 : Serializable 属性によりインスペクター上でクラスにサブプロパティーを埋め込むことを許可する
[System.Serializable]
public class Item
{
    public int itemID;
    public string itemName;
    public string itemDescription;
}
// お店にある品物を管理するクラス
public class Shop : MonoBehaviour
{
    public Item[] storedItems;
    // Start is called before the first frame update
    void Start()
    {
        foreach(var item in storedItems)
        {
            Debug.Log(item.itemDescription);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
