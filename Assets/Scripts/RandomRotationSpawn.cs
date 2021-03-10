using UnityEngine;

public class RandomRotationSpawn : MonoBehaviour
{
    private void Start()
    {
        transform.rotation = Random.rotation;
    }
}
