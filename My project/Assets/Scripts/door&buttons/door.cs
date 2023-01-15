using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public bool doorClosed;
    public bool moveDoor = false;

    public Transform Door;
    public Vector3 DoorScale;
    // Start is called before the first frame update
    void Start()
    {
        DoorScale = Door.localScale;
        if(DoorScale.y == 1)
        {
            doorClosed = true;
        } 
        else if (DoorScale.y == 0)
        {
            doorClosed = false;
        }
        else
        {
            DoorScale = new Vector3(DoorScale.x, 1, DoorScale.z);
            Door.localScale = DoorScale;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(doorClosed == false && DoorScale.y <= 0)
        {
            closeDoor();
        }
        else if (doorClosed == true && DoorScale.y >= 1)
        {
            openDoor();
        }
    }
    void closeDoor()
    {
        if(moveDoor == true)
        {
            DoorScale = new Vector3(DoorScale.x, 1, DoorScale.z);
            Door.localScale = DoorScale;
            doorClosed = true;
            moveDoor = false;
        }
    }
    void openDoor()
    {
        if(moveDoor == true)
        {
            DoorScale = new Vector3(DoorScale.x, 0, DoorScale.z);
            Door.localScale = DoorScale;
            doorClosed = false;
            moveDoor = false;
        }
    }
}
