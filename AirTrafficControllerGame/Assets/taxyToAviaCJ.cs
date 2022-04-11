using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class taxyToAviaCJ : MonoBehaviour
{
    public GameObject planeStatus;

    public GameObject plane;
    public TMPro.TMP_Dropdown myDrop;
    public TextMeshProUGUI status;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (myDrop.value == 1)
        {
            plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToA = true;
            planeStatus.gameObject.GetComponent<planeStatus>().taxingToAViaCJtext();
            
            
        }
    }
}
