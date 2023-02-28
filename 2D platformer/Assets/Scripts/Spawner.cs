using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // nov long our level is.
    public int maxPlatforms = 20;

    // rite actual aane object
    public GameObject platform;

    // Rance of post=ons ykore vo will span: a nay plc:fcrm
    public float horizontalMin = 7.5f;
    public float horizontalMax = 14f;
    public float verticalMin = -6f;
    public float verticalMax = 6f;

    // Where cur init:al cfnet :g.
    private Vector2 originPosition;

    void Start()
    {
        originPosition = transform.position;
    }

    // Functacn that generates a rev oameobiect.
    void Spawn()
    {
        for (int i = 0; i < maxPlatforms; i++)
        {
            Vector2 randomPosition =
                originPosition
                + new Vector2(
                    Random.Range(horizontalMin, horizontalMax),
                    Random.Range(verticalMin, verticalMax)
                );
            Instantiate(platform, randomPosition, Quaternion.identity);

            originPosition = randomPosition;
        }
    }
}
