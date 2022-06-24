using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea : MonoBehaviour
{
   public int numberl = 10;
     public int number2 = 20;

    // Start is called before the first frame update
    void Start()
    {
        if (number2 > numberl)
        {
            print("number2 es mayor que number 1");
            print(number2);
        }

        if (numberl > 5)
        {
            print("numbner1 es mayor que 5");
        }


        if (numberl < 20)
        {
            print("number1 es menor que 20");
        }
    }

    
}
