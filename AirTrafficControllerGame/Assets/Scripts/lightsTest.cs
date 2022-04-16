using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class lightsTest : MonoBehaviour
{
    public GameObject holdShortOf;
    public GameObject takeOff;
    public GameObject TaxyButton;
    public GameObject plane;
    public Image image;
    public bool stop;
    public bool start;
    private Transform parent;
    public bool SHOWt = false;


    public void Awake()
    {
        //codigo para que se referencie la aeronave madre del gameObject
       
        // StartBlinking();
        // plane1 = GetComponent<Aeronave>();
        // plane1 = gameObject.GetComponent<Aeronave>();
    }

    void Start()
    {
        parent = transform.parent.parent.parent.parent;
        plane = parent.gameObject;

        image = GetComponent<Image>();

    }

    public void Update()
    {


        if (plane.GetComponent<Aeronave>().ReadyForDeparture == true)
        {
            takeOff.SetActive(true);
            TaxyButton.SetActive(false);
            stop = true;
        }
        

        if (plane.GetComponent<Aeronave>().PushBackFacingNorthB == false && plane.GetComponent<Aeronave>().isFacingN ==true)
        {
            print("hola llegue");
            stop = true;
            TaxyButton.GetComponent<Button>().enabled = true;
            TaxyButton.gameObject.GetComponent<planeStatus>().readyToTaxytext();
            TaxyButton.GetComponent<planeStatus>().normalImage();
            holdShortOf.SetActive(true);

        }

         if (plane.GetComponent<Aeronave>().PushBackFacingSouthB == false && plane.GetComponent<Aeronave>().isFacingS==true)
        {
            stop = true;
            TaxyButton.GetComponent<Button>().enabled = true;
            TaxyButton.gameObject.GetComponent<planeStatus>().readyToTaxytext();
            TaxyButton.GetComponent<planeStatus>().normalImage();
            holdShortOf.SetActive(true);


        }

        StartLights();
        Stop();

    }
    IEnumerator Blink()
    {
        while (true)
        {
            switch (image.color.a.ToString())
            {
                case "0":
                    image.color = new Color(image.color.r, image.color.g, image.color.b, 1);
                    //Play sound
                    yield return new WaitForSeconds(0.5f);
                    break;
                case "1":
                    image.color = new Color(image.color.r, image.color.g, image.color.b, 0);
                    //Play sound
                    yield return new WaitForSeconds(0.5f);
                    break;
            }
        }
    }

    void StartBlinking()
    {
        StopAllCoroutines();
        StartCoroutine("Blink");
    }

    void StopBlinking()
    {
        StopAllCoroutines();



    }

    public void Stop()
    {
        //stop = true;
        if (stop == true)
        {
            stop = false;
            StopAllCoroutines();
            image.color = new Color(image.color.r, image.color.g, image.color.a, 1);
        }
    }

    public void StartLights()
    {
        //start = true;
            if (start == true)
            {
                StartBlinking();
                start = false;
            }
        
    }

    public void takeOffAction()
    {
        plane.GetComponent<Aeronave>().takeOff = true;
        StartLights();
        start = true;
    }

}