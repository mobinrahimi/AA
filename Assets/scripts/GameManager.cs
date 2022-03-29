using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instace;

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
        animator.SetTrigger("GameOver");
    }
}
