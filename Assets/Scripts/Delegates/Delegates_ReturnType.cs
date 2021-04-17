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
    // Lambda
    public Func<string, int> Funk2CharacterLength;

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

        // Lambda
        Funk2CharacterLength = (name) => name.Length; // 引数 => 返り値
        int count3 = Funk2CharacterLength("abc");
        Debug.Log("Lambda : " + count3);
    }

    int GetCharacters(string name)
    {
        return name.Length;
    }
}
