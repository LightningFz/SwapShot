using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Void : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision) // makes a colldider 
    {
        if (collision.CompareTag("Player")){ // check if the colldider comes with an object named "player" is so will run the code below 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // will load the scene (level) again 
        }
    }
}
