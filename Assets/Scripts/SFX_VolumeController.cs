using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFX_VolumeController : MonoBehaviour
{
    public Slider sfx_slider;
    public AudioSource sfx_files;
    void Start()
    {
        sfx_slider.value=PlayerPrefs.GetFloat("sfx_value", 0.5f);
        sfx_files.volume = sfx_slider.value;
           
    }

    public void UpdateSFXVolume()
    {
        PlayerPrefs.SetFloat("sfx_value", sfx_slider.value);
        sfx_files.volume = sfx_slider.value;
    }
}
