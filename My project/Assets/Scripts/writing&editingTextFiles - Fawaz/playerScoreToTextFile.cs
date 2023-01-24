//Made By bilal
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
/*
   This class calculates the player's score in each level by dividing the number 
    of coins obtained by the time and then multiplying the result by 100 so that it 
    does not appear to be a small number. The score and level name will then be saved 
    in a text file of the current player playing.
 */
public class playerScoreToTextFile : MonoBehaviour
{
    //variables 
    //this variable is referring to the script of the coint counter wich has a variable of the number of coins 
    public CoinCounter amountOfCoins;

    //this variable is referring to the script of the timer that hasa a variable that keeps track of time
    public Timer time;

    //this variable is used to store the score that the player got in the current level
    private float playerScore;

    //this variable stores the path and the name of the text file that is used to store the score of the current player
    private string currentPlayerName;

    //this variable is used to store the number/name of the current level
    private string sceneName;


    // Start is called before the first frame update
    void Start()
    {
        //getting and storing the variable that stores the path for the text file of the current player 
        currentPlayerName = playerNameToTextFile.currentPlayerPlaying;

        //getting and storing the number/name of the current level
        sceneName = SceneManager.GetActiveScene().name;
    }

    //this method edits the text file fo the player by adding his score on the current level 
    public void writePlayerScore()
    {
        //call the method thta calculate the player score 
        calculatePlayerScore();

        //edit the text file of the current player by adding his score on this level
        File.AppendAllText(currentPlayerName, sceneName + ": " + playerScore + "\n");
    }

    //this method is used to calculate the score of the player in the current level according  to the amount of coins he got and the time it took him to finish the level 
    public void calculatePlayerScore()
    {
        playerScore = (amountOfCoins.currentNumberOfCoinsCollected / time.timer) * 100f;
    }
}
