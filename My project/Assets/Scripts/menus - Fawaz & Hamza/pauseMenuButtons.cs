// made by Fawaz

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
    this class is used to make the pause menu in the game
    when you press escape in the game it will pop up the pause menu
 */
public class pauseMenuButtons : MonoBehaviour
{

    //variables that can be accessed from anywhere in the game
    public static bool GameIsPaused = false;
    public static bool endOfLevelMenuActive = false;
    public GameObject pauseMenuUI; 

    //the gameobject of the pause menu
    //public GameObject pauseMenuUI;
    /*
    // Update is called once per frame
    void Update()
    {
        //check for any inputs from the player
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (GameIsPaused == true && endOfLevelMenuActive == false)
            {
                resumeGame();
            }
            else
            {
                pauseGame();
            }
        }
    }
    */
    //resume the game when called
    public void resumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    //pause the game when called
    void pauseGame()
    {
        if (endOfLevelMenuActive == false)
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
    }

    //load the next level when called
    public void loadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    //load the home screen when called
    public void loadHomeScreen()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    //quit the game when called
    public void quitGame()
    {
        Debug.Log("Quit game....");
        Application.Quit();
    }
    //reload the current level
    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
  
}
