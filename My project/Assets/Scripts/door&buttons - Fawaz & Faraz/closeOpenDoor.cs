// made by Faraz

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    this script is made for a game object thats used as a button, when a box or a player step on a button it class the open or close door function depending on the doors current position 
*/ 
public class closeOpenDoor : MonoBehaviour
{
    // vairables
    public door door; // references the door script

    // this method is called when a game object collides with the trigger area 
    private void OnTriggerEnter2D(Collider2D gameObjects) //paramater that refers to the object that collides with the trigger, in this situation the objects can be either the player or the box
    {

        // checks if the object that collided with the trigger has the "Player" or the "Box" tag, if true the move door vairable is set to true
        if (gameObjects.CompareTag("Player")|| gameObjects.CompareTag("box"))
        {
            door.moveDoor = true;
        }
    }
}
