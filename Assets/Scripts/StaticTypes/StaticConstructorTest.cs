using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple
{
    public string type;
    public string taste;

    public static string locality;

    public Apple()
    {
        Debug.Log("りんご");
    }
    static Apple()
    {
        locality = "青森";
        Debug.Log("りんごの産地 : " + locality);
    }
}
public class StaticConstructorTest : MonoBehaviour
{
    public void Start()
    {
        Apple a1 = new Apple();
        var a2 = new Apple();
        var a3 = new Apple();
    }
}
