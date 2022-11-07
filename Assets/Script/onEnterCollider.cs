using UnityEngine;
using System.Collections;

public class onEnterCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Destroy everything that leaves the trigger
        Destroy(other.gameObject);
    }
}
