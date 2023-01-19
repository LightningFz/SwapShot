using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petShooting : MonoBehaviour
{
    public followPlayer petScript;
    public Rigidbody2D petRigidbody;
    public AudioClip petShootSound;
    public Transform petRotation;
    public bool petInPlace;
    public bool canShootPet = false;
    public bool petBeingShoot = false;
    public float petRange;
    public float currentPetRange;
    public Vector3 mousePos;
    public Vector3 screenPos;
    public Vector3 offset;
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
        getRotate();
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
            petRigidbody.velocity = petRotation.transform.up * petScript.speed;
            currentPetRange -= Time.deltaTime;
            
        }else if (currentPetRange <= 0)
        {
            petBeingShoot = false;
            petRigidbody.velocity = petRotation.transform.up * 0;
            canShootPet = false;
            soundFix = false;
            currentPetRange = petRange;
        }
    }

    void getRotate()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            mousePos = Input.mousePosition;                                             //get mouse position                                     
            screenPos = Camera.main.WorldToScreenPoint(transform.position);             //Get object position and put it "on the screen" (same as mouse)                
            offset = new Vector3(mousePos.x - screenPos.x , mousePos.y - screenPos.y );   //Check where the mouse is relative to the object 

            float angle = Mathf.Atan2(offset.x, offset.y) * Mathf.Rad2Deg;                      //Turn that into an angle and convert to degrees
            petRotation.rotation = Quaternion.AngleAxis(angle, Vector3.back);  
        }
    }
}

