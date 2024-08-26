using UnityEngine;

public class DestroyOre : MonoBehaviour
{
    private static int oresCollected;

    private void OnCollisionEnter(Collision collision)
    {
    

        print($"Ores collected: {++oresCollected}");

        Destroy(gameObject);
    }
}