using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenu : MonoBehaviour
{
    public int numberOfLevels = 3;
    public void playGame()
    {
        SceneManager.LoadScene(1);
    }
    public void levelsMenu()
    {
        SceneManager.LoadScene(numberOfLevels + 1);
    }
    public void settings()
    {
        SceneManager.LoadScene(numberOfLevels + 2);
    }
    public void credits()
    {
        SceneManager.LoadScene(numberOfLevels + 3);
    }
    public void quitGame()
    {
        Debug.Log("Quit game....");
        Application.Quit();
    }
}
