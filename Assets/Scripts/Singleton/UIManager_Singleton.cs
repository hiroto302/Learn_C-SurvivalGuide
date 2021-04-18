using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager_Singleton : MonoBehaviour
{
    private static UIManager_Singleton _instance;
    public static UIManager_Singleton Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("UIManager NULL");
            }
            return _instance;
        }
    }
    void Start()
    {
        _instance = this;
    }

    public void UpdateScore()
    {
        Debug.Log("Updated Score");
    }
    public void UpdateHealth()
    {
        Debug.Log("Updated Health");
    }

}
