using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crash;
    [SerializeField] bool canCrash = true;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Road"&& canCrash == true)
        {
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crash);
            Debug.Log("replay!");
            canCrash = false;
            Invoke("ReloadScene", 1.5f);
        }
    }
          void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
  
      
}
