using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;


public class MenuManager : MonoBehaviour
{


    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;
    public GameObject Light5;
    public GameObject Light6;
    public GameObject Light7;

    public GameObject Rain;

    public bool CanPass = true;
    public GameObject NightTime;
    public GameObject DayTime;
    public GameObject startMoon;
    public Material [] Skys;
    public Volume volume;

    bool checkDay = true;


    private void Awake()
    {
        ChangeMaterial();
        
    }

    // Start is called before the first frame update
    void Start()
    {
       
        
        QualitySettings.pixelLightCount = 25;
       
    }

    private void Update()
    {
        //print(RenderSettings.skybox);
        if (checkDay == true)
        {
            if (RenderSettings.skybox == Skys[0])
            {
                print("es de noche");
                startMoon.SetActive(true);
                checkDay = false;
                
                NightTime.SetActive(true);

            }
            else if (RenderSettings.skybox == Skys[1])
            {

                print("es de dia");
                DayTime.SetActive(true);
                DeactivateLights();
                checkDay = false;
            }
                
        }
        

        
    }

    public void ChangeMaterial()
    {
        RenderSettings.skybox = SelectRandomMaterial();
    }

    private Material SelectRandomMaterial()
    {
        return Skys[Random.Range(0, Skys.Length)]; 
    }

   

    void DeactivateLights()
    {
        Light1.SetActive(false);
        Light2.SetActive(false);
        Light3.SetActive(false);
        Light4.SetActive(false);
        Light5.SetActive(false);
        Light6.SetActive(false);
        print("se apagaron las lucces");
       
    }
}
