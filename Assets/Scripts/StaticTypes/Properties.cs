using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    Properties player;
    public void Start()
    {
        player = new Properties();
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Attack(player);
        }
    }
    void Attack(Properties player)
    {
        // 敵は相手を倒すことができる
        player.IsDead = true;
        Debug.Log("倒したよ");
    }
    void PlayerRecovery()
    {
        // isRevivedを読み取り専用にすることで、敵は相手を回復させることはできないようにする
        // Properties.isRevived = true;
    }
}
public class Properties : MonoBehaviour
{
    private bool isDead;
    // Auto Properties
    // ReadOnly
    static public bool isRevived {private set; get; }

    public bool IsDead
    {
        set
        {
            if(value == true)
            {
                Debug.Log("Player id Dead!!");
            }
            isDead = value;
        }
        get {return isDead;}
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            IsDead = true;
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            isRevived = true;
        }
    }
}
