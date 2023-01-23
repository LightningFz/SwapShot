// made by Fawaz

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateOpenDoor : MonoBehaviour
{
   // vairables
    public door door; // references the door script

    // Start is called before the first frame update
    void Start()
    {
        door.doorClosed = true; // sets the doorClosed vairable to true when the game starts
    }


    // this method is called when a game object collides with the trigger area 
    private void OnTriggerEnter2D(Collider2D gameObjects) //paramater that refers to the object that collides with the trigger, in this situation the objects can be either the player or the box
    {

        // checks if the object that collided with the trigger has the "Player", "box", or "pet box" tags
        if (gameObjects.CompareTag("Player")|| gameObjects.CompareTag("box")||gameObjects.CompareTag("pet box"))
        {

            // checks the doorClosed vairable, if the vairable is set to true it sets the moveDoor vairable to true
            if (door.doorClosed == true)
            {
                door.moveDoor = true;
            }
        }
    }

    // this method is called when a game object collides with the trigger area 
    private void OnTriggerExit2D(Collider2D gameObjects) //paramater that refers to the object that collides with the trigger, in this situation the objects can be either the player or the box
    {
         // checks if the object that collided with the trigger has the "Player" or the "Box" tag
        if (gameObjects.CompareTag("Player")|| gameObjects.CompareTag("box") || gameObjects.CompareTag("pet box"))
        {

            // checks the doorClosed vairable, if the vairable is set to false it sets the moveDoor vairable to true
            if (door.doorClosed == false)
            {
                door.moveDoor = true;
            }
        }
    }
}
