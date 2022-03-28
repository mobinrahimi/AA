using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    public GameObject pinPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(pinPrefab, transform.position, transform.rotation);
        }
    }

    private void OnMouseDrag()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
