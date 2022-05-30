using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaChecker : MonoBehaviour
{

    public static int DeltaCounter;
    public static int CharlieCounter;








    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("DC"))  { if (other.CompareTag("Tierra")) { int i = 1; DeltaCounter = DeltaCounter + i; } }
        if (gameObject.CompareTag("CC"))  { if (other.CompareTag("Tierra")) {  int i = 1; CharlieCounter = CharlieCounter + i; } }
    }












}
