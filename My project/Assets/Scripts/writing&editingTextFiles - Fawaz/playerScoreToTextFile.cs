//Made By Fawaz
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class playerScoreToTextFile : MonoBehaviour
{
    public CoinCounter amountOfCoins;
    public Timer time;
    private float playerScore;
    private string currentPlayerName;
    private string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        currentPlayerName = playerNameToTextFile.currentPlayerPlaying;
        sceneName = SceneManager.GetActiveScene().name;
    }

    public void writePlayerScore()
    {
        calculatePlayerScore();
        File.AppendAllText(currentPlayerName, sceneName + ": " + playerScore + "\n");
    }
    public void calculatePlayerScore()
    {
        playerScore = (amountOfCoins.currentNumberOfCoinsCollected / time.timer) * 100f;
    }
}
