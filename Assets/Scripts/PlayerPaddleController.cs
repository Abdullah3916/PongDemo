using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleController : PaddleController
{
    private Vector2 _direction;

    private void Update()
    {
        PaddleMovement();
    }
    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * _speed);
        }
    }

    private void PaddleMovement() 
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }
}
