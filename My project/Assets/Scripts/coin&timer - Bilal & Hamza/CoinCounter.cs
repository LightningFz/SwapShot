// made by Hamzah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

/*
  this class is used to show the amount of coins collected in each level, 
  it uses a counter that increases everytime the player gets in contact with a coin, 
  this class also prints the message on the screen that shows the amount of coins currently collected
*/ 
public class CoinCounter : MonoBehaviour
{
    public static CoinCounter Instance; // This class was turned into a variable that could be accessed from any where in the game.

    public TMP_Text coinText; // the UI element used to display the number of coins
    public int currentNumberOfCoinsCollected = 0; // the integer that holds the number of coins currently collected

    //this is called before the game starts
    public void Awake()
    {
        Instance = this; // puts the texts on the screen 
    }

    //this is called on the first frame
    public void start()
    {
        coinText.text = "Coins: " + currentNumberOfCoinsCollected.ToString(); // adds the text "Coins: " on the screen
    }

    /*
        This method takes an integer parameter and increases the coin counter by the integer parameter.
        this method also updates the text on the screen
    */
    public void IncreaseCoins(int v)
    {
        currentNumberOfCoinsCollected += v;
        coinText.text = "Coins: " + currentNumberOfCoinsCollected.ToString(); //update the amount of coins listed on the screen
    }
}