using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class FireballAttack_L7 : MonoBehaviour
{
    //The Fireball prefab and the Transform parameter of the attack point
    public GameObject fireballPrefab;
    public Transform attackPoint;
 
    void Update()
    {
        //If the player clicks the left mouse button, a fireball is created
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}