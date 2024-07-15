using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddleController : PaddleController 
{
    [SerializeField] Rigidbody2D _ballrigidbody;

    private void FixedUpdate()
    {
        if (this._ballrigidbody.velocity.x > 0f)
        {
            if (this._ballrigidbody.position.y > this.transform.position.y)
            {
                _paddleRigidbody.AddForce(Vector2.up * this._speed);
            }
            else if (this._ballrigidbody.position.y < this.transform.position.y)
            {
                _paddleRigidbody.AddForce(Vector2.down * this._speed); 
            }
        }
        else
        {
            if (this.transform.position.y > 0f)
            {
                _paddleRigidbody.AddForce(Vector2.down * this._speed);
            }
            else if (this.transform.position.y < 0f)
            {
                _paddleRigidbody.AddForce(Vector2.up * _speed);
            }
        }
    }
}
    
