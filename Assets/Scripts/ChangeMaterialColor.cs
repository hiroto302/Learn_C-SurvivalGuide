using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            player.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
