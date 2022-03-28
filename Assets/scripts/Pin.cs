using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public new Rigidbody2D rigidbody;
    public float speed = 20;

        // Update is called once per frame
    void Update()
    {
        rigidbody.MovePosition(rigidbody.position + Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BigCircle"))
        {
            transform.SetParent(collision.transform);
        }
        else if (collision.CompareTag("Pin"))
        {
            Time.timeScale = 0;
        }
    }
}
