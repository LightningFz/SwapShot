using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter Instance;// This class was turned into a variable that could be accessed from any where in the game.

    public TMP_Text coinText;// the UI element used to display the number of coins
    public int currentCoins = 0;

    //this is called before the game starts
    public void Awake()
    {
        Instance = this; // puts the texts on the screen 
    }

    //this is called on the first frame
    public void start()
    {
        coinText.text = "Coins: " + currentCoins.ToString(); // adds the text "coin" 
    }

    //This method takes an integer parameter and increases the coin counter by the integer parameter.
    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        coinText.text = "Coins: " + currentCoins.ToString(); //update the amount of coins 
    }
}