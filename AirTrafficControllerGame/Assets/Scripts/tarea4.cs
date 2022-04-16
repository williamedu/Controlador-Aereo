using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea4 : MonoBehaviour
{

    
    int numeroDePersonas = 4;


    void Start()
    {
        while (numeroDePersonas > 0)
        {
            Debug.Log("ahora hay " + numeroDePersonas + " personas en la habitacion" );
            numeroDePersonas--;
        }
    }
}

