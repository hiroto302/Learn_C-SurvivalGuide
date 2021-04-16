using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Object
{
    public int id;
    public static int ObjectInstanceNum;

    public Object()
    {
        ObjectInstanceNum++;
    }
}

public class CountInstanceObject : MonoBehaviour
{
    void Start()
    {
        Object o1 = new Object();
        Object o2 = new Object();
        Object o3 = new Object();
        Debug.Log(Object.ObjectInstanceNum);
    }
}


