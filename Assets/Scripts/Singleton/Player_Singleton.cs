using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Singleton : MonoBehaviour
{
    public void Start()
    {
        // Simple Accese to Singleton
        GameManager_Singleton.Instance.DisplayMyName();
    }
}
