using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class endOfLevel : MonoBehaviour
{
    public GameObject endOflevelMenu;
    public SpriteRenderer portal;
    public hoverEffect hoverEffect;
    public bool portalOn = true;
    public Color on;
    public Color off;
    public AudioClip levelEnd;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && portalOn == true)
        {
            AudioSource.PlayClipAtPoint(levelEnd,transform.position);
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
