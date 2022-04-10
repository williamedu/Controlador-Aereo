using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea2 : MonoBehaviour
{
    public int N;
   public int X;
   public int C;



    // Start is called before the first frame update
    void Start()
    {














    }

    // Update is called once per frame
    void Update()
    {
        X = 1;
        while (X <= N)
        {


            if (N % X == 0)
            {
                C = C + 1;
            }
            X = X + 1;
        }
        if (C == 2)
        {
            print("N, es un numero primo");

        }
        else { print("N, no es un numero primo "); }
        
    }
}
