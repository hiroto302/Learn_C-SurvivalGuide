using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LinqExample : MonoBehaviour
{
    string[] names = {"a", "b", "c", "d", "e"};

    void Start()
    {
        // Any
        var nameFound = names.Any(name => name == "c");
        Debug.Log("nameFound : " + nameFound);

        //

        // foreach (var name in names)
        // {
        //     if(name == "c")
        //     {
        //         Debug.Log("match !! : " + name);
        //     }
        // }
    }
}
