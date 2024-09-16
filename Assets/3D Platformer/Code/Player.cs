using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins;
    private int health = 10;

    public void TakeDamage(int damage)
    {
        health -= damage;

        print($"You took damage! Your health is now {health}!");
    }

    public int CollectCoin(int amount)
    {
        coins += amount;

        print($"Collected a total of {coins} coins!");

        return coins;
    }
}