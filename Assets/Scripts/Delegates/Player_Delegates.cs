using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Delegates : MonoBehaviour
{
    public delegate void OnDeath();
    public static event OnDeath onDeath;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            Death();
        }
    }

    void Death()
    {
        if(onDeath != null)
        {
            onDeath();
        }
        // GameObject.FindObjectOfType<GameManager>().ResetPlayer();
        // GameObject.FindObjectOfType<UIManager>().UpdateDeathCount();
    }
}
