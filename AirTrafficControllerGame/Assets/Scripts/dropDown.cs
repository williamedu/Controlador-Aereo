using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dropDown : MonoBehaviour
{
    public GameObject planeStatus;

    public GameObject plane;
    public TMPro.TMP_Dropdown myDrop;
    public TextMeshProUGUI label;
    public GameObject lightTirilla;
    public GameObject actionIndicator;
    private Transform parent;


    public void Awake()
    {
       parent = transform.parent.parent.parent;
       plane = parent.gameObject;
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
        if (myDrop.value == 1) 
        {
            plane.GetComponent<Aeronave>().PushBackFacingNorthB = true;
            lightTirilla.GetComponentInChildren<lightsTest>().start = true;
            lightTirilla.GetComponentInChildren<lightsTest>().StartLights();
            planeStatus.gameObject.SetActive(true);
            this.gameObject.SetActive(false);


        }
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
