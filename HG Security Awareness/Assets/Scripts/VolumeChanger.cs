using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    private AudioSource AudioSrc;
    private GameObject VolumeSlider;

    private float AudioVolume = 1f;

    void Start()
    {
        AudioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        AudioSrc.volume = AudioVolume;
    }

    public void SetVolume(float vol)
    {
            AudioVolume = vol;
    }
}
