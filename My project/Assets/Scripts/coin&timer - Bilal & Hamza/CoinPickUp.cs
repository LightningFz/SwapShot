//made by Bilal

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 this class checks if the player is in contact with a coin, 
 if the player is in contact it plays the pick up noise, 
 as well as increasing the number of coins using the coin counter script, 
 this class also destroys the game object to act as the "pick up" 
*/
public class CoinPickUp : MonoBehaviour
{
    public AudioClip coinCollect; // the sound effect for the coin pickup 
    public int value = 1; // this is the value of the coin, if the coin value was set to 5 then the coin counter would go up by 5 instead of 1
    
    // this method is called when a game object collides with the trigger area 
    void OnTriggerEnter2D(Collider2D gameObjects) //paramater that refers to the object that collides with the trigger, in this situation the object is the player
    {
        if (gameObjects.CompareTag("Player")) // will check if a the player would enter the collider 
        {
            AudioSource.PlayClipAtPoint(coinCollect,transform.position); // the sound effect will play at the position of the coin 
            Destroy(gameObject); // the coin will be removed from the game to act as a pick up
            CoinCounter.Instance.IncreaseCoins(value); // the coin counter will go up for each coin picked up 
        }
        
    }
}