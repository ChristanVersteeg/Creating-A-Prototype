using Tags;
using UnityEngine;

public class BreakLantern : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private new Light light;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(Tag.Player)) return;

        rb.isKinematic = false;
        light.enabled = false;
    }
}