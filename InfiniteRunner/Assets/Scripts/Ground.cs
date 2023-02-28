using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
public float speed = 0.5f;

    void Start()
    {
      
    }
    void Update()
    {
        float offset = Time.time * speed % 1; // The % 1 keeps offset between 0 and 1
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, -offset);
    }

    public void SlowDown()
    {
        speed /= 2; 
    }

    public void SpeedUp()
    {
        speed *= 2;
    }
}
