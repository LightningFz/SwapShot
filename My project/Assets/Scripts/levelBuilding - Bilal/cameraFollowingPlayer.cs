// made by Bilal

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    this class is used to make the camera follow the player
 */
public class cameraFollowingPlayer : MonoBehaviour
{
    // Variables for the Camera 
    public Transform player; //position of the camera
    public float offsetOnX = 0f;
    public float offsetOnY = 5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(player.position.x + offsetOnX, player.position.y + offsetOnY, this.transform.position.z); // the camera will follow the player on both the x axis and y axis with a small offset while staying on the z axis 
    }
}
