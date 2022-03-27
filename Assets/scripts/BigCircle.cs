using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCircle : MonoBehaviour
{
    public float speed = 100;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speed*Time.deltaTime);
    }
}
