using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// This script prints out "Hello World" in the console.
public class HelloWorld : MonoBehaviour
{
    private int speed;

    private void Start()
    {
        int speed = 5;

        print(2);
        print("2");
        print(speed);
        print("speed");
        print("Speed");


        speed += 1;
        print(speed);
    }

    // Update is called once per frame
    private void HotDog()
    {
        speed = 5;
    }

}

public class NoHelloWorld : MonoBehaviour
{
    private void Start()
    {
        //CTRL+S
    }
}