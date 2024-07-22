using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField] protected float _paddleSpeed = 10f;

    protected Rigidbody2D _paddleRigidbody;

    private void Awake()
    {
        _paddleRigidbody = GetComponent<Rigidbody2D>();
    }

    public void PaddleResetPosition()
    {
        _paddleRigidbody.position = new Vector2(_paddleRigidbody.position.x , 0f);
        _paddleRigidbody.velocity = Vector2.zero;
    }
}
