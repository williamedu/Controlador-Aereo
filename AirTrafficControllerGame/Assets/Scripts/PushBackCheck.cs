using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBackCheck : MonoBehaviour
{

    public bool gameOver = false;

    public GameManager GM;
    public bool checke = false;
    [Header("tirillas A ")]
    public GameObject A2;
    public GameObject A3;
    public GameObject A4;
    public GameObject A5;
    public GameObject A6;

    [Header("tirillas B ")]
    public GameObject B1;
    public GameObject B2;
    public GameObject B3;
    public GameObject B4;


    public int AirPlanesFacingNorth;
    public int AirPlanesFacingSouth;

    public int AirPlanesGoingNoth;
    public int AirPlanesGoingSouth;





    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        A2 = GameObject.FindGameObjectWithTag("A2");
        A3 = GameObject.FindGameObjectWithTag("A3");
        A4 = GameObject.FindGameObjectWithTag("A4");
        A5 = GameObject.FindGameObjectWithTag("A5");
        A6 = GameObject.FindGameObjectWithTag("A6");
        B1 = GameObject.FindGameObjectWithTag("B1");
        B2 = GameObject.FindGameObjectWithTag("B2");
        B3 = GameObject.FindGameObjectWithTag("B3");
        B4 = GameObject.FindGameObjectWithTag("B4");
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (checke == true) 
        {

            if (A3.GetComponent<Aeronave>().isFacingN == true && A2.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
            if (A3.GetComponent<Aeronave>().isFacingN == true && B1.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
            if (A3.GetComponent<Aeronave>().isFacingN == true && B2.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
            if (A3.GetComponent<Aeronave>().isFacingN == true && B3.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
            //----------------------------------GAME OVER A2------------------------------------------------------------------------------
            if (A2.GetComponent<Aeronave>().isFacingS == true && A3.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
            if (A2.GetComponent<Aeronave>().isFacingN == true && B1.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
            if (A2.GetComponent<Aeronave>().isFacingN == true && B2.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
            if (A2.GetComponent<Aeronave>().isFacingN == true && B3.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
            //----------------------------------GAME OVER B1------------------------------------------------------------------------------
            if (B1.GetComponent<Aeronave>().isFacingS == true && A2.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
            if (B1.GetComponent<Aeronave>().isFacingS == true && A3.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
            if (B1.GetComponent<Aeronave>().isFacingN == true && B2.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
            if (B1.GetComponent<Aeronave>().isFacingN == true && B3.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
            //----------------------------------GAME OVER B2------------------------------------------------------------------------------
            if (B2.GetComponent<Aeronave>().isFacingS == true && B1.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
            if (B2.GetComponent<Aeronave>().isFacingS == true && A2.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
            if (B2.GetComponent<Aeronave>().isFacingS == true && A3.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
            if (B2.GetComponent<Aeronave>().isFacingN == true && B3.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
            //----------------------------------GAME OVER B3------------------------------------------------------------------------------
            if (B3.GetComponent<Aeronave>().isFacingS == true && B2.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
            if (B3.GetComponent<Aeronave>().isFacingS == true && B1.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
            if (B3.GetComponent<Aeronave>().isFacingS == true && A2.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
            if (B3.GetComponent<Aeronave>().isFacingS == true && A3.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }

        }
    }


    private void OnTriggerEnter(Collider other)
    {
       
        
        






        //if (A2.GetComponent<Aeronave>().isFacingN == true && B2.GetComponent<Aeronave>().isFacingS == true) { gameOver = true; } 

    }

    public void OnTriggerStay(Collider other)
    {
       if (other.gameObject.CompareTag("Tierra"))
        {
            checke = true;
          
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        checke = false;

    }
}


// if (A3.GetComponent<Aeronave>().isFacingN == true && A2.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
//if (A3.GetComponent<Aeronave>().isFacingN == true && B1.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
//if (A3.GetComponent<Aeronave>().isFacingN == true && B2.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
//if (A3.GetComponent<Aeronave>().isFacingN == true && B3.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
//----------------------------------GAME OVER A2------------------------------------------------------------------------------
//if (A2.GetComponent<Aeronave>().isFacingS == true && A3.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
////if (A2.GetComponent<Aeronave>().isFacingN == true && B1.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
//if (A2.GetComponent<Aeronave>().isFacingN == true && B2.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
//if (A2.GetComponent<Aeronave>().isFacingN == true && B3.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
//----------------------------------GAME OVER B1------------------------------------------------------------------------------
//if (B1.GetComponent<Aeronave>().isFacingS == true && A2.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
//if (B1.GetComponent<Aeronave>().isFacingS == true && A3.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
//if (B1.GetComponent<Aeronave>().isFacingN == true && B2.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
//if (B1.GetComponent<Aeronave>().isFacingN == true && B3.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
//----------------------------------GAME OVER B2------------------------------------------------------------------------------
//if (B2.GetComponent<Aeronave>().isFacingS == true && B1.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
//if (B2.GetComponent<Aeronave>().isFacingS == true && A2.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
//if (B2.GetComponent<Aeronave>().isFacingS == true && A3.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
//if (B2.GetComponent<Aeronave>().isFacingN == true && B3.GetComponent<Aeronave>().isFacingS == true) { GM.gameOver = true; }
//----------------------------------GAME OVER B3------------------------------------------------------------------------------
//if (B3.GetComponent<Aeronave>().isFacingS == true && B2.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
////if (B3.GetComponent<Aeronave>().isFacingS == true && B1.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
//if (B3.GetComponent<Aeronave>().isFacingS == true && A2.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }
//if (B3.GetComponent<Aeronave>().isFacingS == true && A3.GetComponent<Aeronave>().isFacingN == true) { GM.gameOver = true; }