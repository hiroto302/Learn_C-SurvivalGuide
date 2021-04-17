using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_MossGiant : Enemy_Abstract
{

    void Start()
    {
        Attack();
        Die();
    }
    public override void Attack()
    {

        // コンソールに表示してくれる例外処理 ： NotImplementedException: The method or operation is not implemented.
        // throw new System.NotImplementedException();
        Debug.Log("攻撃");
    }

    // 全て書き換えたり、共通機能を扱いつつ、処理を追加することもできる
    public override void Die()
    {
        base.Die();
        // 追加処理
        Debug.Log("やられたよ");
    }
}
