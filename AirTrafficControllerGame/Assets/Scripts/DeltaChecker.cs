using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaChecker : MonoBehaviour
{

    public int DeltaCounter;








    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tierra")) { int i = 1; DeltaCounter = DeltaCounter + i; }
    }












}
