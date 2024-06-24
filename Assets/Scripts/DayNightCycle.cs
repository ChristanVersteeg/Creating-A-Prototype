using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(1, 0, 0);
    }
}