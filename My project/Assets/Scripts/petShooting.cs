using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petShooting : MonoBehaviour
{
    public followPlayer petScript;
    public Rigidbody2D petRigidbody;
    public bool petInPlace;
    public bool canShootPet = false;
    public float petRange;
    private float currentPetRange;

    // Update is called once per frame
    void Update()
    {
        if(petScript.atDestination == true)
        {
            petInPlace = true;
        }else if(petScript.atDestination == false)
        {
            petInPlace = false;
        }
        getInput();
        shootPet();
    }
    void getInput()
    {
        if (Input.GetKeyDown(KeyCode.E) && petInPlace == true)
        {
            canShootPet = true;
        }
    }
    void shootPet()
    {
        if (canShootPet == true && petInPlace == true && currentPetRange > 0)
        {
            petRigidbody.velocity = transform.right * petScript.speed;
            currentPetRange -= Time.deltaTime;
        }else if (currentPetRange <= 0)
        {
            petRigidbody.velocity = transform.right * 0;
            canShootPet = false;
            currentPetRange = petRange;
        }
    }
}
