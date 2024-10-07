using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Player_L6 : MonoBehaviour
{
    //Current player health
    public int health = 10;
    //Maximum player Health
    public int maxHealth = 10;
 
    //Number of coins collected
    public int coins;
 
    //The Fireball prefab and the Transform parameter of the attack point
    public GameObject fireballPrefab;
    public Transform attackPoint;
 
    //The component responsible for playing sounds
    public AudioSource audioSource;
 
    //Sound file containing the damage sound effect
    public AudioClip damageSound;
 
    //The method that processes the damage done
    public void TakeDamage(int damage)
    {
        health -= damage;
 
        // If there is still health, then the sound of damage is played
        if(health > 0)
        {
            audioSource.PlayOneShot(damageSound);
            //print("Player health: " + health);
        }
        //If there is no health, then the current scene is restarted
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
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