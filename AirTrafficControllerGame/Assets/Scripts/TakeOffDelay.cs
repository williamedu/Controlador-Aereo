using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeOffDelay : MonoBehaviour
{
    public int takeOffDelay;

     public GameManager GM;

    private void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
    }
    private void Update()
    {
        if (takeOffDelay == 2) { gameOver(); }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tierra")) { suma();  }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Tierra")) { resta(); }
    }
    private void OnTriggerStay(Collider other)
    {
        
    }

    void suma()
    {
        takeOffDelay = takeOffDelay + 1;
    }

    void resta()
    {
        takeOffDelay = takeOffDelay - 1;
    }



    void gameOver()
    {
        GM.gameOver = true;
    }


}
