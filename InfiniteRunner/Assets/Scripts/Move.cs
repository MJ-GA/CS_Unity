using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private GameController control;
    
 
    void Start()
    {
        control = GameObject.FindObjectOfType<GameController>();
    }

    void Update()
    {
        if (!control.IsGameOver)
        {
            transform.Translate(0,0,control.startSpeed);
        }
    }
}
