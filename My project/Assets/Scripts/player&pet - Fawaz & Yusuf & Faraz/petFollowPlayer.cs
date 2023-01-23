//made by Yusuf

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    this class allows the pet to follow the player
    the dev can pick how fast the pet follows the player as well as where he stops in comparison to the player position
 */
public class petFollowPlayer : MonoBehaviour
{

    //variables
    public float stoppingDistance;
    public float speed;
    public bool atDestination;
    public petShooting player;
    private Transform target;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("pet position").GetComponent<Transform>(); // find the target gameobject
    }

    // Update is called once per frame
    void Update()
    {
        if (player.canShootPet == false || player.petInPlace == false) 
        {
            follow();
        }
    }
    //folllow the gameobject that was found in the start method and has been saved in the target variable
    void follow()
    {
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            atDestination = false;
        }
        else
        {
            atDestination = true;
        }
    }
}
