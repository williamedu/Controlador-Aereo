using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class LandingOptionsDropDown : MonoBehaviour
{
    public string status = ("LANDING RWY 17");
    public TextMeshProUGUI statusPlane;
    public TMPro.TMP_Dropdown myDrop;
    public Sprite bottonAzul;
    public Sprite bottonAmarillo;
    public GameObject imageToChange;
    public GameObject plane;
    public GameObject lightsAir;
    public GameObject stopPlaneButton; // para activar el stop button cuando salga de pista
    public bool activarButtonBool;


    public void Start()
    {
        activarButtonBool = true;
        lightsAir.GetComponent<lightsAir>().stop = true;
    }

    public void Update()
    {
        if (plane.GetComponent<Approach>().taxing == true && activarButtonBool == true) 
        {
            activarStopButton();
        }
    }

    public void statusChange()
    {
        if (myDrop.value == 1)
        {
            statusPlane.text = status;
            plane.GetComponent<Approach>().ClearToLand = true;
            lightsAir.GetComponent<lightsAir>().start = true; // activa las luces parpadeantes

        }
            
    }

    public void normalImage()
    {
        imageToChange.GetComponent<Image>().sprite = bottonAzul;

    }

    public void waitingImage()
    {
        imageToChange.GetComponent<Image>().sprite = bottonAmarillo;

    }

    public void activarStopButton()
    {
        stopPlaneButton.SetActive(true);
        activarButtonBool = false;

    }

}
