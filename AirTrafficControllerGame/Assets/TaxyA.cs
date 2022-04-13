using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TaxyA : MonoBehaviour
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
            plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToA = true;
            planeStatus.gameObject.GetComponent<planeStatus>().taxingToAViaCJtext();
            planeStatus.GetComponent<Button>().enabled = false;
            planeStatus.GetComponent<planeStatus>().waitingImage();

            //taxyOptions.gameObject.SetActive(false);


        }

        if (myDrop.value == 2)
        {
            lightTirilla.GetComponentInChildren<lightsTest>().start = true;
            lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
            plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToA = true;
            planeStatus.gameObject.GetComponent<planeStatus>().taxingToAViaDJText();
            planeStatus.GetComponent<Button>().enabled = false;
            planeStatus.GetComponent<planeStatus>().waitingImage();

            //taxyOptions.gameObject.SetActive(false);



        }
    }

   
}
