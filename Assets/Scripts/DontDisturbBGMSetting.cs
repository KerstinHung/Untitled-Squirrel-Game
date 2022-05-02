using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontDisturbBGMSetting : MonoBehaviour
{
    public AudioSource bgm;
    void Start()
    {
        SameBGMSettings();
    }

    private void SameBGMSettings()
    {
        float bgm_slider_value=PlayerPrefs.GetFloat("bgm_value", 0.5f);
        bgm.volume = bgm_slider_value;
    }
}
