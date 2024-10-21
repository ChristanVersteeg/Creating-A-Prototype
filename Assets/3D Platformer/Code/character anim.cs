using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characteranim : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private int isWalkingHash, isRunningHash;

    private void Start()
    {
        isWalkingHash = Animator.StringToHash("ISWALKING");
        isRunningHash = Animator.StringToHash("ISRUNNING");
        print(isWalkingHash);
        print(isRunningHash);


    }
    private void Update()
    {
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);

        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);

        if (!isWalking && forwardPressed)
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (isWalking && !forwardPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }

        if (!isRunning && (forwardPressed && runPressed))
        {
            animator.SetBool(isRunningHash, true);
        }

        if (isRunning && (!forwardPressed || !runPressed))
        {

            animator.SetBool(isRunningHash, false);
        }
    }
}
