using System;
using UnityEngine;

// Practicing_1
public class Delegates_P1 : MonoBehaviour
{
    public Action<int, int> Sum;
    public Action<int, int> Sum2;

    public void Start()
    {
        // Delegate
        Sum = CalculationSum;
        Sum(1,2);

        // Deleget + Lambda
        Sum2 = (a, b) => {
            var total = a + b;
            if(total < 100)
            {
                Debug.Log("Total is less than 100");
            }
            Debug.Log("Sum2 : " + total);
        };
        Sum2(1, 7);
    }

    void CalculationSum(int a, int b)
    {
        var total = a + b;
        Debug.Log("Sum : " + total);
    }
}
