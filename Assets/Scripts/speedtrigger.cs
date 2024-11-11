using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedtrigger : MonoBehaviour
{
   [SerializeField] float speedMultiplier = 1.5f;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<ThirdPersonMovement>().speed *= speedMultiplier;
        other.GetComponent<ThirdPersonMovement>().runSpeed *= speedMultiplier;
    }

    private void OnTriggerExit(Collider other)
    {

        other.GetComponent<ThirdPersonMovement>().speed /= speedMultiplier;
        other.GetComponent<ThirdPersonMovement>().runSpeed /= speedMultiplier;

    }



}