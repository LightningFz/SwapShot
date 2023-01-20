using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superJump : MonoBehaviour
{
    public AudioClip powerUpSound;
    // this method is called when a game object collides with the trigger area 
    void OnTriggerEnter2D(Collider2D player) //paramater that refers to the object that collides with the trigger, in this situation the object is the player
    {
        // checks if the object that collided with the trigger has the "Player" tag, if true the pickup method is called
        if (player.CompareTag("Player"))
        {
            Pickup(player); // we are passing the refernce of the player to the pick up method 
        }
    }
    // this method changes the jump power of the player to 800
    void Pickup(Collider2D player)
    {
        AudioSource.PlayClipAtPoint(powerUpSound,transform.position);
        // this referring to the movement script of the player
        movement playerJump = player.GetComponent<movement>();

        // this sets the jump power viarable in the movement script to 800
        playerJump.jumpPower = 800f;

        // this removes the powerup game object from the scene
        Destroy(gameObject);
    }
}
