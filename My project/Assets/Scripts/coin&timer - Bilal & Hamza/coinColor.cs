//made by Hamza

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinColor : MonoBehaviour
{
    //variables
    public SpriteRenderer coin;
    public Color[] color;//array
    public Color defaultColor;
    public bool changePlayerColor;
    private int randomizer;

    // Start is called before the first frame update
    void Start()
    {
        randomizer = Random.Range(0, color.Length);//get a random number between 0 and the total amout of colors there are 
        if (changePlayerColor == true)
        {
            coin.color = color[randomizer];//change the background color to a random color from the array
        }
        else if (changePlayerColor == false)
        {
            coin.color = defaultColor;//change the background color to the default one
        }
    }

    // Update is called once per frame
    void Update()
    {   //check if the player wants to change the background color
        if (changePlayerColor == false)
        {
            coin.color = defaultColor;
        }
    }
}
