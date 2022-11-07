using UnityEngine;
using System.Collections;

public class onExitCollider : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        // Destroy everything that leaves the trigger
        Destroy(other.gameObject);
    }
}
