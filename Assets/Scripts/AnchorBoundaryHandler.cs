using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorBoundaryHandler : MonoBehaviour
{
    [SerializeField] private Material mat;

    private void OnTriggerEnter(Collider other)
    {
        this.transform.parent.GetComponentInChildren<MeshRenderer>().material = mat;
    }

    private void OnTriggerExit(Collider other)
    {
        this.transform.parent.GetComponentInChildren<MeshRenderer>().material = null;
    }
}
