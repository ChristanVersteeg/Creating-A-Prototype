using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Player_L4 : MonoBehaviour
{
    //Player Health
    private int health = 10;
 
    //Number of coins collected
    private int coins;
 
    //The Fireball prefab and the Transform parameter of the attack point
    public GameObject fireballPrefab;
    public Transform attackPoint;
 
    //A method that lowers the player's health
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Player's health: " + health);
    }
 
    //Method that increases the number of coins
    public void CollectCoins()
    {
        coins++;
print("Collected coins: " + coins);
    }
 
    void Update()
    {
 
        //If the player clicks the left mouse button, a fireball is created
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
 
    }
}