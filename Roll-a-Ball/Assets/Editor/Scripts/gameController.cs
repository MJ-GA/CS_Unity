using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{
    public GameObject player;
    public int count;
    public int numPickups = 4; // Put here the number of pickups you have .
    public Text scoreText;
    public Text winText;

    public Text debugText;

    GameObject closestBall;

    public Text velocityText;

    public Text closestObject;

    Vector3 velocity;
    Vector3 lastPosition;

    public LineRenderer lineRenderer;

    public GameObject[] pickups;

    float distanceToClosestBall;

    void Start()
    {
        count = 0;
        winText.text = "";
        SetCountText();
        lastPosition = player.transform.position;
        lineRenderer = gameObject.AddComponent<LineRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        debugText.text = "Player's Position =" + player.transform.position.ToString();
        velocityText.text =
            "Velocity ="
            + ((player.transform.position - lastPosition) / Time.deltaTime).ToString()
            + "\nScalar = "
            + ((player.transform.position - lastPosition) / Time.deltaTime).magnitude.ToString();
        lastPosition = player.transform.position;
        findClosestBall();
    }

    public void SetCountText()
    {
        scoreText.text = "Score: " + count.ToString();
        if (count >= numPickups)
        {
            winText.text = "You won !";

          
        }
    }

    public void findClosestBall()
    {
        distanceToClosestBall = float.MaxValue;
        closestBall = null;
        foreach (var pickup in pickups)
        {
            pickup.GetComponent<Renderer>().material.color = Color.white;
            float distanceToBall = (
                pickup.transform.position - player.transform.position
            ).sqrMagnitude;

            if (distanceToBall < distanceToClosestBall && pickup.active)
            {
                foreach (var pickup2 in pickups)
                {
                    distanceToClosestBall = distanceToBall;
                    pickup2.GetComponent<Renderer>().material.color = Color.white;
                    closestBall = pickup;
                    closestBall.GetComponent<Renderer>().material.color = Color.blue;
                    closestObject.text= "Closest pickup is " + (Vector3.Distance(closestBall.transform.position,player.transform.position)).ToString("F2")+" units away";
                }
                if (closestBall.active)
                {
                    lineRenderer.SetPosition(0, player.transform.position);
                    lineRenderer.SetPosition(1, closestBall.transform.position);
                    lineRenderer.SetWidth(0.1f, 0.1f);
                }
            }
        }
    }
}

