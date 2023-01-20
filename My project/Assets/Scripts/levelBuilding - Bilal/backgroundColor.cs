using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundColor : MonoBehaviour
{
    // made by bilal

    //variables
    public Camera Camera;
    public Color[] color;//array
    public Color defaultColor;
    public bool changeBackgroundColor;
    private int randomizer;

    // Start is called before the first frame update
    void Start()
    {
        randomizer = Random.Range(0, color.Length);//get a random number between 0 and the total amout of colors there are 
        if (changeBackgroundColor == true)
        {
            Camera.backgroundColor = color[randomizer];//change the background color to a random color from the array
        }
        else if (changeBackgroundColor == false)
        {
            Camera.backgroundColor = defaultColor;//change the background color to the default one
        }
    }

    // Update is called once per frame
    void Update()
    {   //check if the player wants to change the background color
        if (changeBackgroundColor == false)
        {
            Camera.backgroundColor = defaultColor;
        }
    }
}
