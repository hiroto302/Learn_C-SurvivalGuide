using System.Collections;
using System.Collections.Generic;
using UnityEngine;
interface IDamgable

{
    int Damage { set; get; }

    void DamageHealth(int damageAmount);
}
