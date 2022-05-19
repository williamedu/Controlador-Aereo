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
    public GameObject holdShortOf;
    public GameObject planeMovement;
    public GameObject plane;


    private Transform parent;
    private Transform holdShortParent;

    public TMPro.TMP_Dropdown myDrop;
    public TextMeshProUGUI status;

    public bool canDrop1 = true;
    public bool canDrop2 = true;
    public bool domie1 = true;

    // Start is called before the first frame update
    void Start()
    {
        canDrop1 = true;
        canDrop2 = true;
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
                    print("se fue por charlie");
                    holdShortOf.SetActive(true);
                    plane.GetComponent<Aeronave>().isFacingN = false;
                    plane.GetComponent<Aeronave>().isFacingS = false;
                    lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                    lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                    plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToA = true;
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
                    print("se fue por charlie");
                    holdShortOf.SetActive(true);
                    plane.GetComponent<Aeronave>().isFacingN = false;
                    plane.GetComponent<Aeronave>().isFacingS = false;
                    lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                    lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                    plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToA = true;
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
                    print("se fue por charlie");
                    holdShortOf.SetActive(true);
                    plane.GetComponent<Aeronave>().isFacingN = false;
                    plane.GetComponent<Aeronave>().isFacingS = false;
                    lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                    lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                    plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToA = true;
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
                    print("se fue por charlie");
                    holdShortOf.SetActive(true);
                    plane.GetComponent<Aeronave>().isFacingN = false;
                    plane.GetComponent<Aeronave>().isFacingS = false;
                    lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                    lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                    plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToA = true;
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
                    print("se fue por charlie");
                    holdShortOf.SetActive(true);
                    plane.GetComponent<Aeronave>().isFacingN = false;
                    plane.GetComponent<Aeronave>().isFacingS = false;
                    lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                    lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                    plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToA = true;
                    planeStatus.GetComponent<planeStatus>().taxingToAViaCJtext();
                    planeStatus.GetComponent<Button>().enabled = false;
                    planeStatus.GetComponent<planeStatus>().waitingImage();
                planeMovement.gameObject.SetActive(true);
                domie1 = false;

                //planeMovement.gameObject.SetActive(true);
                //holdShortOff.GetComponent<Button>().enabled = true;
                //taxyOptions.gameObject.SetActive(false);

            }

            if (plane.CompareTag("B4") && plane.gameObject.GetComponent<Aeronave>().S == true)

            {
                print(plane.name + " no se puede ir por aqui - 200 puntos");
                domie1 = false;
            }
            if (plane.CompareTag("B4") && plane.gameObject.GetComponent<Aeronave>().N == true)
            {
                print("se fue por charlie");
                holdShortOf.SetActive(true);
                plane.GetComponent<Aeronave>().isFacingN = false;
                plane.GetComponent<Aeronave>().isFacingS = false;
                lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToA = true;
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
                print(plane.name + "se fue por CJ to alfa");
                holdShortOf.SetActive(true);
                plane.GetComponent<Aeronave>().isFacingN = false;
                plane.GetComponent<Aeronave>().isFacingS = false;
                lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToA = true;
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
                print("se fue por charlie");
                holdShortOf.SetActive(true);
                plane.GetComponent<Aeronave>().isFacingN = false;
                plane.GetComponent<Aeronave>().isFacingS = false;
                lightTirilla.GetComponentInChildren<lightsTest>().start = true;
                lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
                plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToA = true;
                planeStatus.GetComponent<planeStatus>().taxingToAViaDJText();
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
                plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToA = true;
                planeStatus.GetComponent<planeStatus>().taxingToAViaDJText();
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
                    plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToA = true;
                    planeStatus.GetComponent<planeStatus>().taxingToAViaDJText();
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
                    plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToA = true;
                    planeStatus.GetComponent<planeStatus>().taxingToAViaDJText();
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
                    plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToA = true;
                    planeStatus.GetComponent<planeStatus>().taxingToAViaDJText();
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
                plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToA = true;
                planeStatus.GetComponent<planeStatus>().taxingToAViaDJText();
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
                plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToA = true;
                planeStatus.GetComponent<planeStatus>().taxingToAViaDJText();
                planeStatus.GetComponent<Button>().enabled = false;
                planeStatus.GetComponent<planeStatus>().waitingImage();
                planeMovement.gameObject.SetActive(true);
            }


        }
    }

    }

