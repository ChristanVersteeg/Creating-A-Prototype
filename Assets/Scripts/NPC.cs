using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{


    //NPC Health
    public int Health = 10;

    //NPC Level
    public int Level = 5;

    //NPC Speed
    public float Speed = 1.2f;



    void Start()

    {


    }


    private void Update()
    {

       Vector3 newPosition =transform.position;
        newPosition.y += Speed * Time.deltaTime;
        transform.position = newPosition;
    }



}
