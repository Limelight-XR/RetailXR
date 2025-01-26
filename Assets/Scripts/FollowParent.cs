using UnityEngine;

public class FollowParent : MonoBehaviour
{
    public OVRCameraRig cameraRig;
    public GameObject parentObject;
    private Vector3 initialPositionOffset;
    private Transform centerEyeAnchor;

    private void Start()
    {
        // Calculate the initial position offset
        initialPositionOffset = transform.position - parentObject.transform.position;

        // Get the centerEyeAnchor from the OVRCameraRig
        centerEyeAnchor = cameraRig.centerEyeAnchor;
    }

    private void Update()
    {
        // Set the position of the child object relative to the parent using the initial position offset
        transform.position = parentObject.transform.position + initialPositionOffset;

        // Make the game object always face the centerEyeAnchor
        transform.LookAt(centerEyeAnchor);

        // Rotate the game object by 180 degrees to face the camera with contents in front
        transform.Rotate(Vector3.up, 180f);
    }
}