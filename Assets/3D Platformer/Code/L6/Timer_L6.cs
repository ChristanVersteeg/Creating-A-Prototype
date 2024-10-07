using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
 
public class Timer_L6 : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TextMeshProUGUI timerText;
 
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
 
        //Rounding the value of seconds to integers to display them on the screen
        int roundSeconds = Mathf.RoundToInt(seconds);
        timerText.text = minutes + ":" + roundSeconds;
    }
}