using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy_Abstract : MonoBehaviour
{
    public int speed;
    public int health;
    public int gems;

    public abstract void Attack();

    public virtual void Die()
    {
        Destroy(this.gameObject);
    }
}

