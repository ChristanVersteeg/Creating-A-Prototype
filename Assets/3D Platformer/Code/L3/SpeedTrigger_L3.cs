using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class SpeedTrigger_L3 : MonoBehaviour
{
    public float speedFactor = 2.5f;
 
    void OnTriggerEnter(Collider other)
    {
        //Increase in the player's running speed
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }
 
    void OnTriggerExit(Collider other)
    {
        //Decrease the player's running speed
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}