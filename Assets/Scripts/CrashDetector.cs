using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Road")
        {
            Debug.Log("replay!");
            SceneManager.LoadScene(0);
        }
    }
          
      
}
