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
    public GameObject planeMovement;
    public GameObject holdShortOf;
    public GameObject plane;



    private Transform parent;
    private Transform holdShortParent;


    public TMPro.TMP_Dropdown myDrop;
    public TextMeshProUGUI status;
    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent.parent.parent.parent.parent;
        plane = parent.gameObject;

        holdShortParent = transform.parent.parent.parent;
        holdShortOf = holdShortParent.GetChild(4).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (myDrop.value == 1)
        {
            holdShortOf.SetActive(true);
            plane.GetComponent<Aeronave>().isFacingN = false;
            plane.GetComponent<Aeronave>().isFacingS = false;
            lightTirilla.GetComponentInChildren<lightsTest>().start = true;
            lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
            plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToB = true;
            planeStatus.gameObject.GetComponent<planeStatus>().taxingToBViaCJText();
            planeStatus.GetComponent<Button>().enabled = false;
            planeStatus.GetComponent<planeStatus>().waitingImage();
            //planeMovement.gameObject.SetActive(true);


            //taxyOptions.gameObject.SetActive(false);


        }

        if (myDrop.value == 2)
        {

            holdShortOf.SetActive(true);
            plane.GetComponent<Aeronave>().isFacingN = false;
            plane.GetComponent<Aeronave>().isFacingS = false;
            lightTirilla.GetComponentInChildren<lightsTest>().start = true;
            lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
            plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToB = true;
            planeStatus.gameObject.GetComponent<planeStatus>().taxingToBViaDJText();
            planeStatus.GetComponent<Button>().enabled = false;
            planeStatus.GetComponent<planeStatus>().waitingImage();
           // planeMovement.gameObject.SetActive(true);


            //taxyOptions.gameObject.SetActive(false);



        }
    }
}
