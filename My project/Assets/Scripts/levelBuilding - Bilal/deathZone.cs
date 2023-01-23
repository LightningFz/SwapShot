// made by Bilal

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
    this class is used to make the death zone
    the death zone is an area that restarts the level if the player collides with it
 */
public class deathZone : MonoBehaviour
{
    //called when a collision is triggered 
    public void OnTriggerEnter2D(Collider2D collision) // makes a colldider 
    {
        if (collision.CompareTag("Player")){ // check if the colldider comes with an object named "player" is so will run the code below 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // will load the scene (level) again 
        }
    }
}
