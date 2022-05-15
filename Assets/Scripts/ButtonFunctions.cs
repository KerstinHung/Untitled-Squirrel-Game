using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
    public AudioSource sounds;
    public AudioClip hoverSound;
    public AudioClip clickSound;
    void Start()
    {
        float sfx_slider_value=PlayerPrefs.GetFloat("sfx_value", 0.5f);
        sounds.volume = sfx_slider_value;
    }

    public void onHover()
    {
        float sfx_slider_value=PlayerPrefs.GetFloat("sfx_value", 0.5f);
        sounds.PlayOneShot(hoverSound, sfx_slider_value);
    }
    // Start is called before the first frame update
    public void onClick()
    {
        float sfx_slider_value=PlayerPrefs.GetFloat("sfx_value", 0.5f);
        sounds.PlayOneShot(clickSound, sfx_slider_value);
    }
    public void PointerEnter()
    {
        transform.localScale = new Vector2(0.6f, 0.6f);
    }
    public void PointerExit()
    {
        transform.localScale = new Vector2(0.4f, 0.4f);
    }
}
