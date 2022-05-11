using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationsLights : MonoBehaviour
{
    public GameObject padre;
    public Aeronave parent;




    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent.GetComponent<Aeronave>();
        padre = transform.parent.gameObject;
        //gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.CompareTag("TaxingLight") && parent.ReadyToTaxi == true) { gameObject.SetActive(false); print("LightsOn"); }



        
    }
}
