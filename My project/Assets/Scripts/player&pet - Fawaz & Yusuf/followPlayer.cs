using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{ 
    public float stoppingDistance;
    public float speed;
    public bool atDestination;
    public petShooting player;
    private Transform target;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("pet position").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.canShootPet == false || player.petInPlace == false)
        {
            follow();
        }
    }
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
