using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSFX : MonoBehaviour
{
    public AudioSource mySfx;
    public AudioClip hoverFx;
    public AudioClip clickFx;

    //plays the hover sound effect
    public void HoverSound()
    {
        mySfx.PlayOneShot(hoverFx);
    }
    //plays the click sound effect
    public void ClickSound()
    {
        mySfx.PlayOneShot(clickFx);
    }
}
