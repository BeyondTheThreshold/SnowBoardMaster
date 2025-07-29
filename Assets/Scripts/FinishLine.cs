using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField] float MagicNumber = 2f;
    [SerializeField] ParticleSystem finshEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ch") // 4분59초
        {
            finshEffect.Play();
            Debug.Log("Finsh!");
            Invoke("ReloadScene", MagicNumber);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}