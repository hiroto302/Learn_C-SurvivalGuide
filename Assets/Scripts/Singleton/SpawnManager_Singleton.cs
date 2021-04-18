using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager_Singleton : MonoBehaviour
{
    private static SpawnManager_Singleton _instance;
    public static SpawnManager_Singleton Instance
    {
        get
        {
            if(_instance == null)
            {
                GameObject go = new GameObject("Spawn_Manager");
                go.AddComponent<SpawnManager_Singleton>();
            }
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }

    public void SpawnGameObject()
    {
        Debug.Log("to lazily instantiate an object !!");
    }
}
