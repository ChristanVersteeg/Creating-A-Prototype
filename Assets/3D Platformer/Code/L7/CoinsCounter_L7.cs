using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CoinsCounter_L7 : MonoBehaviour
{
    //Number of coins collected
    public int coins;
 
    //Method that increases the number of coins
    public void CollectCoins()
    {
        coins++;
    }
}