using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonKiller : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y >5.76 || transform.position.y < -5.7)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Stumps"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
