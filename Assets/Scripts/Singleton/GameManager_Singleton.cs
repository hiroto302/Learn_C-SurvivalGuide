using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Singleton : MonoBehaviour
{
    private static GameManager_Singleton _instance;
    public static GameManager_Singleton Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.Log("The GameManager is NULL");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void DisplayMyName()
    {
        Debug.Log("My name is T.H.");
    }
}
