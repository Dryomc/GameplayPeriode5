using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    Idle = 0,
    Walking,
    Caught
};

public enum Direction
{
    Up = 0,
    Right,
    Down,
    Left
};


public class Player : MonoBehaviour
{


    Direction _Direction;
    PlayerState _PlayerState;


    void Start()
    {
        _PlayerState = PlayerState.Idle;
    }

    void Update()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");

        transform.Translate(new Vector3(horizontal, vertical, 0) * 3 * Time.deltaTime);

        if (vertical == -1)
        {
            _Direction = Direction.Down;
        }
        else if (vertical == 1)
        {
            _Direction = Direction.Up;
        }
        if (horizontal == -1)
        {
            _Direction = Direction.Left;
        }
        if (horizontal == 1)
        {
            _Direction = Direction.Right;
        }

    }
}
        
