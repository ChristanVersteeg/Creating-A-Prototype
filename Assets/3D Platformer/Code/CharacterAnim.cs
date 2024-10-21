using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    private Animator animator;
    private int isWalkingHash, isRunningHash;

    private void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    private void Update()
    {
        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);

        if (forwardPressed)
        {
            animator.SetBool(isWalkingHash, true);
        }
        else animator.SetBool(isWalkingHash, false);

        if (forwardPressed && runPressed)
        {
            animator.SetBool(isRunningHash, true);
        }
        else animator.SetBool(isRunningHash, false);
    }
}