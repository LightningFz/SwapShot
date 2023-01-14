using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{ 
    public float stoppingDistance;
    public float speed;
    public bool atDestination;
    private Transform target;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("pet position").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            atDestination = false;
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }else
        {
            atDestination = true;
        }
    }
}
