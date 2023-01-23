//made by Fawaz

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    this class controls the pet speed power-up
    when the player picks up this power-up the pet can go faster when being shot
 */
public class fasterPet : MonoBehaviour
{
    // vairables 
    public petFollowPlayer pet;
    public AudioClip powerUpSound;

    // this method is called when a game object collides with the trigger area 
    void OnTriggerEnter2D(Collider2D player) //paramater that refers to the object that collides with the trigger, in this situation the object is the player
    {

        // checks if the object that collided with the trigger has the "Player" tag, if true the pickup method is called
        if (player.CompareTag("Player"))
        {
            Pickup();
        }
    }
    void Pickup()
    {
        AudioSource.PlayClipAtPoint(powerUpSound,transform.position);
        // this sets the pet speed viarable in the pet script to 1.5 times the original 
        pet.speed = pet.speed * 1.5f;

        // this removes the powerup game object from the scene
        Destroy(gameObject);
    }
}
