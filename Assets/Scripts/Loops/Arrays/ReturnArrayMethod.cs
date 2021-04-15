using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnArrayMethod : MonoBehaviour
{
    public GameObject[] players;
    void Start()
    {
        players = GetAllPlayers();
    }
    GameObject[] GetAllPlayers()
    {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");
        foreach(var p in allPlayers)
        {
            p.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
        return allPlayers;
    }
}
