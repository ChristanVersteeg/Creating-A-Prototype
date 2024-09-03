using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    Vector3

    //NPC Health
    public int Health = 10;

    //NPC Level
    public int Level = 5;

    //NPC Speed
    public float Speed = 1.2f;

    void Start()
    {
        newPosition.z +=
            Speed * Time.deltaTime;





    }






        

}
