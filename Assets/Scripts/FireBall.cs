using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    [SerializeField] private Vector2 _startingVelocity;
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _rb2d.velocity = _startingVelocity;
        Destroy(gameObject,2);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        var enemy = other.collider.GetComponent<Enemy>();
        enemy?.Die();
        Destroy(gameObject);
    }
}
