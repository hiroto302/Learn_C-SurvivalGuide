using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Item2 // VALUE TYPE -- Stack
{
    public string name;
    public int id;
    public Item2(string name, int id)
    {
        this.name = name;
        this.id = id;
    }
}
public class Item3 // REFERENCE TYPE -- HEAP
{
    public string name;
    public int id;
    public Item3(string name, int id)
    {
        this.name = name;
        this.id = id;
    }
}

public class StructText : MonoBehaviour
{
    Item3 sword = new Item3("Sword", 1);
    Item2 bread = new Item2("bread", 2);

    void Start()
    {
        Debug.Log(bread.name);
    }
    public void  Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(bread.name);
        }
    }
    void ChangeValue(Item3 classItem)
    {
        classItem.name = "Master_Sword";
    }
    void ChangeValue(Item2 structItem)
    {
        structItem.name = "dirty_bread";
    }
}
