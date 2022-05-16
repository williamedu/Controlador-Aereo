using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ContinueApproachButton : MonoBehaviour
{
    public GameObject imageToChange;
    public GameObject plane;
    public GameObject clearToLandDrop;
    public TextMeshProUGUI statusPlane;
    public Sprite bottonAzul;
    public Sprite bottonAmarillo;
    public GameObject lightsAir;

    public string status = ("Approaching RWY 17");
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clearToLand();
    }

    public void normalImage()
    {
        imageToChange.GetComponent<Image>().sprite = bottonAzul;

    }

    public void waitingImage()
    {
        imageToChange.GetComponent<Image>().sprite = bottonAmarillo;

    }

    public void statusChange()
    {
        statusPlane.text = status; // cambia el texto del boton a Approaching RWY 17
        lightsAir.GetComponent<lightsAir>().start = true; // activa las luces parpadeantes
    }

    public void clearToLand()
    {
        if (plane.GetComponent<Approach>().Onsight == true)
        {
            clearToLandDrop.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
