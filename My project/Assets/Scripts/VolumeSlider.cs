using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSlider : MonoBehaviour
{
    public AudioSource AudioSource;

    private float musicVolume = 0.29f;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = musicVolume;
    }

    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }
}
