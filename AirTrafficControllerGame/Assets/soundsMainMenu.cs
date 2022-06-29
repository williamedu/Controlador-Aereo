using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundsMainMenu : MonoBehaviour
{
    public mainMenuAudioManager audioManagerMainMenu;




    public void PressAnyKeySound()
    {
        audioManagerMainMenu.PlayVFX("pressAnykey");

    }

    public void SelectSound()
    {
        audioManagerMainMenu.PlayVFX("select");

    }
    public void HoverSound()
    {
        audioManagerMainMenu.PlayVFX("hover");
        print("hovering");

    }
    public void BackSound()
    {
        audioManagerMainMenu.PlayVFX("back");

    }

    public void SighnSound()
    {
        audioManagerMainMenu.PlayVFX("sighn");

    }

    public void PauseSound()
    {
        audioManagerMainMenu.PlayVFX("pause");

    }

    public void TirillaClickSound()
    {
        audioManagerMainMenu.PlayVFX("tirillaClickSound");

    }

    public void StopButton()
    {
        audioManagerMainMenu.PlayVFX("StopButton");

    }

    public void ContinueButton()
    {
        audioManagerMainMenu.PlayVFX("ContinueButton");

    }

    public void HoldShortOn()
    {
        audioManagerMainMenu.PlayVFX("HoldShortOn");

    }

    public void HoldShortOff()
    {
        audioManagerMainMenu.PlayVFX("HoldShortOff");

    }

    public void takeOffSound()
    {
        audioManagerMainMenu.PlayVFX("takeOff");

    }

    public void hola()
    {
        print("hola");
    }

}
