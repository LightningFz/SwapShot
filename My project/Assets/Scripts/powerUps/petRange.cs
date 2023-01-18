using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petRange : MonoBehaviour
{
    public petShooting player;
    public float newPetRange;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
        }
    }
    void Pickup()
    {
        player.petRange = newPetRange;
        Destroy(gameObject);
    }
}
