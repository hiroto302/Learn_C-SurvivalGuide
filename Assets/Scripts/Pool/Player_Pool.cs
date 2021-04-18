using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Pool : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletPrefab;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // communicate with the object pool system
            GameObject bullet =  PoolManager.Instance.RequestBullet();
            // Request bullet
            bullet.transform.position = Vector3.zero;

        }
    }
}
