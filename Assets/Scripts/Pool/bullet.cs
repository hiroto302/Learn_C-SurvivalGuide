using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void Start()
    {
        // この記述ではパフォーマンスが悪い (batches が増加する)
        Destroy(this.gameObject, 1.0f);
    }

    void Update()
    {
        
    }
}
