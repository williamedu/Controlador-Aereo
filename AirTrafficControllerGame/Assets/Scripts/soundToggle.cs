using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class soundToggle : MonoBehaviour
{
    public Image imageToToggle;
    public bool toggle;
    public GameObject settingsMenu;
    public Slider slider;
    public mainMenuAudioManager soundsMainMenu;

    public void Start()
    {
        toggle = true;
    }
    public void toggleSoundSFX()
    {
       



        if (toggle == false)
        {
            soundsMainMenu.GetComponent<mainMenuAudioManager>().PlayVFX("HoldShortOn");
            imageToToggle.GetComponent<Image>().color = new Color32(28, 182, 247, 255);
           settingsMenu.GetComponent<settingsMenu>().MuteSFX(0);
            slider.value = 1;

        }

        else if (toggle == true)
        {
            soundsMainMenu.GetComponent<mainMenuAudioManager>().PlayVFX("HoldShortOff");
            imageToToggle.GetComponent<Image>().color = new Color32(101, 106, 108, 255);
            settingsMenu.GetComponent<settingsMenu>().MuteSFX(-80);
            slider.value = 0.0001f;
        }
    }

    public void toggleSoundMUSIC()
    {
        if (toggle == false)
        {
            soundsMainMenu.GetComponent<mainMenuAudioManager>().PlayVFX("HoldShortOn");
            imageToToggle.GetComponent<Image>().color = new Color32(28, 182, 247, 255);
            settingsMenu.GetComponent<settingsMenu>().MuteMUSIC(0);
            slider.value = 1;

        }

        else if (toggle == true)
        {
            soundsMainMenu.GetComponent<mainMenuAudioManager>().PlayVFX("HoldShortOff");
            imageToToggle.GetComponent<Image>().color = new Color32(101, 106, 108, 255);
            settingsMenu.GetComponent<settingsMenu>().MuteMUSIC(-80);
            slider.value = 0.0001f;
        }
    }

    public void toggleSoundVOICE()
    {
        if (toggle == false)
        {
            soundsMainMenu.GetComponent<mainMenuAudioManager>().PlayVFX("HoldShortOn");
            imageToToggle.GetComponent<Image>().color = new Color32(28, 182, 247, 255);
            settingsMenu.GetComponent<settingsMenu>().MuteVOICE(0);
            slider.value = 1;

        }

        else if (toggle == true)
        {
            soundsMainMenu.GetComponent<mainMenuAudioManager>().PlayVFX("HoldShortOff");
            imageToToggle.GetComponent<Image>().color = new Color32(101, 106, 108, 255);
            settingsMenu.GetComponent<settingsMenu>().MuteVOICE(-80);
            slider.value = 0.0001f;
        }
    }

    public void boolToggle()
    {
        if (toggle == false)
        {
            toggle = true;
        }

        else if(toggle == true)
        {
            toggle = false;
        }
    }

    public void checkImage()
    {
        if (slider.value > 0.0001f)
        {
            imageToToggle.GetComponent<Image>().color = new Color32(28, 182, 247, 255);

        }
        else
        {
            imageToToggle.GetComponent<Image>().color = new Color32(101, 106, 108, 255);

        }


    }
}
