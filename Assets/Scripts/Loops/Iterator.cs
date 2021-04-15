using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// コルーチンを利用して１秒ごとにりんごを一個増やし、３０個にする
public class Iterator : MonoBehaviour
{
    public int apples;
    public float second;
    public int count;

    void Start()
    {
        // コルーチン処理の開始
        StartCoroutine(AddApplesRoutine());
        StartCoroutine(AddIncrementRoutine());
    }
    void Update()
    {
        // 比較対象
        // second += Time.deltaTime;
        // Debug.Log(second.ToString() + ": Second");
    }
    /* Iterator : プログラミング言語において配列やそれに類似する集合的データ構造（
                コレクションあるいはコンテナ）の各要素に対する繰り返し処理の抽象化のことをさす
        yield   : 進捗情報の保持と、中段場所からの再開を行うのに反復子*/
    IEnumerator AddApplesRoutine()
    {
        for(int i = 0; i < 30; i++)
        {
            apples++;
            // 1秒処理を待機する
            yield return new WaitForSeconds(1.0f);
        }
    }

    // ５秒毎に増加
    IEnumerator AddIncrementRoutine()
    {
        for(int i = 0; i <= 60; i++)
        {
            count++;
            yield return new WaitForSeconds(5.0f);
        }
    }

}
