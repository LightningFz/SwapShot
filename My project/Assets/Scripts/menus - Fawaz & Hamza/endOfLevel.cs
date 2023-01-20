// made by Hamza

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endOfLevel : MonoBehaviour
{

    //variables 
    public GameObject endOflevelMenu; //the end of the level menu
    public SpriteRenderer portal; //the sprite of the portal
    public hoverEffect hoverEffect; //hover effect script
    public bool portalOn = true;
    public Color on; //color for the portal when it is on
    public Color off;//color for the portal when it is off
    public AudioClip levelEnd; // this is sound effect
    private void OnTriggerEnter2D(Collider2D collision) // Makes a Collider
    {
        if (collision.CompareTag("Player") && portalOn == true) //checks if the player enters the Collider and "portalOn" is true 
        {
            AudioSource.PlayClipAtPoint(levelEnd,transform.position); //plays a sound effect at the position of the portal 

            //pause the game
            endOflevelMenu.SetActive(true);
            Time.timeScale = 0f;
            levelMenus.GameIsPaused = true;
            levelMenus.endOfLevelMenuActive = true;
        }
    }
    //called evey frame, checks if on or off to change the color of the portal and to also activate the hover effect
    private void Update()
    {
        if (portalOn == false) 
        {
            hoverEffect.amplitude = 0;
            portal.color = off;
        } else if (portalOn == true)
        {
            hoverEffect.amplitude = 0.2f;
            portal.color = on;
        }
    }
}
