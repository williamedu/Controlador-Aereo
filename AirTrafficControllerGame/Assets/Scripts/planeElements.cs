using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class planeElements : MonoBehaviour
{
    [Header("gameObjects en la tirilla")]
    public TextMeshProUGUI callSign;
    public TextMeshProUGUI AirCraftModel;
    public TextMeshProUGUI statusPlane;
    public TextMeshProUGUI Stand;
    public GameObject waypointSystem;

    public dropDown dropDown;

     GameObject child;
     GameObject child2;
     GameObject child3;
     GameObject child4;
     GameObject child5;



    [Header("variables")]
    public string callSingn;
    public string modeloDeAeronave;

    string C1 = ("C1");
    string C2 = ("C2");
    string C3 = ("C3");

    string B1 = ("B1");
    string B2 = ("B2");
    string B3 = ("B3");
    string B4 = ("B4");

    string A2 = ("A2");
    string A3 = ("A3");
    string A4 = ("A4");
    string A5 = ("A5");
    string A6 = ("A6");

    // Start is called before the first frame update
    void Start()
    {
        child = transform.GetChild(3).GetChild(0).GetChild(0).GetChild(0).gameObject;
        callSign = child.GetComponent<TextMeshProUGUI>();

        child2 = transform.GetChild(3).GetChild(0).GetChild(0).GetChild(1).gameObject;
        AirCraftModel = child2.GetComponent<TextMeshProUGUI>();

        //child3 = transform.GetChild(3).GetChild(0).GetChild(3).GetChild(0).gameObject;
       // statusPlane = child3.GetComponent<TextMeshProUGUI>();

        child4 = transform.GetChild(3).GetChild(0).GetChild(2).gameObject;
        dropDown = child4.GetComponent<dropDown>();

        child5 = transform.GetChild(3).GetChild(0).GetChild(0).GetChild(2).gameObject;
        Stand = child5.GetComponent<TextMeshProUGUI>();


        callSign.text = callSingn;
        AirCraftModel.text = modeloDeAeronave;

        waypointSystem.GetComponent<Waypoint_Indicator>().textDescription = callSign.text;
    }

    private void OnTriggerEnter(Collider other)
    {
      

        if (other.gameObject.name == "A2S")
        {
            Stand.text = A2;
        }

        if (other.gameObject.name == "A3S")
        {
            Stand.text = A3;
        }
        if (other.gameObject.name == "A4S")
        {
            Stand.text = A4;
        }
        if (other.gameObject.name == "A5S")
        {
            Stand.text = A5;
        }
        if (other.gameObject.name == "A6S")
        {
            Stand.text = A6;
        }

        if (other.gameObject.name == "B1S")
        {
            Stand.text = B1;
        }
        if (other.gameObject.name == "B2S")
        {
            Stand.text = B2;
        }
        if (other.gameObject.name == "B3S")
        {
            Stand.text = B3;
        }
        if (other.gameObject.name == "B4S")
        {
            Stand.text = B4;
        }

        if (other.gameObject.name == "C1S")
        {
            Stand.text = C1;
        }

        if (other.gameObject.name == "C2S")
        {
            Stand.text = C2;
        }
        if (other.gameObject.name == "C3S")
        {
            Stand.text = C3;
        }
    }

    public void coño()
    {
        Debug.Log("se esta llamando la funcion");
    }
    public void Update()
    {
        if (statusPlane == null)
        {
            return;
        }



    }

}
