using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2 : MonoBehaviour
{
    ICommand_2 moveUp, moveDown, moveLeft, moveRight;

    [SerializeField]
    private float _speed = 2.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            moveUp= new MoveUpCommand(this.transform, _speed);
            moveUp.Execute();
            CommandManger_2.Instance.AddCommand(moveUp);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveDown = new MoveDownCommand(this.transform, _speed);
            moveDown.Execute();
            CommandManger_2.Instance.AddCommand(moveDown);


        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveLeft = new MoveLeftCommand(this.transform, _speed);
            moveLeft.Execute();
            CommandManger_2.Instance.AddCommand(moveLeft);


        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveRight = new MoveRightCommand(this.transform, _speed);
            moveRight.Execute();
            CommandManger_2.Instance.AddCommand(moveRight);
        }
    }
}
