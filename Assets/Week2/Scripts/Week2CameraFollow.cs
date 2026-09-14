using UnityEngine;

public class Week2CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;

    private void LateUpdate()
    {
        if (playerTransform != null)
        {
            transform.position = playerTransform.position + offset;
        }
    }
}