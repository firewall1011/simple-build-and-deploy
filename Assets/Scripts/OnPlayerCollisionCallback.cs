using UnityEngine;
using UnityEngine.Events;

public class OnPlayerCollisionCallback : MonoBehaviour
{
    public UnityEvent playerTriggerEnter = new UnityEvent();
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerTriggerEnter.Invoke();
        }
    }
}
