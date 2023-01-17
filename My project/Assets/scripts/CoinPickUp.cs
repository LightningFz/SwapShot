using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    
    public int value;

    void OnTriggerEnter2D(Collider2D c2d)
    {

        if (c2d.CompareTag("Player"))
        {
           
            
            CoinCounter.instance.IncreaseCoins(value);
            Destroy(gameObject);

        }
    }
}