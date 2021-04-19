using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CommandManger_2 : MonoBehaviour
{
    private static CommandManger_2 _instance;
    public static CommandManger_2 Instance
    {
        get
        {
            if(_instance == null)
                Debug.LogError("The CommandeManager_2 is NULL");
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }

    private List<ICommand_2> _commandBuffer = new List<ICommand_2>();

    public void AddCommand(ICommand_2 comand)
    {
        _commandBuffer.Add(comand);
    }

    public void Rewind()
    {
        StartCoroutine(RewindRoutine());
    }
    IEnumerator RewindRoutine()
    {
        Debug.Log("Rewinding...");
        foreach(var command in Enumerable.Reverse(_commandBuffer))
        {
            command.Undue();
            yield return new WaitForEndOfFrame();
        }
        Debug.Log("Finished");
    }

    public void Play()
    {
        StartCoroutine(PlayRoutine());
    }
    IEnumerator PlayRoutine()
    {
        Debug.Log("Playing...");
        foreach(var command in _commandBuffer)
        {
            command.Execute();
            yield return new WaitForEndOfFrame();
        }
        Debug.Log("Finished");
    }
}
