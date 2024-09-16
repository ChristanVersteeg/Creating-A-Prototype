using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private Transform target;
    [SerializeField] private int speed;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        transform.LookAt(target.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        player.TakeDamage(damage);
    }
}
