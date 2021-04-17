using System;
using UnityEngine;

// Practicing_3
public class Delegates_P3 : MonoBehaviour
{
    public Func<int> onGetName;

    public void Start()
    {
        onGetName = () => this.gameObject.name.Length;
        int characterCount = onGetName();
        Debug.Log("P3 : " + characterCount.ToString());
    }
}
