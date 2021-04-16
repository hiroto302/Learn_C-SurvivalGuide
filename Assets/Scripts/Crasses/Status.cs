using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Status
{
    public string name;
    public int id;
    public string description;

    public Status(string name, int id, string description)
    {
        this.name = name;
        this.id = id;
        this.description = description;
    }
}
