using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DestroyScript : MonoBehaviour
{
    // Start is called before the first frame update
  void OnTriggerEnter2D(Collider2D other) {
     if ((other.gameObject.tag=="Player"))
        {
           SceneManager.LoadScene("SampleScene");
        }
}
    void OnCollisionEnter2D(Collision2D col)
    {
       if ((col.gameObject.tag=="Platform"))
      Destroy(col.gameObject);
    }
}
