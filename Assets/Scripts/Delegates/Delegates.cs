using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Learn Delegate
public class Delegates : MonoBehaviour
{
    // Declare delegate
    public delegate void ChangeColor(Color newColor);
    // delegate Variable : Reference Type
    public ChangeColor onColorChange;

    public delegate void OnComplete();
    public OnComplete onComplete;

    void Start()
    {
        onColorChange = UpdateColor;
        onColorChange(Color.green);

        // Debug.Log(onComplete) = null;
        onComplete = Task;
        if(onComplete != null)
        {
            onComplete();
            onComplete -= Task;
            onComplete = onComplete + Task2 + Task3;
            onComplete();
        }
    }

    public void UpdateColor(Color newColor)
    {
        Debug.Log("Change Color to " + newColor.ToString());
    }
    public void Task()
    {
        Debug.Log("Task Finished");
    }
    public void Task2()
    {
        Debug.Log("Task2 Finished");
    }
    public void Task3()
    {
        Debug.Log("Task3 Finished");
    }
}
