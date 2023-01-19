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
        if (isButtonOn == false)
        {
            button.color = off;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") || collision.CompareTag("pet box") || collision.CompareTag("box"))
        {
            AudioSource.PlayClipAtPoint(portalButtonPress,transform.position);
            isButtonOn = true;
            portal.portalOn = true;
            button.color = on;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("pet box") || collision.CompareTag("box"))
        {
            AudioSource.PlayClipAtPoint(portalButtonPress,transform.position);
            isButtonOn = false;
            portal.portalOn = false;
            button.color = off;
        }
    }
}
