using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpStrength = 2;
    public event System.Action Jumped;

    [SerializeField, Tooltip("Prevents jumping when the transform is in mid-air.")]
    private GroundCheck groundCheck;

    private void Reset()
    {
        // Try to get groundCheck.
        groundCheck = GetComponentInChildren<GroundCheck>();
    }

    private void Awake()
    {
        // Get rigidbody.
        rb = GetComponent<Rigidbody>();
    }

    private void LateUpdate()
    {
        // Jump when the Jump button is pressed and we are on the ground.
        if (Input.GetButtonDown("Jump") && (!groundCheck || groundCheck.isGrounded))
        {
            rb.AddForce(100 * jumpStrength * Vector3.up);
            Jumped?.Invoke();
        }
    }
}
