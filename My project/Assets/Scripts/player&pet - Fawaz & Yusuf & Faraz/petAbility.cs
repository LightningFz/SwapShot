//made by Yusuf

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    this class controls the collison of the player as well as the range and the teleporting of the pet with the box
 */
public class petAbility : MonoBehaviour
{
    
    //variables
    public petShooting pet;
    public Transform player;
    private Vector3 x;

    //called when something collides with the trigger 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("pet box") && pet.petBeingShoot == true)
        {
            teleport(collision);
            pet.currentPetRange = 0;//resit the pet range
        }
    }
    //switch positions between the player and the "petBox"
    void teleport(Collider2D petBox)
    {
        x = player.transform.position;
        player.transform.position = petBox.transform.position;
        petBox.transform.position = new Vector3(x.x, x.y + 3, x.z);

    }
}
