﻿using System.Collections;
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
            Instantiate(_bulletPrefab);
        }
    }
}