//made by Fawaz
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
/*
    This class reads the player's score on each level he played. 
    This information is obtained from a text file that stores the current 
    player's score on all levels. The data is then displayed in a score 
    board (a UI element) located in the game's start menu. 
*/
public class readPlayerScoreTextFile : MonoBehaviour
{
    //UI element of the score board 
    public UnityEngine.UI.Text scoreBoard;

    //the path of the text file of the current player 
    private string currentPlayerName;
    // Start is called before the first frame update
    void Start()
    {
        //getting and storing the path to the text file of the current player 
        currentPlayerName = playerNameToTextFile.currentPlayerPlaying;
    }

    // Update is called once per frame
    void Update()
    {
        //read the data that has been stored on the text file of the current player 
        scoreBoard.text = File.ReadAllText(currentPlayerName).ToString();
    }
}
