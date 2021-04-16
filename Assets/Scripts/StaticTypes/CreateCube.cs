using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreateObject;

public class CreateCube : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            UtilityHelper.CreateObject();
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            UtilityHelper.SetPositionZero(this.gameObject);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            UtilityHelper.ChangeColor(this.gameObject, Color.red, true);
        }
    }
}
