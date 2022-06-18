using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
//using UnityEngine.Rendering.PostProcessing;


public class MenuManager : MonoBehaviour
{
  
    public VolumeProfile dayTime;
    public VolumeProfile nightTime;
    private DepthOfField depthOfField1;
    private DepthOfField depthOfField2;
  public  bool deactivateDepthOfField = false;
    public bool checkdayfordepthoffield = false;
  public  int ramdonRain;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;
    public GameObject Light5;
    public GameObject Light6;
    public GameObject Light7;
    GameObject Windows;
   public GameObject treeparticle1;
    public GameObject treeparticle2;

    public GameObject Rain;

    public bool CanPass = true;
    public GameObject NightTime;
    public GameObject DayTime;
    public GameObject startMoon;
    public Material [] Skys;
    
    public bool canCross = false;
    public int characterSelection;
    public int characterSelection2;
    public bool characterSelectionn2 = true;
    bool characterSelectionn = true;
    
   public GameObject NPC1;
    
    public GameObject NPC2;
    
    public GameObject NPC3;
   
    public GameObject NPC15;
    
    public GameObject NPC11;
    
    public GameObject NPC12;
    
    public GameObject NPC13;
    
    public GameObject NPC14;
    
    public GameObject NPC20;

    //SECOND LINE OF NPC

    
    public GameObject NPC7;

    
    public GameObject NPC8;

    
    public GameObject NPC9;

    
    public GameObject NPC10;

   
    public GameObject NPC16;

    
    public GameObject NPC17;

    
    public GameObject NPC18;

    
    public GameObject NPC19;

    
    public GameObject NPC23;



    bool checkDay = true;


    private void Awake()
    {
        dayTime.TryGet(out depthOfField1);
        nightTime.TryGet(out depthOfField2);
        characterSelectionn2 = true;
    ChangeMaterial();
        ramdonRain = Random.Range(1, 5);
        if (ramdonRain == 3) { Rain.SetActive(true); }

        if(depthOfField1 == true) { depthOfField1.active = false; }
        if(depthOfField2 == true) { depthOfField2.active = false; }
    }

    // Start is called before the first frame update
    void Start()
    {

        
        NPC7 = GameObject.Find("NPC7");
        NPC8 = GameObject.Find("NPC8");
        NPC9 = GameObject.Find("NPC9");
        NPC10 = GameObject.Find("NPC10");
        NPC16 = GameObject.Find("NPC16");
        NPC17 = GameObject.Find("NPC17");
        NPC18 = GameObject.Find("NPC18");
        NPC19 = GameObject.Find("NPC19");
        NPC23 = GameObject.Find("NPC23");

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
        CharacterSelection2();
        
       

        QualitySettings.pixelLightCount = 25;
       
    }

    private void Update()
    {
        
        if (deactivateDepthOfField == true)
        {
            if (RenderSettings.skybox == Skys[0])
            {
                depthOfField2.active = false;
                deactivateDepthOfField = false;
            }

            if (RenderSettings.skybox == Skys[1])
            {
                depthOfField1.active = false;
                deactivateDepthOfField = false;
            }
        }

        if (checkdayfordepthoffield == true)
        {
            if (RenderSettings.skybox == Skys[0])
            {
                activateDethOfField2();
                checkdayfordepthoffield = false;
            }

            if (RenderSettings.skybox == Skys[1])
            {
                activateDethOfField1();
                checkdayfordepthoffield = false;
            }
        }
        //print(RenderSettings.skybox);
        if (checkDay == true)
        {
            if (RenderSettings.skybox == Skys[0])
            {
                
                startMoon.SetActive(true);
                checkDay = false;
                DayTime.SetActive(false);
                NightTime.SetActive(true);
                treeparticle1.SetActive(true);
                treeparticle2.SetActive(true);
                

            }
            else if (RenderSettings.skybox == Skys[1])
            {

                NightTime.SetActive(false);
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
                NPC1.GetComponent<NPCmovement>().sitiation1 = 1;
                characterSelectionn = false;
            }
            if (characterSelection == 2)
            {
                NPC2.GetComponent<NPCmovement>().sitiation1 = 1;
                characterSelectionn = false;
            }
            if (characterSelection == 3)
            {
                NPC3.GetComponent<NPCmovement>().sitiation1 = 1;
                characterSelectionn = false;
            }
            if (characterSelection == 4)
            {
                NPC11.GetComponent<NPCmovement>().sitiation1 = 1;
                characterSelectionn = false;
            }
            if (characterSelection == 5)
            {
                NPC13.GetComponent<NPCmovement>().sitiation1 = 1;
                characterSelectionn = false;
            }
            if (characterSelection == 6)
            {
                NPC14.GetComponent<NPCmovement>().sitiation1 = 1;
                characterSelectionn = false;
            }
            if (characterSelection == 7)
            {
                NPC15.GetComponent<NPCmovement>().sitiation1 = 1;
                characterSelectionn = false;
            }
            if (characterSelection == 8)
            {
                NPC20.GetComponent<NPCmovement>().sitiation1 = 1;
                characterSelectionn = false;
            }
        }

        // character selection 2

        if (characterSelectionn2 == true)
        {
            if (characterSelection2 == 1)
            {
                NPC7.GetComponent<NPCmovement>().sitiation2 = 1;
                characterSelectionn2 = false;
            }
            if (characterSelection2 == 2)
            {
                NPC8.GetComponent<NPCmovement>().sitiation2 = 1;
                characterSelectionn2 = false;
            }
            if (characterSelection2 == 3)
            {
                NPC9.GetComponent<NPCmovement>().sitiation2 = 1;
                characterSelectionn2 = false;
            }
            if (characterSelection2 == 4)
            {
                NPC10.GetComponent<NPCmovement>().sitiation2 = 1;
                characterSelectionn2 = false;
            }

            if (characterSelection2 == 5)
            {
                NPC16.GetComponent<NPCmovement>().sitiation2 = 1;
                characterSelectionn2 = false;
            }

            if (characterSelection2 == 6)
            {
                NPC17.GetComponent<NPCmovement>().sitiation2 = 1;
                characterSelectionn2 = false;
            }

            if (characterSelection2 == 7)
            {
                NPC18.GetComponent<NPCmovement>().sitiation2 = 1;
                characterSelectionn2 = false;
            }

            if (characterSelection2 == 8)
            {
                NPC19.GetComponent<NPCmovement>().sitiation2 = 1;
                characterSelectionn2 = false;
            }
            if (characterSelection2 == 9)
            {
                NPC23.GetComponent<NPCmovement>().sitiation2 = 1;
                characterSelectionn2 = false;
            }

            
        }


    }

    
   public void activateDethOfField1()
    {
        depthOfField1.active = true;
        print("se activo erl depth of fiel del dia");
    }

    public void activateDethOfField2()
    {
        depthOfField2.active = true;
        print("se activo erl depth of fiel de la noche");
    }

    public void checkdepthoffielday()
    {
        checkdayfordepthoffield = true;
        print("se presiono any key");
    }

    public void DeactivateDepthOfField()
    {
        deactivateDepthOfField = true;
    }


    public void ChangeMaterial()
    {
        RenderSettings.skybox = SelectRandomMaterial();
    }

    public void CharacterSelection()
    {
        characterSelection = Random.Range(1, 8); 
    }

    public void CharacterSelection2()
    {
        characterSelection2 = Random.Range(1, 9);
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

    private void OnApplicationQuit()
    {
        depthOfField1.active = false;
        depthOfField2.active = false;
    }
}
