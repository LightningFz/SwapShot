// made by Faraz

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
    this script is used to open or close the door
    the method openDoor and closeDoor are run whenever the boolean doorClosed is changed from true to false or vice versa
    this script is connected to all the scripts that are labled closeDoor, closeOpenDoor, holdOpenDoor, and openDoor
    which change the boolean doorClose depending on the script in question.
*/ 
public class door : MonoBehaviour
{
    // vairables
    public bool doorClosed;
    public bool moveDoor = false;
    public Transform Door; // refrences the transform component from the game object door
    public Vector3 doorScale; // The scale that controls the door's size will be in responsible of opening and closing the door.

    // Start is called before the first frame update
    void Start()
    {
        //this is to make sure there are no errors when the scene starts

        doorScale = Door.localScale; // sets the doorScale equal to the Scale vairable inside the transform component
        
        // checks to see if the door scale is set to a size, if so it sets the doorClosed vairable to true
        if(doorScale.y == 1)
        {
            doorClosed = true;
        } 
        // if the door scale is set to 0, it sets the doorClosed vairable to false
        else if (doorScale.y == 0)
        {
            doorClosed = false;
        }
        
        // checks to see if the door is set to something other than 1 or 0, if it is it sets the scale to 1 since that's the max size
        else
        {
            doorScale = new Vector3(doorScale.x, 1, doorScale.z);
            Door.localScale = doorScale;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        //this checks the vairables doorClosed and the doorScale in order to call the 2 methods closeDoor or openDoor

        // checks to see if the doorClosed vairable is false and if the doorScale is set to 0, if so it calls the closeDoor method
        if(doorClosed == false && doorScale.y <= 0)
        {
            closeDoor();
        }
        // checks to see if the doorClosed vairable is true and if the doorScale is set to 1, if so it calls the openDoor method
        else if (doorClosed == true && doorScale.y >= 1)
        {
            openDoor();
        }
    }

    // this method is for closing the door
    void closeDoor()
    {
        // this checks if the moveDoor vairable is set to true, if so it sets the doorScale to 1, sets doorClosed to true, and sets moveDoor to false
        if(moveDoor == true)
        {
            doorScale = new Vector3(doorScale.x, 1, doorScale.z);
            Door.localScale = doorScale;
            doorClosed = true;
            moveDoor = false;
        }
    }

    // this method is to open the door
    void openDoor()
    {
        
        // this checks if the moveDoor vairable is set to true, if so it sets the doorScale to 0, sets doorClosed to false, and sets moveDoor to false
        if(moveDoor == true)
        {
            doorScale = new Vector3(doorScale.x, 0, doorScale.z);
            Door.localScale = doorScale;
            doorClosed = false;
            moveDoor = false;
        }
    }
}
