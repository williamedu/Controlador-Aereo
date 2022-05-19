using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class routeDropDown : MonoBehaviour
{

    public TMPro.TMP_Dropdown myDrop;
    private Transform parentPlane;
    private GameObject parentMyDrop;
    public GameObject plane;



    // Start is called before the first frame update
    void Start()
    {

        parentPlane = transform.parent.parent.parent;
        plane = parentPlane.gameObject;

        parentMyDrop = transform.gameObject;
        myDrop = parentMyDrop.GetComponent<TMP_Dropdown>();

    }

    // Update is called once per frame
    void Update()
    {
        if (myDrop.value == 1)
        {
            plane.GetComponent<Aeronave>().Clearence = true;
        }
    }
}
