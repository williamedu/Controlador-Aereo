using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine;

public class approachAndGroundAnim : MonoBehaviour
{
    //public Animator Ground;
    //public Animator Approach;

    public Image GroundImage;
    public Image ApproachImage;

    public bool GroundSelected  ;
    public bool ApproachSelected  ;

    public void Start()
    {
        GroundImage = GameObject.FindGameObjectWithTag("GroundButton").gameObject.GetComponent<Image>();
        ApproachImage = GameObject.FindGameObjectWithTag("ApproachButton").gameObject.GetComponent<Image>();



        GroundSelected = true;
        ApproachSelected = false;
    }

    private void Update()
    {


        /*
        if (GroundSelected == true)
        {
            changeGroundAlfaFull();
            changeApproachAlfaHalf();
           // changeApproachAlfaHalf();
        }
        else
        {
            changeGroundAlfaHalf();
            changeApproachAlfaFull();
        }

        /*
        if (GroundSelected == false)
        {
            changeGroundAlfaHalf();
           // changeApproachAlfaFull();

        }

        if (ApproachSelected == true)
        {
            changeApproachAlfaFull();
        }

        if (ApproachSelected == false)
        {
            changeApproachAlfaHalf();
        }
        */

    }


    public void changeGroundAlfaHalf()
    {
        // este codigo cambia el alfa del boton
        Color a = GroundImage.color;
        a.a = 0.5f;
        GroundImage.color = a;
        changeApproachAlfaFull();
    }
    public void changeGroundAlfaFull()
    {
        // este codigo cambia el alfa del boton
        Color a = GroundImage.color;
        a.a = 1f;
        GroundImage.color = a;
        changeApproachAlfaHalf();
    }







    public void changeApproachAlfaHalf()
    {
        // este codigo cambia el alfa del boton
        Color a = ApproachImage.color;
        a.a = 0.5f;
        ApproachImage.color = a;
    }
    public void changeApproachAlfaFull()
    {
        // este codigo cambia el alfa del boton
        Color a = ApproachImage.color;
        a.a = 1f;
        ApproachImage.color = a;
    }

    public void groundTrue()
    {
        GroundSelected = true;
    }

    public void groundFalse()
    {
        GroundSelected = false;
    }

    public void ApproachTrue()
    {
        ApproachSelected = true;
    }

    public void ApproachFalse()
    {
        ApproachSelected = false;
    }
}
