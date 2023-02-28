using UnityEngine;
using System.Collections;

public class ShotDestroyer : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
