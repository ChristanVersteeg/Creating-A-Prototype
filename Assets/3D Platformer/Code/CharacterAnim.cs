using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    public Animator animator;
    private int isWalkingHash, isRunningHash;

    private void Start()
    {
        //We get the ID of the required parameters — this way we will save time on searching for them
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    private void Update()
    {
        //We get their Boolean values from the parameter IDs
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        //We get Boolean values for the result of checking the player's input
        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);

        // If the player is not walking And the W key is pressed, then turn on the walking animation
        if (!isWalking && forwardPressed)
        {
            animator.SetBool(isWalkingHash, true);
        }

        // If the player is walking And the W key is not pressed, then turn off the walking animation
        if (isWalking && !forwardPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }

        // If the player is not running And the left shift And W are held down, then turn on the running animation
        if (!isRunning && (forwardPressed && runPressed))
        {
            animator.SetBool(isRunningHash, true);
        }

        // If the player is running And the left shift OR W is not held down, then turn off the running animation
        if (isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool(isRunningHash, false);
        }
    }
}
