using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundColor : MonoBehaviour
{
    public Camera Camera;
    public Color[] color;
    public Color defaultColor;
    public bool changeBackgroundColor;
    private int randomizer;

    // Start is called before the first frame update
    void Start()
    {
        randomizer = Random.Range(0, color.Length);
        if (changeBackgroundColor == true)
        {
            Camera.backgroundColor = color[randomizer];
        }
        else if (changeBackgroundColor == false)
        {
            Camera.backgroundColor = defaultColor;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (changeBackgroundColor == false)
        {
            Camera.backgroundColor = defaultColor;
        }
    }
}
