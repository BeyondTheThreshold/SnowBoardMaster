using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Road")
        {
            crashEffect.Play();
            Debug.Log("replay!");
            Invoke("ReloadScene", 0.2f);
        }
    }
          void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
  
      
}
