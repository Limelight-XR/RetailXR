using OpenAI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorBoundaryHandler : MonoBehaviour
{
    [SerializeField] private GameObject visualComponent;
    [SerializeField] private ChatGPT chatComponent;

    private void OnTriggerEnter(Collider other)
    {
        visualComponent.SetActive(false);
        chatComponent.canChat = true;
    }

    private void OnTriggerExit(Collider other)
    {
        visualComponent.SetActive(true);
        chatComponent.canChat = false;
    }
}
