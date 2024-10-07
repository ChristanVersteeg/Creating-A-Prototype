using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Timer_L5 : MonoBehaviour
{
    public int minutes;
    public float seconds;
 
    // The update cycle is approximately 0.01 seconds
    void Update()
    {
        seconds -= Time.deltaTime;
 
        if (seconds <= 0)
        {
            if (minutes > 0)
            {
                seconds += 59;
 
                minutes--;
            }
            else
            {
                // If the timer has stopped, reload the current scene
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }
    }
}