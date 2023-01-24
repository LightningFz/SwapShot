// made by Hamza

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
    this class controls all the buttons and all the designs of the start menu
 */
public class startMenu : MonoBehaviour
{

    //variable
    public int numberOfLevels = 3;

    //load first level
    public void loadFirstLevel()
    {
        SceneManager.LoadScene(1);
    }
    //Load levels menu
    public void loadLevelsMenu()
    {
        SceneManager.LoadScene(numberOfLevels + 1);
    }
    //load settings menu
    public void loadSettingsMenu()
    {
        SceneManager.LoadScene(numberOfLevels + 2);
    }
    //load credits menu
    public void loadCreditsMenu()
    {
        SceneManager.LoadScene(numberOfLevels + 3);
    }
    //reload the current level
    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    //quit the game
    public void quitGame()
    {
        Debug.Log("Quit game....");
        Application.Quit();
    }
}
