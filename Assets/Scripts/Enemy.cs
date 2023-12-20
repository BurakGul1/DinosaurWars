using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private Collider2D _collider2D;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _collider2D = GetComponent<Collider2D>();
    }

    public void Die()
    {
        _spriteRenderer.enabled = false;
        _collider2D.enabled = false;
    }

    public void Respawn()
    {
        _spriteRenderer.enabled = true;
        _collider2D.enabled = true;
    }
}
