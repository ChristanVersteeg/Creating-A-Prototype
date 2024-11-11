using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class WizardMotion : MonoBehaviour
{
    public Animator animator;
 
    void Update()
    {
        //Changing the values of the velX and velY parameters according to the values entered by the user
        animator.SetFloat("velX", Input.GetAxis("Horizontal"), 0.1f, Time.deltaTime);
        animator.SetFloat("velY", Input.GetAxis("Vertical"), 0.1f, Time.deltaTime);
    }
}
