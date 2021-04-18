using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void Start()
    {
        // この記述ではパフォーマンスが悪い (batches が増加する)
        // Destroy(this.gameObject, 1.0f);
        // 大量のオブジェクトを扱うときは、リサイクルシステムを実装する必要がある
    }

    void OnEnable()
    {
        Invoke("Hide", 1.0f);
    }


    void Hide()
    {
        // re-cycle the gameObject
        this.gameObject.SetActive(false);
    }
}
