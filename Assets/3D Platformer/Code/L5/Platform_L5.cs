using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Platform_L5 : MonoBehaviour
{
    //Platform movement speed
    public float speed;
    //Direction of movement of the platform
    public Vector3 direction;
    //Platform status: Active / inactive
    public bool isActive;
 
    //Updating the platform movement every frame
    void Update()
    {
 
        if (isActive)
        {
 
            transform.position += direction * speed * Time.deltaTime;
        }
    }
 
    //Platform collision with two types of objects
    void OnTriggerEnter(Collider other) {
        /*If the platform reaches a stop point, it changes direction
        your movement*/
        if (other.tag == "PlatformStop")
        {
            direction *= -1;
        }
        //If the platform is touched by a player, it is activated
        if(other.tag == "Player")
        {
            isActive = true;
        }
    }
 
    void OnTriggerExit(Collider other) {
       //If a player has left the platform, it is deactivated
        if (other.tag == "Player")
        {
            isActive = false;
        }
    } 
 
}