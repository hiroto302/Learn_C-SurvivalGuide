using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        // 完全停止
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Time.timeScale = 1.0f;
        }

        // 2倍速
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 2.0f;
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            Time.timeScale = 1.0f;
        }
    }
}
