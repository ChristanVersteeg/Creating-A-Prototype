using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Trampoline_L3 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //Increase jump strength
        other.GetComponent<Jump>().jumpStrength = 10;
 
    }
 
    void OnTriggerExit(Collider other)
    {
        //Reduction of jump strength
        other.GetComponent<Jump>().jumpStrength = 2;
 
    }
}