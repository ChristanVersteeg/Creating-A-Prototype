using System;
using UnityEngine;

public class MoveLetter : MonoBehaviour
{
    private Pose defaultPositionAndRotation;

    private const float forceModifier = 5;

    private int massModifier = 1;
    private static int index;
    private static bool IsControlled => index == _currentIndex;


    private Rigidbody rb;

 
    private void UpdateWeight()
    {
        if (!IsControlled) return;

        if (Input.GetKeyDown(KeyCode.UpArrow)) Mathf.Clamp(rb.mass += massModifier, 1, int.MaxValue);
        else if (Input.GetKeyDown(KeyCode.DownArrow)) Mathf.Clamp(rb.mass -= massModifier, 1, int.MaxValue);
    }

    private void MoveWithKeyInDirection(KeyCode key, Vector3 direction)
    {
        if (!IsControlled) return;

        if (!Input.GetKeyDown(key)) return;

        rb.AddForce(direction * forceModifier, ForceMode.Impulse);
    }

    private void UpdateResetPosition()
    {
        if (!IsControlled) return;
        if (!Input.GetKeyDown(KeyCode.R)) return;

        print("Tried resetting");
        rb.isKinematic = true;
        transform.rotation = defaultPositionAndRotation.rotation;
        transform.position = defaultPositionAndRotation.position;
        rb.isKinematic = false;
    }

    void Start()
    {
        defaultPositionAndRotation.rotation = transform.rotation;
        defaultPositionAndRotation.position = transform.position;
        index = transform.GetSiblingIndex();
        childCount = transform.parent.childCount;
        rb = GetComponent<Rigidbody>();
        rb.mass = 3;
        print(index);
        print(childCount);
    }

    void Update()
    {
        print(CurrentIndex);

        UpdateControl();
        UpdateWeight();
        UpdateResetPosition();

        MoveWithKeyInDirection(KeyCode.W, Vector3.forward);
        MoveWithKeyInDirection(KeyCode.A, Vector3.left);
        MoveWithKeyInDirection(KeyCode.S, Vector3.back);
        MoveWithKeyInDirection(KeyCode.D, Vector3.right);

        MoveWithKeyInDirection(KeyCode.Q, Vector3.down);
        MoveWithKeyInDirection(KeyCode.E, Vector3.up);
    }
}
