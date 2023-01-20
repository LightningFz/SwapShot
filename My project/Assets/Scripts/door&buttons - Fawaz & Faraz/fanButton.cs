using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanButton : MonoBehaviour
{

    // vairables
    public fan fn; //refrences the fan script

    // this method is called when a game object collides with the trigger area 
    void OnTriggerEnter2D(Collider2D gameObjects) //paramater that refers to the object that collides with the trigger, in this situation the objects can be either the player or the box
    {

        // checks if the object that collided with the trigger has the "Player" or the "Box" tag, if true the switch method is called
        if (gameObjects.CompareTag("Player")|| gameObjects.CompareTag("box"))
        {
            Switch();
        }
    }
    void Switch()
    {
        // when the switch method is called, this checks if the fanOn vairable is true or false, if its false it switches it to true and vice versa
        if (fn.fanOn == false)
        {
            fn.fanOn = true;
        }
        else if (fn.fanOn == true)
        {
            fn.fanOn = false;
        }
    }
    

}
