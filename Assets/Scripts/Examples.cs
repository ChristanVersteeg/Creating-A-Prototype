#define EXAMPLE_1

using UnityEngine;

public class Examples : MonoBehaviour
{
#if EXAMPLE_0
    private void Start()
    {
        print(What is wrong with me?)
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

        health = health + level;
        print("Player health:" + health);
        //print($"Player health: {health}");

    }
    private void PrintFirst() 
    {
        print("Printing the print first!");

        int health = 3;
        int level = 2;

        print("Player health:" + health);
        //print($"Player health: {health}");
        health = health + level;
    }

    [ContextMenu(nameof(Start))]
    private void Start()
    {
        HealthFirst();
        PrintFirst();
    }
#endif
}