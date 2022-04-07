using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    public GameObject pinPrefab;
    int _pinsToShoot;
    int _shootedPin;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _pinsToShoot = GameManager.instace.totallPins;
            _shootedPin = GameManager.instace.pins.Count;
            if (_pinsToShoot > _shootedPin)
            {
                GameObject pin = Instantiate(pinPrefab, transform.position, transform.rotation);
                GameManager.instace.pins.Add(pin.GetComponent<Pin>());
                

            }
            if (_pinsToShoot <= _shootedPin+1)
            {
                GameManager.instace.finished = true;
                
            }

        }
    }
}
