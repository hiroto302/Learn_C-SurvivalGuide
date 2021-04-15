﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    [SerializeField]
    private GameObject cubePrefab;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cubePrefab, Vector3.zero, Quaternion.Euler(0, 35, 0));
        }
    }
}
