using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class NPC_L2 : MonoBehaviour
{
    //NPC Health
    public int health = 5;
 
    //NPC Level
    public int level = 1;
 
    //NPC Speed
    public float speed = 1.2f;
 
    void Start()
    {
        health = health + level;
        print("Lives: " + health);
    }
 
    void Update()
    {
        //Creating a Vector3-type variable and save the NPC position in it
        Vector3 newPosition = transform.position;
 
        //Changing the position of the NPC on the Z axis according to the speed of the NPC and the time between frames
        newPosition.z += speed * Time.deltaTime;
 
        //Changing the NPC position to the new value calculated above
        transform.position = newPosition;
    }
}