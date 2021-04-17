using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Delegates : MonoBehaviour
{

    // public delegate void OnDamageReceived(int currentHealth);
    // public static event OnDamageReceived onDamage;

    // System.Action を使うことで、上記の２行を下記の１行で済む
    public static Action<int> OnDamageReceived;

    public delegate void OnDeath();
    public static event OnDeath onDeath;

    public static int Health { get; set; }

    void Start()
    {
        Health = 10;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            Damage();
            // Death();
        }
    }

    void Damage()
    {
        Health--;
        // if(onDamage != null)
        // {
        //     onDamage();
        // }
        if(OnDamageReceived != null)
        {
            OnDamageReceived(Health);
        }
        if(Health <= 0)
        {
            Death();
            Health = 10;
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
