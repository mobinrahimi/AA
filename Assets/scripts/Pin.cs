using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pin : MonoBehaviour
{
    public new Rigidbody2D rigidbody;
    public TMP_Text text;
    public TMP_Text adad;
    public float speed = 60;
    bool _isArived;

    public void Start()
    {
        text.text = GameManager.instace.pins.Count.ToString();
    }
    void FixedUpdate()
    {   
        if(!_isArived)
        rigidbody.MovePosition(rigidbody.position + Vector2.up * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BigCircle"))
        {
            _isArived = true;
            transform.SetParent(collision.transform);
            collision.GetComponent<BigCircle>().UpdateText();

            
        }
        else if (collision.CompareTag("Pin"))
        {
            GameManager.instace.loseGame();
        }
    }
}
