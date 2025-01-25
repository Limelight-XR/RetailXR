using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorBoundaryHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("User Entered Area");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("User Exited Area");
    }
}
