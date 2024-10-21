using UnityEngine;

public class CreatePrimitives : MonoBehaviour
{
    private void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 0, 0);
    }
}
