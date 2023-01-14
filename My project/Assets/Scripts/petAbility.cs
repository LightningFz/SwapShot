using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petAbility : MonoBehaviour
{
    public petShooting pet;
    public Transform player;
    private Vector3 x;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("pet box") && pet.petBeingShoot == true)
        {
            teleport(collision);
            pet.currentPetRange = 0;
        }
    }
    void teleport(Collider2D petBox)
    {
        x = player.transform.position;
        player.transform.position = petBox.transform.position;
        petBox.transform.position = new Vector3(x.x, x.y + 3, x.z);

    }
}
