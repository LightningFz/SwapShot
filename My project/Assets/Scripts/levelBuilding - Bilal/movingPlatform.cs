using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    public Transform posA, posB;
    public int Speed;
    public float timer;
    Vector2 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        targetPos=posB.position;
    }

    // Update is called once per frame
    public void Update()
    {
<<<<<<< HEAD
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
=======
        if (Vector2.Distance(transform.position, posA.position) < .1f) Invoke("Action1", timer);
        if (Vector2.Distance(transform.position, posB.position) < .1f) Invoke("Action2", timer);

        transform.position = Vector2.MoveTowards(transform.position, targetPos, Speed * Time.deltaTime);
    }
    public void Action1()
    {
        targetPos = posB.position;
    }
    public void Action2()
    {
        targetPos = posA.position;
>>>>>>> aeb673c798e98533a0a5c1a5228c0cdf4e82d2d5
    }
}
