using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifStatement : MonoBehaviour
{
   public int numberl = 10;
    public int number2 = 20;
    public GameObject hola;

    private void Start()
    {
      if (number2 > numberl)
        {
            print("number2 es mayor que numberl ");
        }
      if (numberl > number2)
        {
            print("number1 es mayor que number2 ");

        }
    }

}
