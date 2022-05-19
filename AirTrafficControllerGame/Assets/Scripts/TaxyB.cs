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
    public bool domie1 = true;

    // Start is called before the first frame update
    void Start()
    {
        domie1 = true;
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
            if (plane.CompareTag("A3") && plane.gameObject.GetComponent<Aeronave>().S == true)

            {
                print(plane.name + " no se puede ir por aqui - 200 puntos");
                domie1 = false;
            }
            if (plane.CompareTag("A3") && plane.gameObject.GetComponent<Aeronave>().N == true)
            {
                
                holdShortOf.SetActive(true);
                plane.GetComponent<Aeronave>().isFacingN = false;
                plane.GetComponent<Aeronave>().isFacingS = false;
                lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToB = true;
                planeStatus.GetComponent<planeStatus>().taxingToAViaCJtext();
                planeStatus.GetComponent<Button>().enabled = false;
                planeStatus.GetComponent<planeStatus>().waitingImage();
                planeMovement.gameObject.SetActive(true);
                domie1 = false;

                //planeMovement.gameObject.SetActive(true);
                //holdShortOff.GetComponent<Button>().enabled = true;
                //taxyOptions.gameObject.SetActive(false);
            }

            if (plane.CompareTag("A2") && plane.gameObject.GetComponent<Aeronave>().S == true)

            {
                print(plane.name + " no se puede ir por aqui - 200 puntos");
                domie1 = false;
            }
            if (plane.CompareTag("A2") && plane.gameObject.GetComponent<Aeronave>().N == true)
            {
               
                holdShortOf.SetActive(true);
                plane.GetComponent<Aeronave>().isFacingN = false;
                plane.GetComponent<Aeronave>().isFacingS = false;
                lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToB = true;
                planeStatus.GetComponent<planeStatus>().taxingToAViaCJtext();
                planeStatus.GetComponent<Button>().enabled = false;
                planeStatus.GetComponent<planeStatus>().waitingImage();
                planeMovement.gameObject.SetActive(true);
                domie1 = false;

                //planeMovement.gameObject.SetActive(true);
                //holdShortOff.GetComponent<Button>().enabled = true;
                //taxyOptions.gameObject.SetActive(false);
            }

            if (plane.CompareTag("B1") && plane.gameObject.GetComponent<Aeronave>().S == true)

            {
                print(plane.name + " no se puede ir por aqui - 200 puntos");
                domie1 = false;
            }
            if (plane.CompareTag("B1") && plane.gameObject.GetComponent<Aeronave>().N == true)
            {
               
                holdShortOf.SetActive(true);
                plane.GetComponent<Aeronave>().isFacingN = false;
                plane.GetComponent<Aeronave>().isFacingS = false;
                lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToB = true;
                planeStatus.GetComponent<planeStatus>().taxingToAViaCJtext();
                planeStatus.GetComponent<Button>().enabled = false;
                planeStatus.GetComponent<planeStatus>().waitingImage();
                planeMovement.gameObject.SetActive(true);
                domie1 = false;

                //planeMovement.gameObject.SetActive(true);
                //holdShortOff.GetComponent<Button>().enabled = true;
                //taxyOptions.gameObject.SetActive(false);
            }
            if (plane.CompareTag("B2") && plane.gameObject.GetComponent<Aeronave>().S == true)

            {
                print(plane.name + " no se puede ir por aqui - 200 puntos");
                domie1 = false;
            }
            if (plane.CompareTag("B2") && plane.gameObject.GetComponent<Aeronave>().N == true)
            {
                
                holdShortOf.SetActive(true);
                plane.GetComponent<Aeronave>().isFacingN = false;
                plane.GetComponent<Aeronave>().isFacingS = false;
                lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToB = true;
                planeStatus.GetComponent<planeStatus>().taxingToAViaCJtext();
                planeStatus.GetComponent<Button>().enabled = false;
                planeStatus.GetComponent<planeStatus>().waitingImage();
                planeMovement.gameObject.SetActive(true);
                domie1 = false;

                //planeMovement.gameObject.SetActive(true);
                //holdShortOff.GetComponent<Button>().enabled = true;
                //taxyOptions.gameObject.SetActive(false);
            }
            if (plane.CompareTag("B3") && plane.gameObject.GetComponent<Aeronave>().S == true)

            {
                print(plane.name + " no se puede ir por aqui - 200 puntos");
                domie1 = false;
            }
            if (plane.CompareTag("B3") && plane.gameObject.GetComponent<Aeronave>().N == true)
            {
                
                holdShortOf.SetActive(true);
                plane.GetComponent<Aeronave>().isFacingN = false;
                plane.GetComponent<Aeronave>().isFacingS = false;
                lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToB = true;
                planeStatus.GetComponent<planeStatus>().taxingToAViaCJtext();
                planeStatus.GetComponent<Button>().enabled = false;
                planeStatus.GetComponent<planeStatus>().waitingImage();
                planeMovement.gameObject.SetActive(true);
                domie1 = false;
                //planeMovement.gameObject.SetActive(true);
                //holdShortOff.GetComponent<Button>().enabled = true;
                //taxyOptions.gameObject.SetActive(false);
            }

            if (domie1 == true)
            {
                
                holdShortOf.SetActive(true);
                plane.GetComponent<Aeronave>().isFacingN = false;
                plane.GetComponent<Aeronave>().isFacingS = false;
                lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToB = true;
                planeStatus.GetComponent<planeStatus>().taxingToAViaCJtext();
                planeStatus.GetComponent<Button>().enabled = false;
                planeStatus.GetComponent<planeStatus>().waitingImage();
                planeMovement.gameObject.SetActive(true);
            }

        }

        if (myDrop.value == 2)
        {

            if (plane.CompareTag("A3") && plane.gameObject.GetComponent<Aeronave>().N == true)

            {
                print(plane.name + " no se puede ir por aqui - 200 puntos");
                domie1 = false;
            }
            if (plane.CompareTag("A3") && plane.gameObject.GetComponent<Aeronave>().S == true)
            {
                
                holdShortOf.SetActive(true);
                plane.GetComponent<Aeronave>().isFacingN = false;
                plane.GetComponent<Aeronave>().isFacingS = false;
                lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToB = true;
                planeStatus.GetComponent<planeStatus>().taxingToBViaDJText();
                planeStatus.GetComponent<Button>().enabled = false;
                planeStatus.GetComponent<planeStatus>().waitingImage();
                planeMovement.gameObject.SetActive(true);
                domie1 = false;

                //planeMovement.gameObject.SetActive(true);
                //holdShortOff.GetComponent<Button>().enabled = true;
                //taxyOptions.gameObject.SetActive(false);
            }

            if (plane.CompareTag("A2") && plane.gameObject.GetComponent<Aeronave>().N == true)

            {
                print(plane.name + " no se puede ir por aqui - 200 puntos");
                domie1 = false;
            }
            if (plane.CompareTag("A2") && plane.gameObject.GetComponent<Aeronave>().S == true)
            {
                
                holdShortOf.SetActive(true);
                plane.GetComponent<Aeronave>().isFacingN = false;
                plane.GetComponent<Aeronave>().isFacingS = false;
                lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToB = true;
                planeStatus.GetComponent<planeStatus>().taxingToBViaDJText();
                planeStatus.GetComponent<Button>().enabled = false;
                planeStatus.GetComponent<planeStatus>().waitingImage();
                planeMovement.gameObject.SetActive(true);
                domie1 = false;

                //planeMovement.gameObject.SetActive(true);
                //holdShortOff.GetComponent<Button>().enabled = true;
                //taxyOptions.gameObject.SetActive(false);
            }

            if (plane.CompareTag("B1") && plane.gameObject.GetComponent<Aeronave>().N == true)

            {
                print(plane.name + " no se puede ir por aqui - 200 puntos");
                domie1 = false;
            }
            if (plane.CompareTag("B1") && plane.gameObject.GetComponent<Aeronave>().S == true)
            {
               
                holdShortOf.SetActive(true);
                plane.GetComponent<Aeronave>().isFacingN = false;
                plane.GetComponent<Aeronave>().isFacingS = false;
                lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToB = true;
                planeStatus.GetComponent<planeStatus>().taxingToBViaDJText();
                planeStatus.GetComponent<Button>().enabled = false;
                planeStatus.GetComponent<planeStatus>().waitingImage();
                planeMovement.gameObject.SetActive(true);
                domie1 = false;

                //planeMovement.gameObject.SetActive(true);
                //holdShortOff.GetComponent<Button>().enabled = true;
                //taxyOptions.gameObject.SetActive(false);
            }

            if (plane.CompareTag("B2") && plane.gameObject.GetComponent<Aeronave>().N == true)

            {
                print(plane.name + " no se puede ir por aqui - 200 puntos");
                domie1 = false;
            }
            if (plane.CompareTag("B2") && plane.gameObject.GetComponent<Aeronave>().S == true)
            {
               
                holdShortOf.SetActive(true);
                plane.GetComponent<Aeronave>().isFacingN = false;
                plane.GetComponent<Aeronave>().isFacingS = false;
                lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToB = true;
                planeStatus.GetComponent<planeStatus>().taxingToBViaDJText();
                planeStatus.GetComponent<Button>().enabled = false;
                planeStatus.GetComponent<planeStatus>().waitingImage();
                planeMovement.gameObject.SetActive(true);
                domie1 = false;

                //planeMovement.gameObject.SetActive(true);
                //holdShortOff.GetComponent<Button>().enabled = true;
                //taxyOptions.gameObject.SetActive(false);
            }

            if (plane.CompareTag("B3") && plane.gameObject.GetComponent<Aeronave>().N == true)

            {
                print(plane.name + " no se puede ir por aqui - 200 puntos");
                domie1 = false;
            }
            if (plane.CompareTag("B3") && plane.gameObject.GetComponent<Aeronave>().S == true)
            {
                
                holdShortOf.SetActive(true);
                plane.GetComponent<Aeronave>().isFacingN = false;
                plane.GetComponent<Aeronave>().isFacingS = false;
                lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToB = true;
                planeStatus.GetComponent<planeStatus>().taxingToBViaDJText();
                planeStatus.GetComponent<Button>().enabled = false;
                planeStatus.GetComponent<planeStatus>().waitingImage();
                planeMovement.gameObject.SetActive(true);
                domie1 = false;

                //planeMovement.gameObject.SetActive(true);
                //holdShortOff.GetComponent<Button>().enabled = true;
                //taxyOptions.gameObject.SetActive(false);
            }

            if (plane.CompareTag("B4") && plane.gameObject.GetComponent<Aeronave>().N == true)

            {
                print(plane.name + " no se puede ir por aqui - 200 puntos");
                domie1 = false;
            }
            if (plane.CompareTag("B4") && plane.gameObject.GetComponent<Aeronave>().S == true)
            {

                holdShortOf.SetActive(true);
                plane.GetComponent<Aeronave>().isFacingN = false;
                plane.GetComponent<Aeronave>().isFacingS = false;
                lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToB = true;
                planeStatus.GetComponent<planeStatus>().taxingToBViaDJText();
                planeStatus.GetComponent<Button>().enabled = false;
                planeStatus.GetComponent<planeStatus>().waitingImage();
                planeMovement.gameObject.SetActive(true);
                domie1 = false;

                //planeMovement.gameObject.SetActive(true);
                //holdShortOff.GetComponent<Button>().enabled = true;
                //taxyOptions.gameObject.SetActive(false);
            }

            if (domie1 == true)
            {
                
                holdShortOf.SetActive(true);
                plane.GetComponent<Aeronave>().isFacingN = false;
                plane.GetComponent<Aeronave>().isFacingS = false;
                lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToB = true;
                planeStatus.GetComponent<planeStatus>().taxingToBViaDJText();
                planeStatus.GetComponent<Button>().enabled = false;
                planeStatus.GetComponent<planeStatus>().waitingImage();
                planeMovement.gameObject.SetActive(true);
            }



        }
    }
}


