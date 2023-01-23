// made by Bilal

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    this class is used to make a hovering effect for game objects
    you can set the hover effect at a certian range 
 */
public class hoverEffect : MonoBehaviour
{
    public float amplitude = 0.5f; //how much the object goes up and down
    public float frequency = 1f; //how long it takes to complete a loop

    //Storage Position Variables
    public Vector3 startPosition = new Vector3();
    public Vector3 currentPosition = new Vector3();

    private void Start()
    {
        // Store the starting position of the object
        startPosition = transform.position;
    }

    private void FixedUpdate()
    {
        currentPosition = startPosition; // sets the "CurrentPosition" to "startPosition"
        currentPosition.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude; // Sets the y axis of the variable "currentPosition" to radians 
        transform.position = currentPosition; // sets the position of the effect to the variable "currentPosition" 
    }
}
