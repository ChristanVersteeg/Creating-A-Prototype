#define EXAMPLE_3

using UnityEditor;
using UnityEngine;

public class Examples : MonoBehaviour
{
#if EXAMPLE_0
    private void Start()
    {
        int health = 10, maxHealth = 15;
        float speed = 1.2f;
        string greeting = "Hello!";
        bool willPrint = true;

        if (willPrint)
        {
            print("What is wrong with me?");
        }

        int jumpheight; // decleration
        jumpheight = "it is very high"; //assignment
        print(jumpheight);

    }
#endif

#if EXAMPLE_1
    [ContextMenu(nameof(Start))]
    private void Start()
    {
        int health = 3;
        int level = 2;

        health = health + level;
    }
#endif

#if EXAMPLE_3
    private void HealthFirst()
    {
        print("Printing the health first!");

        int health = 3;
        int level = 2;

        health += level;
        print("Player health:" + health);
        //print($"Player health: {health}");



        float speed = 2.1f;
        speed = 3;
    }
    private void PrintFirst()
    {
        print("Printing the print first!");

        int health = 3;
        int level = 2;

        print("Player health:" + health);
        //print($"Player health: {health}");
        health += level;
    }

    [ContextMenu(nameof(Start))]
    private void Start()
    {
        HealthFirst();
        PrintFirst();
    }
#endif
}