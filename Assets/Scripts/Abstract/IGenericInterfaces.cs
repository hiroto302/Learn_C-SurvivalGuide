using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface IGenericInterfaces<T>
{
    void GenericMethod(T type);

    // void GenericMethod(int i);
    // void GenericMethod(float f);
    // void GenericMethod(GameObject obj);
}
