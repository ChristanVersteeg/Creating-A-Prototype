using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Coin_L7 : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
 
        CoinsCounter_L7 coins = other.GetComponent<CoinsCounter_L7>();
 
        //The number of coins is updated
        coins.CollectCoins();
 
        //The coin that was collected is destroyed
        Destroy(gameObject);
    }
}