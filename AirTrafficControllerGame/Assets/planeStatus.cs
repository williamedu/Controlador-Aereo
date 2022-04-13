using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class planeStatus : MonoBehaviour
{
    public GameObject imageToChange;
    public Sprite sprite;
    public Sprite sprite2;
    public GameObject plane;
    public GameObject taxyOptions;
    public TextMeshProUGUI status;
    public string readyToTaxy;
    public string facingNorth;
    public string facingSouth;
    public string taxingToAViaCJ;
    public string taxingToAViaDJ;
    public string taxingToBViaCJ;
    public string taxingToBViaDJ;
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
