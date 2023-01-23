//made by Hamza

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 the purpose of this class is to change the color of the game object coin on every level.
 you are able to disable this feature through the inspector
*/
public class coinColorRandomizer : MonoBehaviour
{   
    //variables
    public SpriteRenderer coin; //this vairable accesses the sprite of the coin
    public Color[] color; //array to hold the diffrent colors the coin can change to
    public Color defaultColor; // uses the Color vairable built into unity to set the default color of the pet if the player doesnt want random pet colors
    public bool changeCoinColor; // used to see if the player wants random colors or not, if they do the boolean is set to true, if not the boolean is set to false
    private int randomizer; // randomizes the color thats picked from the array

    // Start is called before the first frame update
    void Start()
    {
        randomizer = Random.Range(0, color.Length);//get a random number between 0 and the total amout of colors there are 
        if (changeCoinColor == true)
        {
            coin.color = color[randomizer];//change the coin color to a random color from the array
        }
        else if (changeCoinColor == false)
        {
            coin.color = defaultColor;//sets the coin color to the default one
        }
    }

    // Update is called once per frame
    void Update()
    {   //check if the player wants to change the coin color
        if (changeCoinColor == false)
        {
            coin.color = defaultColor;
        }
    }
}
