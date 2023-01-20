using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan : MonoBehaviour
{   // variables 
    public bool fanOn = false;
    public bool fanDirection = false; 
    public int direction = 1; // the direction the fan will be aim in to push the player 
    public int fanPower = 5; // How Strong the fan will be pushing the player 

    // Checks if the player has entered the collider on the fan 
    void OnTriggerStay2D(Collider2D other) {
        if (other.CompareTag("Player")) // Checks if a box has entered the collider on the fan if so will run the code under
        {
            if (fanOn == true) //Will check if the variable "FanOn" is True 
            {
                other.GetComponent<Rigidbody2D>().AddForce(Vector2.right * fanPower * direction); // Gets the rigibody component for the fan and adds force to it on the x axis using the "Fanpower" variable 
            }
        }
        if (other.CompareTag("box")) // Checks if a box has entered the collider on the fan if so will run the code under
        {
            if (fanOn == true)  //Will check if the variable "FanOn" is True 
            {
                other.GetComponent<Rigidbody2D>().AddForce(Vector2.right * fanPower * direction, ForceMode2D.Impulse); // Gets the rigibody component for the box and adds force to it on the x axis using the "Fanpower" variable 
            }
        }
    }
}


    
