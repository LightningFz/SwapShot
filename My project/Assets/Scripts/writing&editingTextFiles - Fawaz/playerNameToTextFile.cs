using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class playerNameToTextFile : MonoBehaviour
{
    public InputField InputField;
    void Start()
    {
        //create a folder
        Directory.CreateDirectory(Application.streamingAssetsPath + "/textFiles/");
    }

    public void createTextFile()
    {
        //checking if the input field is empty or not, if empty then exit the method
        if (InputField.text == "")
        {
            return;
        }

        //create the text file at the directory that was created in the start method 
        string textFileName = Application.streamingAssetsPath + "/textFiles/" + "playerName" + "txt";

        //check to make sure that the text file doesn't exist already
        if (!File.Exists(textFileName))
        {
            //we are going to add a header inside the text file
            File.WriteAllText(textFileName, "Player Name\n\n");

        }

        File.AppendAllText(textFileName, InputField.text + "\n");

    }
}
