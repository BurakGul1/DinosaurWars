using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{
    private float heightVariance = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=Vector3.up * Mathf.Sin(Time.deltaTime) * Time.deltaTime * heightVariance;
    }
}
