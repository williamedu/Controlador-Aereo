using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class planeStatus : MonoBehaviour
{
    public GameObject imageToChange;
    public GameObject taxyOptions;
    public GameObject plane;
    public Sprite sprite2;
    public Sprite sprite;

    public TextMeshProUGUI status;
    private Transform parent;
    
    public string readyToTaxy;
    public string facingNorth;
    public string facingSouth;
    public string taxingToAViaCJ;
    public string taxingToAViaDJ;
    public string taxingToBViaCJ;
    public string taxingToBViaDJ;

    private void Awake()
    {
        parent = transform.parent.parent.parent;

        plane = parent.gameObject;
    }

    void Start()
    {
        

        this.gameObject.SetActive(false);

    }

    public void getReference()
    {
       // plane = parent.gameObject;

    }
    // Update is called once per frame
    void Update()
    {

        getReference();
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
            taxyOptions.gameObject.SetActive(false);
        }

        if (plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToA == true)
        {
            taxyOptions.gameObject.SetActive(false);
        }

        if (plane.GetComponent<Aeronave>().taxiRunWay17ViaCJToB == true)
        {
            taxyOptions.gameObject.SetActive(false);
        }

        if (plane.GetComponent<Aeronave>().taxiRunWay17ViaDJToB == true)
        {
            taxyOptions.gameObject.SetActive(false);
        }
    }

    public void normalImage()
    {
        imageToChange.GetComponent<Image>().sprite = sprite;

    }

    public void waitingImage()
    {
        imageToChange.GetComponent<Image>().sprite = sprite2;

    }
    public void readyToTaxytext()
    {
        status.text = readyToTaxy;
       
    }

    public void taxingToAViaCJtext()
    {
        status.text = taxingToAViaCJ;
    }

    public void taxingToAViaDJText()
    {
        status.text = taxingToAViaDJ;

    }

    public void taxingToBViaCJText()
    {
        status.text = taxingToBViaCJ;
    }

    public void taxingToBViaDJText()
    {
        status.text = taxingToBViaDJ;

    }


}
