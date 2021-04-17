using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  lear Events : This is a powerful system that calls functions from one class to another without a direct link.
    other class can invoke and control the delegate while you can only subscribe or unsubscribe a method to an event.
    他のクラスでイベント内容を決めることができるが,イベントを実行制御をするのはこのクラスのみ */
public class Events : MonoBehaviour
{
    public delegate void ActionClick();
    public static event ActionClick onClick;
    public void ButtonClick()
    {
        // turn all cubes red
        if(onClick != null)
        {
            onClick();
        }
    }
}
