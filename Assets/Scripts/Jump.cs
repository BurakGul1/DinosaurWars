using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private Vector2 _jumpForce;
    private Rigidbody2D _rb2d;
    private AudioSource _audioSource;
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _rb2d.AddForce(_jumpForce);
            _audioSource.Play();
        }
    }
}
