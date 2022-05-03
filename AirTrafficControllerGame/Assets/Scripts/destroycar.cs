using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroycar : MonoBehaviour
{


    public GameObject pushbackCar;


    private void Start()
    {
        pushbackCar = transform.parent.gameObject;
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PushBackCarsDestroyer"))
        {
            pushbackCar.GetComponent<PushBackCar>().speed = 0;
        }
    }
}
