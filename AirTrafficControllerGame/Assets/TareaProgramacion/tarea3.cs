using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea3 : MonoBehaviour
{
    //ALGORITMO FIBONACCI

    public int A = 0;
    public int B = 1;
    public int C = 0;




    // Start is called before the first frame update
    void Start()
    {
        print("ESCRIBIR SECUENCIA DE NUMEROS FIBONACCI");
        while (C <= 1000)
        {
            C = A + B;
            print(C);
            A = B;
            B = C;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
