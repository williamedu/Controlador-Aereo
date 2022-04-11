using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class lightsTest : MonoBehaviour
{

    public GameObject statusPlane;
    public GameObject plane;
    public Image image;
    public bool stop;
    public bool start;
    void Start()
    {
        image = GetComponent<Image>();
       // StartBlinking();
    }

    public void Update()
    {

        if (plane.GetComponent<Aeronave>().PushBackFacingNorthB == false && plane.GetComponent<Aeronave>().transform.position == plane.GetComponent<Aeronave>().PushBackFacingNorthV[3].transform.position)
        {
            stop = true;
            statusPlane.GetComponent<Button>().enabled = true;
            statusPlane.gameObject.GetComponent<planeStatus>().readyToTaxytext();

        }

         if (plane.GetComponent<Aeronave>().PushBackFacingSouthB == false && plane.GetComponent<Aeronave>().transform.position == plane.GetComponent<Aeronave>().PushBackFacingSouthV[3].transform.position)
        {
            stop = true;
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

}