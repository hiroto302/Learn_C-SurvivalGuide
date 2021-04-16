using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveList : MonoBehaviour
{
    public List<string> names = new List<string>();

    void Start()
    {
        names.Add("a");
        names.Add("b");
        names.Add("c");
        names.Add("d");
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            names.RemoveAt(Random.Range(0, names.Count));
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            var nameToRemove = names[Random.Range(0, names.Count)];
            names.Remove(nameToRemove);
        }
    }

}
