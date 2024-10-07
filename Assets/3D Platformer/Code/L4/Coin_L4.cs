using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Coin_L4 : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {

        Player_L6 player = other.GetComponent<Player_L6>();
 
        //The number of coins is updated
        player.CollectCoins();
 
        //The coin that was collected is destroyed
        Destroy(gameObject);
    }
 
}

