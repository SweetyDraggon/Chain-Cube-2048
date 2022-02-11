using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAwake : MonoBehaviour
{
    int timeForImpulse = 0;
    public Rigidbody cubeRb;
    void Start()
    {
       cubeRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        timeForImpulse++;
        if (timeForImpulse <= 3)
        {
            cubeRb.AddForce(transform.up * 130);
        }
    }
}
