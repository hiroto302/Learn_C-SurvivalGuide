using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Events : MonoBehaviour
{

    void Start()
    {
        Events.onClick += Fall;
    }
    public void Fall()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
}
