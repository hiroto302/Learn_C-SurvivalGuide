using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Events : MonoBehaviour
{
    void Start()
    {
        Events.onClick += TurnRed;
    }
    public void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void OnDisable()
    {
        Events.onClick -= TurnRed;
    }
}
