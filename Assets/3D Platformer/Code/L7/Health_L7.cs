using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Health_L7 : MonoBehaviour
{
    //Current player health
    public int currenthealth = 10;
    //Maximum player Health
    public int maxHealth = 10;
    //The component responsible for playing sounds
    public AudioSource audioSource;
    //Sound file containing the damage sound effect
    public AudioClip damageSound;
    //The method that processes the damage done
    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
 
        // If there is still health, then the sound of damage is played
        if (currenthealth > 0)
        {
            audioSource.PlayOneShot(damageSound);
        }
        //If there is no health, then the current scene is restarted
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}