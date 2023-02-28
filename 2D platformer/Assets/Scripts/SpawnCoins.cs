using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public Transform[] coinSpawns;
    public GameObject coin;

   

    // Use for initialization
    void Start()
    {
        Spawn();
    }

    void Spawn()
    { //
        for (int i = 0; i < coinSpawns.Length; i++)
        {
            
            
            
                Instantiate(coin, coinSpawns[i].position, Quaternion.identity);
            
        }
    }
    
}
