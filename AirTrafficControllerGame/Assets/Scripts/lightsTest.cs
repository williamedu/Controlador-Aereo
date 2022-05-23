using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class lightsTest : MonoBehaviour
{
    public AudioManager audioManager;
    [Header("gameObjects en LightsText")]

    public GameObject holdShortOf;
    public GameObject TaxyButton;
    public GameObject takeOff;
    public GameObject plane;
    public GameObject StopButton; // para quitar el boton de stop when ready for departure


    [Header("imagenh de la luz Tirilla")]
    public Image image;

    [Header("booleanos")]
    public bool stop;
    public bool start;

    private Transform parent;
    private Transform getChild;


    public void Awake()
    {
        //codigo para que se referencie la aeronave madre del gameObject
       
        // StartBlinking();
        // plane1 = GetComponent<Aeronave>();
        // plane1 = gameObject.GetComponent<Aeronave>();
    }

    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        // referencian al plane automatico
        parent = transform.parent.parent.parent.parent;
        plane = parent.gameObject;
        image = GetComponent<Image>();// para la imagen del stop
        // estas 2 lineas de codigo referencian el stop button automatico
        getChild = transform.parent.parent;
        StopButton = getChild.GetChild(7).gameObject;

    }

    public void Update()
    {


        if (plane.GetComponent<Aeronave>().ReadyForDeparture == true)
        {
            takeOff.SetActive(true);
            TaxyButton.SetActive(false);
            stop = true;
            StopButton.SetActive(false);
            holdShortOf.SetActive(false);
        }
        

        if (plane.GetComponent<Aeronave>().PushBackFacingNorthB == false && plane.GetComponent<Aeronave>().isFacingN ==true)
        {
            stop = true;
            TaxyButton.GetComponent<Button>().enabled = true;
            TaxyButton.gameObject.GetComponent<planeStatus>().readyToTaxytext();
            TaxyButton.GetComponent<planeStatus>().normalImage();
            


        }

         if (plane.GetComponent<Aeronave>().PushBackFacingSouthB == false && plane.GetComponent<Aeronave>().isFacingS==true)
        {
            stop = true;
            TaxyButton.GetComponent<Button>().enabled = true;
            TaxyButton.gameObject.GetComponent<planeStatus>().readyToTaxytext();
            TaxyButton.GetComponent<planeStatus>().normalImage();
            



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