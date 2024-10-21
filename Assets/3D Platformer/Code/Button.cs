using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Animator openDoor;

    private void OpenDoor()
    {
        openDoor.enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        print(animator.runtimeAnimatorController);
        animator.enabled = true;
        Invoke(nameof(OpenDoor), 1);
    }
}