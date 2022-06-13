using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;


public class MenuManager : MonoBehaviour
{

  public  int ramdonRain;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;
    public GameObject Light5;
    public GameObject Light6;
    public GameObject Light7;
    GameObject Windows;

    public GameObject Rain;

    public bool CanPass = true;
    public GameObject NightTime;
    public GameObject DayTime;
    public GameObject startMoon;
    public Material [] Skys;
    public Volume volume;
    public bool canCross = false;
    public int characterSelection;
    bool characterSelectionn = true;
    [HideInInspector]
   public GameObject NPC1;
    [HideInInspector]
    public GameObject NPC2;
    [HideInInspector]
    public GameObject NPC3;
    [HideInInspector]
    public GameObject NPC15;
    [HideInInspector]
    public GameObject NPC11;
    [HideInInspector]
    public GameObject NPC12;
    [HideInInspector]
    public GameObject NPC13;
    [HideInInspector]
    public GameObject NPC14;
    [HideInInspector]
    public GameObject NPC20;
    

    bool checkDay = true;


    private void Awake()
    {
        ChangeMaterial();
        ramdonRain = Random.Range(1, 5);
        if (ramdonRain == 3) { Rain.SetActive(true); }
    }

    // Start is called before the first frame update
    void Start()
    {
        NPC1 = GameObject.Find("NPC1");
        NPC2 = GameObject.Find("NPC2");
        NPC3 = GameObject.Find("NPC3");
        NPC11 = GameObject.Find("NPC11");
        NPC12 = GameObject.Find("NPC12");
        NPC13 = GameObject.Find("NPC13");
        NPC14 = GameObject.Find("NPC14");
        NPC15 = GameObject.Find("NPC15");
        NPC20 = GameObject.Find("NPC20");
        Windows = GameObject.Find("window");
        CharacterSelection();


        QualitySettings.pixelLightCount = 25;
       
    }

    private void Update()
    {
        //print(RenderSettings.skybox);
        if (checkDay == true)
        {
            if (RenderSettings.skybox == Skys[0])
            {
                
                startMoon.SetActive(true);
                checkDay = false;
                
                NightTime.SetActive(true);

            }
            else if (RenderSettings.skybox == Skys[1])
            {

                
                DayTime.SetActive(true);
                DeactivateLights();
                checkDay = false;
                Windows.SetActive(false);
            }
                
        }
        
        if (characterSelectionn == true)
        {
            if (characterSelection == 1)
            {
                NPC1.GetComponent<NPCmovement>().cross = 1;
                characterSelectionn = false;
            }
            if (characterSelection == 2)
            {
                NPC2.GetComponent<NPCmovement>().cross = 1;
                characterSelectionn = false;
            }
            if (characterSelection == 3)
            {
                NPC3.GetComponent<NPCmovement>().cross = 1;
                characterSelectionn = false;
            }
            if (characterSelection == 4)
            {
                NPC11.GetComponent<NPCmovement>().cross = 1;
                characterSelectionn = false;
            }
            if (characterSelection == 5)
            {
                NPC13.GetComponent<NPCmovement>().cross = 1;
                characterSelectionn = false;
            }
            if (characterSelection == 6)
            {
                NPC14.GetComponent<NPCmovement>().cross = 1;
                characterSelectionn = false;
            }
            if (characterSelection == 7)
            {
                NPC15.GetComponent<NPCmovement>().cross = 1;
                characterSelectionn = false;
            }
            if (characterSelection == 8)
            {
                NPC20.GetComponent<NPCmovement>().cross = 1;
                characterSelectionn = false;
            }
        }

        
    }

    public void ChangeMaterial()
    {
        RenderSettings.skybox = SelectRandomMaterial();
    }

    public void CharacterSelection()
    {
        characterSelection = Random.Range(1, 8); 
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
        
       
    }
}
