using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField]
    int point;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            point = Random.Range(0, 3);

            switch(point)
            {
                case 0:
                    Debug.Log("bad");
                    break;
                case 1:
                    Debug.Log("normal");
                    break;
                default:
                    Debug.Log("good");
                    break;
            }
        }

    Debug.Log(point);



    }
}
