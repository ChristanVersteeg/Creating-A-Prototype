using UnityEngine;

[ExecuteInEditMode]
public class GroundCheck : MonoBehaviour
{
    [Tooltip("Maximum distance from the ground.")]
    public float distanceThreshold = .15f;

    [Tooltip("Whether this transform is grounded now.")]
    public bool isGrounded = true;
    /// <summary>
    /// Called when the ground is touched again.
    /// </summary>
    public event System.Action Grounded;

    private const float originOffset = .001f;

    private Vector3 RaycastOrigin => transform.position + Vector3.up * originOffset;

    private float RaycastDistance => distanceThreshold + originOffset;

    private void LateUpdate()
    {
        // Check if we are grounded now.
        bool isGroundedNow = Physics.Raycast(RaycastOrigin, Vector3.down, distanceThreshold * 2);

        // Call event if we were in the air and we are now touching the ground.
        if (isGroundedNow && !isGrounded)
        {
            Grounded?.Invoke();
        }

        // Update isGrounded.
        isGrounded = isGroundedNow;
    }

    private void OnDrawGizmosSelected()
    {
        // Draw a line in the Editor to show whether we are touching the ground.
        Debug.DrawLine(RaycastOrigin, RaycastOrigin + Vector3.down * RaycastDistance, isGrounded ? Color.white : Color.red);
    }
}
