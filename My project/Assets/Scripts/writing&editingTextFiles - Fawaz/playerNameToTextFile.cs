//Made by Fawaz  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;
/*
    This class creates text files to save the score that has been obtained by the player.
    It also creates a text file for each player that is used to save all his progress and scores on. 
    All of this is saved in a new directory that will be created when that game starts
 */
public class playerNameToTextFile : MonoBehaviour
{
    //This variable refers to the UI element that takes the player input.
    public InputField InputField;

    //This is a global variable that can be accessed from any script, it stores the name of the current player.
    public static string currentPlayerPlaying;

    //on the start of the game this medthod will create an empty directory that will save all the text files
    void Start()
    {
        //create a folder
        Directory.CreateDirectory(Application.streamingAssetsPath + "/textFiles/");
    }
    //this medthod creates text files that has the list of players that have their score/progress saved in the game
    public void createTextFile()
    {
        //checking if the input field is empty or not, if empty then exit the method
        if (InputField.text == "")
        {
            return;
        }

        //create the text file at the directory that was created in the start method 
        string listOfPlayersNames = Application.streamingAssetsPath + "/textFiles/" + "playerName" + ".txt";

        //check to make sure that the text file doesn't exist already
        if (!File.Exists(listOfPlayersNames))
        {
            //we are going to add a header inside the text file
            File.WriteAllText(listOfPlayersNames, "Players Names\n\n");

        }

        //create a text file for the current player, so that we can keep track of his score
        string currentPlayerName = Application.streamingAssetsPath + "/textFiles/" + InputField.text + ".txt";

        //saving the name of the current player that is playing the game in a public string 
        currentPlayerPlaying = currentPlayerName;

        //check to make sure that this player doesn't have a text file already
        if (!File.Exists(currentPlayerName))
        {
            File.WriteAllText(currentPlayerName, "Player name: " + InputField.text + "\n");
        }
        
        //any text that is still in the input field will be sent to the log
        File.AppendAllText(listOfPlayersNames, InputField.text + "\n");
    }
}
