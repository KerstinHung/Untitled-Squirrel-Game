using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGM_VolumeController : MonoBehaviour
{
    public Slider bgm_slider;
    public AudioSource bgm;
    void Start()
    {
        bgm_slider.value = PlayerPrefs.GetFloat("bgm_value", 0.5f);
        bgm.volume = bgm_slider.value;
        
    }

    public void UpdateBGMVolume()
    {
        PlayerPrefs.SetFloat("bgm_value", bgm_slider.value);
        bgm.volume = bgm_slider.value;
    }
}
