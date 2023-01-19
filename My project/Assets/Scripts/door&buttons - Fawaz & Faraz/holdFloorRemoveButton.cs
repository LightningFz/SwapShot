using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holdFloorRemoveButton : MonoBehaviour
{
    // vairables
    public GameObject floor; // references the door script

    // Start is called before the first frame update
    void Start()
    {
        floor.SetActive(true); // sets the doorClosed vairable to true when the game starts
    }


    // this method is called when a game object collides with the trigger area 
    private void OnTriggerEnter2D(Collider2D gameObjects) //paramater that refers to the object that collides with the trigger, in this situation the objects can be either the player or the box
    {

        // checks if the object that collided with the trigger has the "Player" or the "Box" tag
        if (gameObjects.CompareTag("Player")|| gameObjects.CompareTag("box")||gameObjects.CompareTag("pet box"))
        {
            floor.SetActive(false);
        }
    }

    // this method is called when a game object collides with the trigger area 
    private void OnTriggerExit2D(Collider2D gameObjects) //paramater that refers to the object that collides with the trigger, in this situation the objects can be either the player or the box
    {
         // checks if the object that collided with the trigger has the "Player" or the "Box" tag
        if (gameObjects.CompareTag("Player")|| gameObjects.CompareTag("box") || gameObjects.CompareTag("pet box"))
        {
            floor.SetActive(true);
        }
    }
}
