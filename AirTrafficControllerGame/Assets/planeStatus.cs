using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class planeStatus : MonoBehaviour
{
    public GameObject plane;
    public GameObject taxyOptions;
    public TextMeshProUGUI status;
    public string readyToTaxy;
    public string facingNorth;
    public string facingSouth;
    public string taxingToAViaCJ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (plane.GetComponent<Aeronave>().PushBackFacingNorthB == true)
        {
            status.text = facingNorth;
        }

        if (plane.GetComponent<Aeronave>().PushBackFacingSouthB == true)
        {
            status.text = facingSouth;
        }

        if (plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToA == true)
        {
            taxyOptions.gameObject.SetActive(true);
        }
    }

    public void readyToTaxytext()
    {
        status.text = readyToTaxy;
    }

    public void taxingToAViaCJtext()
    {
        status.text = taxingToAViaCJ;
    }
}
