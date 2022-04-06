using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instace;

    public int totallPins;

    public bool finished;

    public List<Pin> pins = new List<Pin>();

    public Animator animator;

    public BigCircle bigCircle;
    public PinSpawner pinSpawner;
    public GameManager()
    {
        instace = this;
    }
    
    public void loseGame()
    {

        pinSpawner.enabled = false;
        bigCircle.enabled = false;
        for (int i = 0; i < pins.Count; i++)
        {
            pins[i].enabled = false;
        }
        animator.SetTrigger("GameOver");
    }
}
