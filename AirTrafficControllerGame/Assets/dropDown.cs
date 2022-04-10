using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dropDown : MonoBehaviour
{
    public GameObject plane;
    public TMPro.TMP_Dropdown myDrop;
    public TextMeshProUGUI label;

    public string pushBack = "is Pushing Back";

    public void planeActions()
    {
        if (myDrop.value == 1) plane.GetComponent<Aeronave>().PushBackFacingNorthB = true;
        else if (myDrop.value == 2) plane.GetComponent<Aeronave>().PushBackFacingSouthB = true;
        else if (myDrop.value == 3) plane.GetComponent<planeElements>().coño();
        {
            label.text = pushBack;
        }


    }




}
