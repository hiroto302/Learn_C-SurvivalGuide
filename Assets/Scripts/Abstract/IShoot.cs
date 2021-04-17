using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShoot
{
    // 与えるダメージ
    int ShootAttackDamage { set; get; }
    void Shoot();
}
