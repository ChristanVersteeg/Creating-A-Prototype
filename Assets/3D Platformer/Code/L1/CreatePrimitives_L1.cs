using UnityEngine;

public class CreatePrimitives_L1 : MonoBehaviour
{
    [SerializeField] private GameObject steve;

    private void Start()
    {
        Instantiate(steve);
    }
}