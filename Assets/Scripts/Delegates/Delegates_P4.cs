using System;
using UnityEngine;

// Practicing_4
public class Delegates_P4 : MonoBehaviour
{
    // Func<引数, 引数, 返り値>
    public Func<int, int, int> onCalculateSum;

    void Start()
    {
        // 行が複数になるときは、return Key を記述する必要がある
        onCalculateSum = (a, b) =>{
            // a + b;
            return a + b;
        };
        Debug.Log("P4 : " + onCalculateSum(3,4));
    }
}
