using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petShooting : MonoBehaviour
{
    public followPlayer petScript;
    public bool canShoot;

    // Update is called once per frame
    void Update()
    {
        if(petScript.atDestination == true)
        {
            canShoot = true;
        }else if(petScript.atDestination == false)
        {
            canShoot = false;
        }
    }
}
