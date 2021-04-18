using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Singleton : MonoBehaviour
{
    UIManager_Singleton ui;
    public void Start()
    {
        // Simple Accese to Singleton
        GameManager_Singleton.Instance.DisplayMyName();
        ui = UIManager_Singleton.Instance;
        ui.UpdateHealth();
        ui.UpdateScore();
        SpawnManager_Singleton.Instance.SpawnGameObject();

        Debug.Log( "inheritObject.name : " + InheritMonoSingleton.Instance.name);
    }
}
