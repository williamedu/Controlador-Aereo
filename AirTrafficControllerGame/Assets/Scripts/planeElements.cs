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
    public dropDown dropDown;

     GameObject child;
     GameObject child2;
     GameObject child3;
     GameObject child4;


    [Header("variables")]
    public string callSingn;
    public string modeloDeAeronave;

    // Start is called before the first frame update
    void Start()
    {
        child = transform.GetChild(3).GetChild(0).GetChild(0).GetChild(0).gameObject;
        callSign = child.GetComponent<TextMeshProUGUI>();

        child2 = transform.GetChild(3).GetChild(0).GetChild(0).GetChild(1).gameObject;
        AirCraftModel = child2.GetComponent<TextMeshProUGUI>();

        child3 = transform.GetChild(3).GetChild(0).GetChild(1).GetChild(0).gameObject;
        statusPlane = child3.GetComponent<TextMeshProUGUI>();

        child4 = transform.GetChild(3).GetChild(0).GetChild(1).gameObject;
        dropDown = child4.GetComponent<dropDown>();


        callSign.text = callSingn;
        AirCraftModel.text = modeloDeAeronave;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void coño()
    {
        Debug.Log("se esta llamando la funcion");
    }
}
