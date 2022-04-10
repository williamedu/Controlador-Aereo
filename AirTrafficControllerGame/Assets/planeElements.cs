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

    [Header("variables")]
    public string callSingn;
    public string modeloDeAeronave;

    // Start is called before the first frame update
    void Start()
    {
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
