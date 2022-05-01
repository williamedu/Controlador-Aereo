using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea4 : MonoBehaviour
{

    public string[] Correcto = { "Muy Bien", "Magnifico", "Muy Bien Trabajo", "Enhorabuena campeon!" };

    public string[] InCorrecto = {  "Que mal", "mala suerte", "esa no es la respuesta correcta","Creo que estas reprobado" };

    


    private void Start()
    {
        int aleatorio = Random.Range(1, 9);

        print("Multiplica Multiplicador, INICIAMOS!");

        int correcta = 0;

        for (int i = 1; i<= 15; i++) 
        {
            int intentos = 0;
            int num1 = Random.Range(1, 2);
            int num2 = Random.Range(1, 5); int respuesta = aleatorio;
            do
            {
                print(i + " cuanto es " + num1 + " por " + num2 + " ? ");
                print(respuesta);
                if (num1 * num2 == respuesta)
                {
                    print(Correcto[Random.Range(1, 4)]);

                    intentos = 3;

                    correcta++;
                }
                else
                {
                    intentos++;
                    print(InCorrecto[Random.Range(1, 4)]);

                    if (intentos == 2)
                    {
                        print("llevas 2 intentos, te queda uno!");
                    }
                    else
                    {
                        if (intentos == 3)
                        {
                            int calificacion = correcta * 100 / 15;
                            print("tu calificacion final es de " + calificacion + "%");


                        }
                    }
                }
            } while (intentos < 3);
            }
        }
    }






    





















