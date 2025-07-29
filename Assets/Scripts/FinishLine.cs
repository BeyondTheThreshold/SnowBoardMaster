using UnityEngine;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("finished!");
    }
}