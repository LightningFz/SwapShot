using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    //public Rigidbody2D platform;
    public Transform platform;
    public bool isMovingVertically;
    public float speed;
    public float range = 2f;
    private float currentRange;
    private void Start()
    {
        currentRange = range;
    }

    // Update is called once per frame
    void Update()
    {
        currentRange -= Time.deltaTime; 
        if (isMovingVertically == false && currentRange >= 0) // will check if the "isMovingVertically" will be false and the "currentrange" will be more or equal to 0 
        {
            platform.position = new Vector3(platform.position.x + speed, platform.position.y, platform.position.z); // the platform will move on the x axis with the speed of the variable "speed" and staying still on both the y axis and the z axis 
        }
        else if(isMovingVertically == true && currentRange >= 0)
        {
            platform.position = new Vector3(platform.position.x, platform.position.y + speed, platform.position.z);
        }
        if (currentRange <= 0)
        {
            currentRange = range;
            speed = speed * -1;
        }
    }
}
