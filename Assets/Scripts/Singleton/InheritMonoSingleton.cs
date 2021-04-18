using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritMonoSingleton : MonoSingleton<InheritMonoSingleton>
{
    public string name;
    public override void Init()
    {
        base.Init();
        Debug.Log("InheritMono Initialized !");
    }
}
