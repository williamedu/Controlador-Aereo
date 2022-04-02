using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeUI : MonoBehaviour
{

    public Camara camaraVariables;
   
    public void cameraMoveAgain()
    {
        camaraVariables.speedH = 4f;
        camaraVariables.speedV = 4;
    }

    void OnMouseDown()
    {
        transform.Find("PlaneUI").gameObject.SetActive(true);
        camaraVariables.speedH = 0;
        camaraVariables.speedV = 0;    
    }
}
