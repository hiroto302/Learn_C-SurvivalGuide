using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_GenericType : MonoBehaviour, IGenericInterfaces<Vector3>
{
    void Start()
    {
        // GenericMethod(1.2f);
        GenericMethod(new Vector3(1.5f, 1.5f, 1.5f));
    }
    // public void GenericMethod(float type)
    // {
    //     transform.localScale = new Vector3(type, type, type);
    // }
    public void GenericMethod(Vector3 type)
    {
        transform.localScale = type;
    }
}
