using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private GameObject controller;
    private gameController script;

    void Start()
    {
        controller = GameObject.FindWithTag("GameController");
        script = controller.GetComponent<gameController>();
    }

    void FixedUpdate()
    {
        float horAxis = Input.GetAxis("Horizontal");
        float vertAxis = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horAxis, 0.0f, vertAxis);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    } // NO changes

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);

            script.count++;
            script.SetCountText();
        }
    }
}
