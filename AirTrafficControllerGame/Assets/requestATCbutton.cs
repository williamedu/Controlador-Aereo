using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class requestATCbutton : MonoBehaviour
{

    public TextMeshProUGUI label;
    public string status;
    public Sprite bottonVerde;
    public Sprite bottonAmarillo;
    public GameObject imageToChange;



    public void updateStatus()
    {
        label.text = status;
    }

    public void normalImage()
    {
        imageToChange.GetComponent<Image>().sprite = bottonVerde;

    }

    public void waitingImage()
    {
        imageToChange.GetComponent<Image>().sprite = bottonAmarillo;

    }
}
