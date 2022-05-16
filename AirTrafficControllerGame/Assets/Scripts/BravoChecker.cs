using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BravoChecker : MonoBehaviour
{
    public int BravoCounter;







    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tierra")) { int i = 1; BravoCounter = BravoCounter + i; }
    }


}
