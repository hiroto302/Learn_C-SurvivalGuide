using System;
using UnityEngine;

// Practicing_2
public class Delegates_P2 : MonoBehaviour
{
    public Action onGetName;

    void Start()
    {
        onGetName = () => Debug.Log("GameObjectName : " + gameObject.name);
        onGetName();
    }
}
