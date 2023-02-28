using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public GameObject hazard;
    public Text scoreText;
    private int score;
    void Start ()
    {
       
        UpdateScore ();
      
    }

    void Update ()
    {
       
    }

    public void AddScore (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore ();
    }

    IEnumerator waiter(){


        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("SampleScene");
    }

    void UpdateScore ()
    {
        scoreText.text = "Score: " + score;

        if (score >=110) 
        StartCoroutine(waiter());
         
    }

}