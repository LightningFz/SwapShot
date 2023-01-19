using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    public AudioClip coinCollect;
    public int value = 1;

    void OnTriggerEnter2D(Collider2D c2d)
    {

        if (c2d.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(coinCollect,transform.position);
            Destroy(gameObject);
            CoinCounter.Instance.IncreaseCoins(value);
        }
        
    }
}