using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BigCircle : MonoBehaviour
{
    public float speed = 100;
    public TMP_Text adad;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speed*Time.deltaTime);
    }

    public void UpdateText()
    {
        adad.text = (GameManager.instace.totallPins - GameManager.instace.pins.Count).ToString();
    }
}
