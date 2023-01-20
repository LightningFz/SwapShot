using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSlider : MonoBehaviour
{
    // made by yusuf 

    public AudioSource AudioSource;

    private float musicVolume = 0.29f;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.Play();//play music from the start of the game
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = musicVolume; //updating the volume if the player used the slider 
    }

    public void updateVolume(float volume) //get the new volume inputted by the player 
    {
        musicVolume = volume;
    }
}
