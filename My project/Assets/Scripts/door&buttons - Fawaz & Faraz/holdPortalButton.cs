using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holdPortalButton : MonoBehaviour
{

    // vairables
    public endOfLevel portal;
    public SpriteRenderer button;
    public AudioClip portalButtonPress;
    public bool isButtonOn = false;
    public Color on;
    public Color off;
    private void Start()
    {
        if (isButtonOn == false) //checks if the bool "isButtonOn" is false to run the code below 
        {
            button.color = off; // will turn off the color on the button sprite 
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) // makes a collider 
    {
        if(collision.CompareTag("Player") || collision.CompareTag("pet box") || collision.CompareTag("box")) //the collider will check if a player or a pet or a box to enter it 
        {
            AudioSource.PlayClipAtPoint(portalButtonPress,transform.position); // Sound effect will play at that the position of the button 
            isButtonOn = true; // will turn the bool to true 
            portal.portalOn = true;
            button.color = on; // will turn on the button color to 
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("pet box") || collision.CompareTag("box")) //the collider will check if a player or a pet or a box to exit it 
        {
            AudioSource.PlayClipAtPoint(portalButtonPress,transform.position); // Sound effect will play at that the position of the button 
            isButtonOn = false; // will turn the bool to true
            portal.portalOn = false;
            button.color = off; // will turn off the button color to 
        }
    }
}
