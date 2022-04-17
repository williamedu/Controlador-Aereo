using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dropDown : MonoBehaviour
{
    [Header("gameObjects en DropDown")]

    public GameObject actionIndicator;
    public GameObject lightTirilla;
    public GameObject planeStatus;
    public GameObject plane;

    [Header("textMeshPros")]

    public TMPro.TMP_Dropdown myDrop;
    public TextMeshProUGUI label;

    [Header("Trasnform Automatizado")]

    private Transform parent;

    public void Awake()
    {
       parent = transform.parent.parent.parent; // PARA AUTOMATIZAR EL PLANE GAMEOBJECT
       plane = parent.gameObject;// PARA AUTOMATIZAR EL PLANE GAMEOBJECT
                                 // plane = parent.gameObject;
    }
    public void Start()
    {
        

       // actionIndicator = parent.gameObject;
      //  actionIndicator = parent.gameObject;

        //actionIndicator = parent.parent.gameObject;
        
        //planeStatus.GetComponent<planeStatus>().getReference();

        // necesita estar desactivado al principio, es el boton de taxy
        //planeStatus.SetActive(false);
    }
    public void planeActions()
    {

        // PARA EL DROPDOWN DEL PUSH BACK FACING NORTH
        if (myDrop.value == 1) 
        {
            plane.GetComponent<Aeronave>().PushBackFacingNorthB = true; // ACTIVA BOLEANO PUSHBACK FN AERONAVE
            lightTirilla.GetComponentInChildren<lightsTest>().start = true; //ACTIVA LUCES EN TIRILLA
            lightTirilla.GetComponentInChildren<lightsTest>().StartLights();//ACTIVA LUCES EN TIRILLA
            planeStatus.gameObject.SetActive(true); // ACTIVA EL BOTON DE TAXY 
            this.gameObject.SetActive(false); //DESACTIVA EL DROPDOWN GAMEB=OBJECT


        }

        //HACE LO MISMO DE ARRIBA PERO PARA LA OTRA SELECCION DE DROPDOWN
        if (myDrop.value == 2)
        {
            plane.GetComponent<Aeronave>().PushBackFacingSouthB = true;
            lightTirilla.GetComponentInChildren<lightsTest>().start = true;
            lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
            planeStatus.gameObject.SetActive(true);
            this.gameObject.SetActive(false);


        }

        
    }

    
    public void Update()
    {
        //planeIndicators();

    }

    /*
   public void planeIndicators()
   {
        if (plane.GetComponent<Aeronave>().PushBackFacingNorthB == false)
        {
            lightTirilla.GetComponentInChildren<lightsTest>().StartLights();


        }

        if (plane.GetComponent<Aeronave>().PushBackFacingSouthB == true)
        {
            lightTirilla.GetComponentInChildren<lightsTest>().start = true;


       }
    }
    */

}
