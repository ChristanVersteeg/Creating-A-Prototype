using UnityEngine;

public class Booster : MonoBehaviour
{
    [SerializeField]
    private float speedMult
        = 2.5f;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= speedMult;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= speedMult;
    }
}