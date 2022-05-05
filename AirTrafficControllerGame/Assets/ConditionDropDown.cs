using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ConditionDropDown : MonoBehaviour
{
    public TMPro.TMP_Dropdown myDrop;
    public GameObject continueApproach;
    public Image image;

    public void Start()
    {
        image = GetComponent<Image>();
    }

    public void planeActionsTirilla()
    {
        if (myDrop.value == 1)
        {
            continueApproach.GetComponent<Button>().enabled = true;
            
            
        }
    }
}
