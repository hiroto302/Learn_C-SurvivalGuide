using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Delegates_ReturnType : MonoBehaviour
{
    // delegate 宣言
    public delegate int CharacterLength(string text);
    // delegate インスタンス変数
    CharacterLength c1;
    // Func 宣言 <引数, 返り値>
    public Func<string, int> FunkCharacterLength;

    void Start()
    {
        // Delegate
        // インスタンス作成
        c1 = new CharacterLength(GetCharacters);
        // 実行
        int count = c1("abcd");
        Debug.Log("Delegate : " + count);

        // Function
        FunkCharacterLength = GetCharacters;
        int count2 = FunkCharacterLength("abcde");
        Debug.Log("Func : " + count2);
    }

    int GetCharacters(string name)
    {
        return name.Length;
    }
}
