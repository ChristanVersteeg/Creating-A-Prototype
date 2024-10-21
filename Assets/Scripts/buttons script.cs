using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonsscript : MonoBehaviour
{

    [SerializeField] private Animator animator;
    [SerializeField] private Animator openDoor;
   

    private void OpenDoor()
    {
        openDoor.enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.enabled = true;
        Invoke(nameof(OpenDoor), 1);
    }
}
