//made by Bilal

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    public AudioClip coinCollect; // the sound effect for the coin pickup 
    public int value = 1; 

    void OnTriggerEnter2D(Collider2D player) // makes a collider 
    {

        if (player.CompareTag("Player")) // will check if a the player would enter the collider 
        {
            AudioSource.PlayClipAtPoint(coinCollect,transform.position); // the sound effect will play at the position of the coin 
            Destroy(gameObject); // the coin will be removed from the game 
            CoinCounter.Instance.IncreaseCoins(value); // the coin counter will go up for each coin found 
        }
        
    }
}