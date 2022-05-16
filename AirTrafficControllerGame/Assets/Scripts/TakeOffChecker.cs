using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeOffChecker : MonoBehaviour
{
    public int takeoffCounter;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tierra")) { int i = 1; takeoffCounter = takeoffCounter + i; }
    }
}
