using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private int health = 5;
    [SerializeField] private int level = 1;
    [SerializeField] private float speed = 1.2f;

    private Vector3 newPosition;

    private void Start()
    {
        health += level;

        print(health);
    }

    private void FixedUpdate()
    {
        newPosition.z += speed;
        transform.position = newPosition;
    }
}
