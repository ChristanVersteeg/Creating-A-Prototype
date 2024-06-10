using Tags;
using UnityEngine;

public class BoostJumpHeight : MonoBehaviour
{
    private int baseJumpStrength;
    [Header("Boost Settings")]
    [Tooltip("Additive boost to your current jump strength.")]
    [SerializeField] private int boostStrength = 1;
    [Tooltip("Determines if the boost can stack with itself additively or not.")]
    [SerializeField] private bool canStack;

    [Header("Initial Boost Settings")]
    [Tooltip("If true, gives an initial upwards boost on pickup.")]
    [SerializeField] private bool initialBoostEnabled;
    [Tooltip("Strength of the upwards force of the initial boost, if enabled.")]
    [SerializeField] private int initialBoostStrength = 10;

    private Rigidbody rb;
    private Jump jump;
    private AudioSource collectSound;

    private void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag(Tag.Player);
        rb = player.GetComponent<Rigidbody>();
        jump = player.GetComponent<Jump>();

        baseJumpStrength = (int)jump.jumpStrength;

        collectSound = FindObjectOfType<FirstPersonAudio>().gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(Tag.Player)) return;

        collectSound.Play();

        if (initialBoostEnabled)
            rb.AddForce(0, initialBoostStrength, 0, ForceMode.Impulse);

        if (jump.jumpStrength == baseJumpStrength || canStack)
            jump.jumpStrength += boostStrength;

        Destroy(gameObject);
    }
}