using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Enemy _enemy;

    private void Start()
    {
        _enemy = GetComponent<Enemy>();
    }

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _speed,Space.World);

        if (transform.position.x < -11)
        {
            transform.position += new Vector3(30, 0, 0);
            ShowRandomSprite();
            _enemy?.Respawn();
            
        }
    } 

    private void ShowRandomSprite()
    {
        int index = UnityEngine.Random.Range(0, 3);
        int childCount = transform.childCount;

        for (int i = 0; i < childCount;  i++)
        {
            Transform child = transform.GetChild(i);
            child.gameObject.SetActive(index == i);
        }
    }

    private void OnEnable()
    {
        ShowRandomSprite();
    }
}
