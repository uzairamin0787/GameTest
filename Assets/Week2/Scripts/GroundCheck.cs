using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public float groundDistance = 0.2f;
    public LayerMask groundMask;

    public bool IsGrounded()
    {
        return Physics.CheckSphere(
            transform.position,
            groundDistance,
            groundMask
        );
    }
}