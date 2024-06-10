using Tags;
using UnityEngine;

public class PickaxePickup : MonoBehaviour
{
    public static bool pickaxeHeld;
    [SerializeField] private Transform hand;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag(Tag.Player)) return;

        transform.Rotate(new Vector3(90 / 2, 0, 0));
        transform.position = hand.transform.position;
        transform.SetParent(hand);
        rb.isKinematic = true;
        pickaxeHeld = true;

    }
}