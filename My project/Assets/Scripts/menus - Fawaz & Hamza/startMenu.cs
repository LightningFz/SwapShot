// made by Hamza

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public void loaCreditsMenu()
    {
        SceneManager.LoadScene(numberOfLevels + 3);
    }
    //quit the game
    public void quitGame()
    {
        Debug.Log("Quit game....");
        Application.Quit();
    }
}
