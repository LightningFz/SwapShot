using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fasterPet : MonoBehaviour
{
    public followPlayer pet;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
        }
    }
    void Pickup()
    {
        pet.speed = pet.speed * 1.5f;
        Destroy(gameObject);
    }
}
