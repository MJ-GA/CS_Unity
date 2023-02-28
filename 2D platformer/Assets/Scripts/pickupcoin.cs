using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupcoin : MonoBehaviour
{
    private AudioClip clip;
    private GameController gameController;

    public int scoreValue = 10;

    // For now just destroy the coin if the player runs into 7 // it.


    void Start()
    {
        clip = this.GetComponent<AudioSource>().clip;

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    { 
        
        AudioSource.PlayClipAtPoint(clip,this.transform.position);

        if (other.gameObject.tag == "Player")
        {
             Destroy(this.gameObject);
        }

        gameController.AddScore(scoreValue);
    }
}
