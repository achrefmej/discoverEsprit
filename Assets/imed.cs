using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imed : MonoBehaviour
{
    public bool playerInRange;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if ( other.CompareTag("PlayerController"))
                {
            playerInRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerController"))
                {
            playerInRange = false;
        }
    }
}
