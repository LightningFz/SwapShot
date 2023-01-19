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
    public bool objectonplatform;
    public GameObject myPlayer;
    private void Start()
    {
        currentRange = range;
        objectonplatform = true;
    }

    // Update is called once per frame
    void Update()
    {
        currentRange -= Time.deltaTime;
        if (isMovingVertically == false && currentRange >= 0)
        {
            platform.position = new Vector3(platform.position.x + speed, platform.position.y, platform.position.z);   
        }else if(isMovingVertically == true && currentRange >= 0)
        {
            platform.position = new Vector3(platform.position.x, platform.position.y + speed, platform.position.z);
        }
        if (currentRange <= 0)
        {
            currentRange = range;
            speed = speed * -1;
        }

        if(objectonplatform)
        {
            myPlayer.transform.SetParent(null);
        }
        else
        {
            myPlayer.transform.SetParent(this.transform);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            objectonplatform = false;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            objectonplatform = true;
        }
    }
}
