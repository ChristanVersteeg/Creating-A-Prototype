using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins;

    public int CollectCoin(int amount)
    {
        coins += amount;

        print($"Collected a total of {coins} coins!");

        return coins;
    }
}