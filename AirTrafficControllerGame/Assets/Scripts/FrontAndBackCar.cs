using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontAndBackCar : MonoBehaviour
{
    // Start is called before the first frame update

    
    
    public CarCircuit car;

    private void Start()
    {
        car = transform.parent.parent.GetComponent<CarCircuit>();
        
    }









    public void OnTriggerStay(Collider other)
    {
        if (gameObject.CompareTag("Front")) { if (other.gameObject.CompareTag("Back")) { car.speed = 0; print("se dio la condicion para parar el carro"); } }
    }


    private void OnTriggerExit(Collider other)
    {
        if (gameObject.CompareTag("Front")) { if (other.gameObject.CompareTag("Back")) { Invoke("ccontinue", 2);  } }
    }

    void ccontinue()
    {
        car.speed = 4;
        CancelInvoke();
    }







}
