using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeOpenDoor : MonoBehaviour
{
    public door door;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            door.moveDoor = true;
        }
    }
}
