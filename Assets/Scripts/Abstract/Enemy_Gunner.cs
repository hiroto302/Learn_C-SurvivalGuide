using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Gunner : Enemy_Abstract, IShoot
{
    public int ShootAttackDamage { set; get; }

    public void Start()
    {
        ShootAttackDamage = 3;
    }
    public void Update()
    {
        Shoot();
    }

    public override void Attack()
    {
        Shoot();
    }
    public void Shoot()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(rayOrigin, out hitInfo))
            {
                // Interface で機能を管理することで、ダメージを与えることができる敵が多様化しても、短い記述で対応することができる
                IDamgable obj = hitInfo.collider.GetComponent<IDamgable>();
                if(obj != null)
                {
                    obj.DamageHealth(ShootAttackDamage);
                }

                // if(hitInfo.collider.name == "Enemy_MossGiant")
                // {
                //     hitInfo.collider.GetComponent<Enemy_MossGiant>().DamageHealth(ShootAttackDamage);
                // }
            }
        }
    }
    public override void Die()
    {
        base.Die();
    }
}
