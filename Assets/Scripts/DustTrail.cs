using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem roadEffect;

    void OnCollisionEnter2D(Collision2D other)
    {
       if (other.gameObject.tag=="Road")
            roadEffect.Play();
    }
    void OnCollisionExit2D(Collision2D other)
    {
          if (other.gameObject.tag=="Road")
            roadEffect.Stop();
    }
}
