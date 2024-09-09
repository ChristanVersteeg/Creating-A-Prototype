using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedtrigger : MonoBehaviour
{
    [SerializeField]
    float speedmultiplayer = 3.50f;
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedmultiplayer;
        
    }
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedmultiplayer;
    }


}