using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public new Rigidbody2D rigidbody;
    public float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.MovePosition(rigidbody.position + Vector2.up * speed * Time.deltaTime);
    }
}
