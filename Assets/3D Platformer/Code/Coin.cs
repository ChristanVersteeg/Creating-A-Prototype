using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int amount;

    private void OnCollisionEnter(Collision collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();

        print(player.CollectCoin(amount));

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * 5, ForceMode.Impulse);
    }
}