using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    public door door;
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
}
