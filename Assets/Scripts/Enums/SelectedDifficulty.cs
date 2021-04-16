using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 画面の難易度選択によって、ロードする画面を決定することを想定したクラス作成
public class SelectedDifficulty : MonoBehaviour
{
    public enum Difficult
    {
        Easy,       // 0 デフォルト
        Normal,     // 1
        Hard = 5,       // 2
        Expert = 0      // 3  ExpertのインデックスをEasyと被らせると、Easyの扱いになる
    }

    public Difficult selectedDifficulty;


    public void Update()
    {
        Debug.Log((int)selectedDifficulty);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene((int)selectedDifficulty);
    }
}
