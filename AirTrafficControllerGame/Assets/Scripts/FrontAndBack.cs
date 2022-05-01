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
        if (gameObject.CompareTag("Front")) { if (other.gameObject.CompareTag("Back")) { if (parent.gameObject.CompareTag("Visual") || parent.gameObject.CompareTag("West") || parent.gameObject.CompareTag("Final")) { parent.GetComponent<Approach>().speed = 0; } else { parent.GetComponent<Aeronave>().speed = 0; parent.GetComponent<Aeronave>().MoveSpeed = 0; colliing = true; } } }
        
    }


    private void OnTriggerExit(Collider other)
    {
        if (gameObject.CompareTag("Front"))
        { if (other.gameObject.CompareTag("Back")) { if (parent.gameObject.CompareTag("Visual") || parent.gameObject.CompareTag("West") || parent.gameObject.CompareTag("Final")) { print("aeronave de airecontinuo su camino despues de salir del trigger"); parent.GetComponent<Approach>().Invoke("TaxiSpeed", 1.5f); } else { print("deberia tacear c1"); parent.GetComponent<Aeronave>().speed = 5; parent.GetComponent<Aeronave>().Invoke("TaxiSpeed", 1); colliing = false; } } }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Back")) { if (gameObject.CompareTag("Front")) { if (parent.gameObject.CompareTag("Visual") || parent.gameObject.CompareTag("West") || parent.gameObject.CompareTag("Final")) { parent.GetComponent<Approach>().speed = 0; } else { parent.GetComponent<Aeronave>().MoveSpeed = 0; print("se mantiene 0 la velocidad"); } } }
    }

}

