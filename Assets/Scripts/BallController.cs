using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float _speed = 200f;

    private Rigidbody2D _ballRigidbody;
    private void Awake()
    {
        _ballRigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }
    public void ResetPosition()
    {
        _ballRigidbody.position = Vector3.zero;
        _ballRigidbody.velocity = Vector3.zero;

      
    }

    public void AddStartingForce() 
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) : Random.Range(0.5f,1.0f);
        Vector2 direction = new Vector2(x, y);
        _ballRigidbody.AddForce(direction * this._speed);

    }

    public void AddForce(Vector2 force) 
    {
        _ballRigidbody.AddForce(force);
    }

   
}
