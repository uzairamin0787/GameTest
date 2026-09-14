using UnityEngine;

public class Week2PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;

    public GroundCheck groundCheck;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        rb.MovePosition(
            rb.position + movement * moveSpeed * Time.deltaTime
        );

        // Spin while moving forward
        if (vertical > 0)
        {
            rb.AddTorque(Vector3.right * 2f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space pressed. Grounded = " + groundCheck.IsGrounded());

            if (groundCheck.IsGrounded())
            {
                Debug.Log("JUMPING!");

                rb.AddForce(
                    Vector3.up * jumpForce,
                    ForceMode.Impulse
                );
            }
        }
    }
}