using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontAndBack : MonoBehaviour
{

    public GameObject parent;

    public bool colliing = false;



    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent.gameObject;

        

    }

    // Update is called once per frame
    void Update()
    {



    }


    void OnTriggerEnter(Collider other)
    {

        //-------------------------para detener l;a aeronave si esta esta cerca de otra-----------------------------------------------------------------------------
        if (gameObject.CompareTag("Front")) { if (other.gameObject.CompareTag("Back")) {  print(gameObject.name + " choco con "  +  other.gameObject.name); parent.GetComponent<Aeronave>().speed = 0; parent.GetComponent<Aeronave>().MoveSpeed = 0; colliing = true; } }
        
    }


    private void OnTriggerExit(Collider other)
    {
        if(gameObject.CompareTag("Front")) 
        {if (other.gameObject.CompareTag("Back")) { parent.GetComponent<Aeronave>().speed = 5; parent.GetComponent<Aeronave>().Invoke("TaxiSpeed", 1); colliing = false; } }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Back")) { if (gameObject.CompareTag("Front")) { parent.GetComponent<Aeronave>().MoveSpeed = 0; print("se mantiene 0 la velocidad"); } }
    }

}

