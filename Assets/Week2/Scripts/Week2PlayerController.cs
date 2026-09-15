using UnityEngine;

public class Week2PlayerController : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float jumpForce = 6f;

    public GroundCheck groundCheck;
    public ParticleSystem jumpParticles;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Mobile input
        if (MobileInput.left)
            horizontal = -1f;

        if (MobileInput.right)
            horizontal = 1f;

        if (MobileInput.forward)
            vertical = 1f;

        if (MobileInput.back)
            vertical = -1f;

        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        if (movement.magnitude > 0)
        {
            rb.AddForce(movement.normalized * moveSpeed, ForceMode.Force);
        }

        // Spin while moving forward and backward
        if (vertical != 0)
        {
            rb.AddTorque(Vector3.right * vertical * 2f);
        }

        // Jump using keyboard or mobile button
        if (Input.GetKeyDown(KeyCode.Space) || MobileInput.jump)
        {
            MobileInput.jump = false;

            Debug.Log("JUMP!");

            rb.AddForce(
                Vector3.up * jumpForce,
                ForceMode.Impulse
            );

            if (jumpParticles != null)
            {
                jumpParticles.Play();
            }
        }
    }
}