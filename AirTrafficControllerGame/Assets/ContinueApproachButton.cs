using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ContinueApproachButton : MonoBehaviour
{
    public GameObject imageToChange;
    public TextMeshProUGUI statusPlane;
    public Sprite bottonAzul;
    public Sprite bottonAmarillo;

    public string status = ("Approaching RWY 17");
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        statusPlane.text = status;    
    }
}
