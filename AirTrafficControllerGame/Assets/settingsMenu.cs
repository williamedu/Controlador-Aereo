using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class settingsMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool settinsIsActive = false;

    public AudioMixer auidoMixer;

    const string MIXER_MUSIC = "musicVolume";
    const string MIXER_SFX = "sfxVolume";
    const string MIXER_VOICES = "voicesVolume";


    public TMP_Dropdown resolutionsDropDown;
    Resolution [] resolutions;

    private void Start()
    {
        resolutions = Screen.resolutions;

        resolutionsDropDown.ClearOptions();


        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width  &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionsDropDown.AddOptions(options);
        resolutionsDropDown.value = currentResolutionIndex;
        resolutionsDropDown.RefreshShownValue();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && settinsIsActive)

        {
            settinsIsActive = false;
            pauseMenu.SetActive(true);
            this.GetComponent<Animator>().SetBool("pauseMenuAnim", false);
        }
        
    }

    public void SetResolution (int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume(float volume)
    {
        auidoMixer.SetFloat("Volume", volume);
             
    }

    public void SetMusicVolume(float value)
    {
        auidoMixer.SetFloat(MIXER_MUSIC, Mathf.Log10(value) * 20);
    }

    public void SetSFXVolume(float value)
    {
        auidoMixer.SetFloat(MIXER_SFX, Mathf.Log10(value) * 20);
    }

    public void SetVoicesVolume(float value)
    {
        auidoMixer.SetFloat(MIXER_VOICES, Mathf.Log10(value) * 20);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel( qualityIndex);
    }


    public void SetFullScreen (bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
