using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public float speed = 5f;
    public bool canRun = true;
    public bool isRunning;
    public float runSpeed = 9f;
    float targetMovingSpeed;

    public KeyCode runningKey = KeyCode.LeftShift;

    private Rigidbody playerRigidbody;

    void Awake()
    {
        //Getting a reference to the Rigidbody component of the object to which this script is attached 
        playerRigidbody = this.GetComponent<Rigidbody>();
    }

    private void Start()
    {
        //Hides the cursor at the beginning of the game
        Cursor.visible = false;
    }

    void FixedUpdate()
    {
        //Checking that the running mechanics are enabled and the left Shift is held down
        //Short entry: isRunning = canRun && Input.GetKey(runningKey);
        if (canRun && Input.GetKey(runningKey))
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }

        //Updating the target speed depending on the fulfilled condition
        //Short entry: targetMovingSpeed = isRunning ? runSpeed : speed;
        if (isRunning)
        {
            targetMovingSpeed = runSpeed;
        }
        else
        {
            targetMovingSpeed = speed;
        }

        //Speed increase
        playerRigidbody.velocity = transform.rotation * new Vector3(Input.GetAxis("Horizontal"), playerRigidbody.velocity.y,
             Input.GetAxis("Vertical") * targetMovingSpeed);

        //Rotating an object in place
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * (100f * Time.deltaTime), Space.Self);
    }
}
