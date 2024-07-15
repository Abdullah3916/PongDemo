using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddleController : PaddleController 
{
    [SerializeField] Rigidbody2D _rbOfBall;

    private void FixedUpdate()
    {
        if (this._rbOfBall.velocity.x > 0f)
        {
            if (this._rbOfBall.position.y > this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * this._speed);
            }
            else if (this._rbOfBall.position.y < this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * this._speed); 
            }
        }
        else
        {
            if (this.transform.position.y > 0f)
            {
                _rigidbody.AddForce(Vector2.down * this._speed);
            }
            else if (this.transform.position.y < 0f)
            {
                _rigidbody.AddForce(Vector2.up * _speed);
            }
        }
    }
}
    
