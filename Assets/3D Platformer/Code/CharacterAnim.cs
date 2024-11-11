using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    public Animator animator;
    private int isWalkingHash, isRunningHash, isJumpingHash, isAttackingHash;

    private void Start()
    {
        //We get the ID of the required parameters — this way we will save time on searching for them
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isJumpingHash = Animator.StringToHash("isJumping");
        isAttackingHash = Animator.StringToHash("isAttacking");
    }

    private void Update()
    {
        //We get their Boolean values from the parameter IDs
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isJumping = animator.GetBool(isJumpingHash);
        bool isAttacking = animator.GetBool(isAttackingHash);

        //We get Boolean values for the result of checking the player's input
        bool forwardPressed = Input.GetKey("w");
        bool backwardPressed = Input.GetKey("s");
        bool runPressed = Input.GetKey("left shift");
        bool jumpPressed = Input.GetKey("space");
        bool attackClick = Input.GetMouseButtonDown(0);

        // If the player is not walking And the W key is pressed, then turn on the walking animation
        if (!isWalking && forwardPressed || backwardPressed)
        {
            animator.SetBool("isWalking", true);
        }

        // If the player is walking And the W key is not pressed, then turn off the walking animation
        if (isWalking && !forwardPressed || !backwardPressed)
        {
            animator.SetBool("isWalking", false);
        }

        // If the player is not running And the left shift And W are held down, then turn on the running animation
        if (!isRunning && (forwardPressed && runPressed))
        {
            animator.SetBool("isRunning", true);
        }

        // If the player is running And the left shift OR W is not held down, then turn off the running animation
        if (isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool("isRunning", false);
        }

        // If the player does not jump And the space bar is held down, then turn on the jump animation
        if (!isJumping && jumpPressed)
        {
            animator.SetBool("isJumping", true);
        }

        // If the player jumps And the space bar is not held down, then turn off the jump animation
        if (isJumping && !jumpPressed)
        {
            animator.SetBool("isJumping", false);
        }

        // If the player does not attack And pressed the left mouse button, then turn on the attack animation
        if (!isAttacking && attackClick)
        {
            animator.SetBool("isAttacking", true);
        }

        // If the player attacks And has not pressed the left mouse button, then turn off the attack animation
        if (isAttacking && !attackClick)
        {
            animator.SetBool("isAttacking", false);
        }
    }
}
