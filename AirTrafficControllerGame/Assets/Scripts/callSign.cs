using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class callSign : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public GameObject plane;




    void Example()
    {
        textDisplay.text = "Example Text";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //textDisplay.text = "Example Text";
       // textDisplay.text = GetComponent<planeElements>().callSingn;
    }
}
