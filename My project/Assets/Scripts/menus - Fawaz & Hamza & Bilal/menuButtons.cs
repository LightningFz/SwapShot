using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelMenus : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool endOfLevelMenuActive = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused == true && endOfLevelMenuActive == false)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }
    public void resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void pause()
    {
        if (endOfLevelMenuActive == false)
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
    }
    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void homeScreen()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void quitGame()
    {
        Debug.Log("Quit game....");
        Application.Quit();
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void changePetColor(petColor petColorScript)
    {
        if (petColorScript.changePetColor == false)
        {
            petColorScript.changePetColor = true;
        }else if (petColorScript.changePetColor == false)
        {
            petColorScript.changePetColor = false;
        }
    }
    public void changeBackgroundColor(backgroundColor backgroundColorScript)
    {
        if (backgroundColorScript.changeBackgroundColor == false)
        {
            backgroundColorScript.changeBackgroundColor = true;
        }
        else if (backgroundColorScript.changeBackgroundColor == false)
        {
            backgroundColorScript.changeBackgroundColor = false;
        }
    }
}
