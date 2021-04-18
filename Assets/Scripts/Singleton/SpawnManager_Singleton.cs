using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager_Singleton : MonoBehaviour
{
    // Lazy instantiation
    [SerializeField]
    private GameObject _enemyPrefab;
    private static SpawnManager_Singleton _instance;
    public static SpawnManager_Singleton Instance
    {
        get
        {
            if(_instance == null)
            {
                // Down fall of Lazy instantiation.
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

    public void SpawningEnemy()
    {
        Instantiate(_enemyPrefab);
    }
}
