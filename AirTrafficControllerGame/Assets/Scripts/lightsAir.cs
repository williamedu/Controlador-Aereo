using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class lightsAir : MonoBehaviour
{
    public Image image;// imagen de la luz verde que va a parpadear

    [Header("booleanos")]
    public bool stop; // detiene la luz
    public bool start; // inicializa la luz verde

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        StartLights(); // empieza la corutina de la luz verde
        Stop(); // para la corutina

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

    public void StartLights()
    {
        //start = true;
        if (start == true)
        {
            StartBlinking();
            start = false;
        }

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
}
