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
            Debug.Log("撃ったよ");
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(rayOrigin, out hitInfo))
            {
                IDamgable obj = hitInfo.collider.GetComponent<IDamgable>();
                if(obj != null)
                {
                    obj.DamageHealth(ShootAttackDamage);
                }
            }
        }
    }
    public override void Die()
    {
        base.Die();
    }
}
