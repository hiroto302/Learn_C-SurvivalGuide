using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 受けるダメージを実装
interface IDamgable

{
    int Damage { set; get; }

    void DamageHealth(int damageAmount);

    
}
