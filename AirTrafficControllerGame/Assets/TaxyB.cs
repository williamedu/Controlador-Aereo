using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class TaxyB : MonoBehaviour
{

    public GameObject planeStatus;
    public GameObject taxyOptions;
    public GameObject lightTirilla;


    public GameObject plane;
    public TMPro.TMP_Dropdown myDrop;
    public TextMeshProUGUI status;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (myDrop.value == 1)
        {
            lightTirilla.GetComponentInChildren<lightsTest>().start = true;
            lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
            plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToB = true;
            planeStatus.gameObject.GetComponent<planeStatus>().taxingToBViaCJText();
            planeStatus.GetComponent<Button>().enabled = false;
            planeStatus.GetComponent<planeStatus>().waitingImage();

            //taxyOptions.gameObject.SetActive(false);


        }

        if (myDrop.value == 2)
        {
            lightTirilla.GetComponentInChildren<lightsTest>().start = true;
            lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
            plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToB = true;
            planeStatus.gameObject.GetComponent<planeStatus>().taxingToBViaDJText();
            planeStatus.GetComponent<Button>().enabled = false;
            planeStatus.GetComponent<planeStatus>().waitingImage();

            //taxyOptions.gameObject.SetActive(false);



        }
    }
}
