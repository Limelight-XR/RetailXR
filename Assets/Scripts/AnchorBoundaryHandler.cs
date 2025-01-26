using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorBoundaryHandler : MonoBehaviour
{
    [SerializeField] private GameObject visualComponent;

    private void OnTriggerEnter(Collider other)
    {
        visualComponent.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        visualComponent.SetActive(true);
    }
}
