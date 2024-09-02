using MyWorld;
using UnityEngine;

namespace MyWorld
{
    public static class World
    {
        public static string worldString;
    }
}


public class Example : MonoBehaviour
{
    private void Update()
    {
        World.worldString = "NewWorld";
        print("Ran Update!");
    }
    private void Start()
    {
        print("Ran Start!");
    }

    private void Awake()
    {
        print("Ran Awake!");
    }
}