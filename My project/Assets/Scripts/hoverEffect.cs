using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        currentPosition = startPosition;
        currentPosition.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = currentPosition;
    }
}
