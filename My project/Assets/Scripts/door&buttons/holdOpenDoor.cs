using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holdOpenDoor : MonoBehaviour
{
    public door door;
    // Start is called before the first frame update
    void Start()
    {
        door.doorClosed = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("pet box") || collision.CompareTag("box"))
        {
            if (door.doorClosed == true)
            {
                door.moveDoor = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("pet box") || collision.CompareTag("box"))
        {
            if (door.doorClosed == false)
            {
                door.moveDoor = true;
            }
        }
    }
}
