using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class endOfLevel : MonoBehaviour
{
    //variables 
    public GameObject endOflevelMenu;
    public SpriteRenderer portal;
    public hoverEffect hoverEffect;
    public bool portalOn = true;
    public Color on;
    public Color off;
    public AudioClip levelEnd;
    private void OnTriggerEnter2D(Collider2D collision) // Makes a Collider
    {
        if (collision.CompareTag("Player") && portalOn == true) //checks if the player enters the Collider and "portalOn" is true 
        {
            AudioSource.PlayClipAtPoint(levelEnd,transform.position); //plays a sound effect at the position of the portal 
            endOflevelMenu.SetActive(true);
            Time.timeScale = 0f;
            levelMenus.GameIsPaused = true;
            levelMenus.endOfLevelMenuActive = true;
        }
    }
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
