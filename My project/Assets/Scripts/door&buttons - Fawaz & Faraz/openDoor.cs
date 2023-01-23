// made by Faraz

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    // vairables
    public door door; // references the door script

    // this method is called when a game object collides with the trigger area 
    private void OnTriggerEnter2D(Collider2D gameObjects) //paramater that refers to the object that collides with the trigger, in this situation the objects can be either the player or the box
    {

        // checks if the object that collided with the trigger has the "Player" or the "Box" tag, if true the switch method is called
        if (gameObjects.CompareTag("Player")|| gameObjects.CompareTag("Box"))
        {

            // checks if the door closed vairable from the door script is false, if false it sets the move door vairable to true
            if (door.doorClosed == true)
            {
                door.moveDoor = true;
            }
        }
    }
}
