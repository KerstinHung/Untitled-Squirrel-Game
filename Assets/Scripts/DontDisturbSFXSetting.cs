using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDisturbSFXSetting : MonoBehaviour
{
    public AudioSource[] sfx_files;
    void Start()
    {
        SameSFXSettings();
    }

    private void SameSFXSettings()
    {
        float sfx_slider_value = PlayerPrefs.GetFloat("sfx_value", 0.5f);
        for(int i = 0; i < sfx_files.Length; i++){
            sfx_files[i].volume = sfx_slider_value;
        } 
    }
}
