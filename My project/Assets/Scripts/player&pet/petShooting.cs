using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petShooting : MonoBehaviour
{
    public followPlayer petScript;
    public Rigidbody2D petRigidbody;
    public AudioClip petShootSound;
    public bool petInPlace;
    public bool canShootPet = false;
    public bool petBeingShoot = false;
    public float petRange;
    public float currentPetRange;
    public bool soundFix;
    

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
            soundFix = true;
        }
    }
    void shootPet()
    {
        if (canShootPet == true && soundFix ==true)
        {
            AudioSource.PlayClipAtPoint(petShootSound,transform.position);
            soundFix = false;
        }
        
        if (canShootPet == true && petInPlace == true && currentPetRange > 0)
        {
            petBeingShoot = true;
            petRigidbody.velocity = transform.right * petScript.speed;
            currentPetRange -= Time.deltaTime;
            
        }else if (currentPetRange <= 0)
        {
            petBeingShoot = false;
            petRigidbody.velocity = transform.right * 0;
            canShootPet = false;
            soundFix = false;
            currentPetRange = petRange;
        }
    }
}

