using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearenceChecker : MonoBehaviour
{
    GameManager GM;

    private void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
    }







    private void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("Tierra"))
        {
            if(other.transform.parent.GetComponent<Aeronave>().Clearence == false) { GM.gameOver = true; }
        }
    }


}
