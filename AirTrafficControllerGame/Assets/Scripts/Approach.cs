using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Approach : MonoBehaviour
{
    Rigidbody RB;

    public Transform[] ApproachRunWay17;
    int ApproachRunWay17Index = 0;

    public Transform[] OutOfRunWaay17ByF;
    int OutOfRunWaay17ByFIndex = 0;


    public Transform[] OutOfRunWaay17ByH;
    int OutOfRunWaay17ByHIndex = 0;
    //--------WAYPOINTS-------
    public Transform[] TaxiToGateA2;
    int TaxiToGateA2Index = 0;

    public Transform[] TaxiToGateA3;
    int TaxiToGateA3Index = 0;

    public Transform[] TaxiToGateA4;
    int TaxiToGateA4Index = 0;

    public Transform[] TaxiToGateA5;
    int TaxiToGateA5Index = 0;

    public Transform[] TaxiToGateA6;
    int TaxiToGateA6Index = 0;


    public bool Approach17 = false;
    public bool rodaje = false;
    public bool OutOfRunway17ByF = false;
    //public bool OutOfRunway17ByH = false;

    //--------BOOL TO ACTIVATE THE WAYPOINTS------
    public bool taxiTogateA2 = false;
    public bool taxiTogateA3 = false;
    public bool taxiTogateA4 = false;
    public bool taxiTogateA5 = false;
    public bool taxiTogateA6 = false;
    //--------SPPEDS-------------
    public int speed;
    public int MoveSpeed = 40;
    int turnSpeed = 8;
    //---------ROTATIONS--------------
    bool rotation360 = false;
    public bool rotation360V = false;
    bool rotation90 = false;
    bool rotation90V = false;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        
        
       

       
    }

    // Update is called once per frame
    void Update()
    {
        
         

        //----------------cuando la aeronave aterriza se empezara a mover a cierta velocidad hacia adelante
        if (rodaje == true) {  transform.Translate(Vector3.forward * speed * Time.deltaTime); }

        //INICIAR LA APROXIMACION HACIA LA PISTA 17
        if (Approach17 == true) { ApproachR17(); }

        //INICIAR LA SALIDA DE LA PISTA 17 POR FOXTROX
        if (OutOfRunway17ByF == true) { rodaje = false; OutOfRunWay17ByF(); }

        //INICIAR LA SALIDA DE LA PISTA 17 POR HOTEL
       // if (OutOfRunway17ByH == true) { rodaje = false; OutOfRunWay17ByH(); }
      //  if (transform.position.x < OutOfRunWaay17ByF[1].transform.position.x ) { Invoke("OutofRunwayByH", 0.5f); OutOfRunway17ByF = false;  }

        //TAXI TO GATE A2--------------------
        if (taxiTogateA2 == true) { taxiToGateA2(); }
        //TAXI TO GATE A3--------------------
        if (taxiTogateA3 == true) { taxiToGateA3(); }
        //TAXI TO GATE A4--------------------
        if (taxiTogateA4 == true) { taxiToGateA4(); }
        //TAXI TO GATE A5--------------------
        if (taxiTogateA5 == true) { taxiToGateA5(); }
        //TAXI TO GATE A6--------------------
        if (taxiTogateA6 == true) { taxiToGateA6(); }

        //---------------------ROTAR LA  AERONAVE AL HEADING 90 -----------------------------------------
        if (rotation90 == true)
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y >= 90)
            {
                Debug.Log("se sitio en el heading 90");
                rotation90 = false;
            }
        }
        //---------------------ROTAR LA  AERONAVE AL HEADING 90 VARIANTE-----------------------------------------
        if (rotation90V == true)
        {
            Debug.Log("deberia de empezar a rotar");
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y >= 90)
            {
                Debug.Log("se situo en el heading 90 Variante");
                rotation90V = false;
            }
        }
        //--------------------------------------------------------------

        //-------------------ROTAR LA  AERONAVE AL HEADING 259 ----------------------------------------
        if (rotation360 == true)
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y <= 259)
            {
                
                rotation360 = false;
                Debug.Log("se sitio en el heading 0");
            }
        }
        
        //-------------------ROTAR LA AERONAVE 259 GRADOS VARIANTE
        if (rotation360V == true)
        {
            Debug.Log("deberia de empezar a girar a la izquierda");
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y >= 259)
            {
                Debug.Log("se sitio en el heading 360 VARIANTE");
                rotation360V = false;
            }
        }
        //--------------------------------------------------------------



    }



    private void OnTriggerEnter(Collider other)
    {
        //--------------------------------TRIGGERSSS---------------------------------

        if (other.gameObject.CompareTag("GravityOn")) { RB.useGravity = true; Debug.Log("se activo la gravedad"); }
        if (other.gameObject.CompareTag("MoveSpeed-")) { MoveSpeed = 19; }
        if (other.gameObject.CompareTag("Turn360")) { if (OutOfRunway17ByF == true && transform.position.x > OutOfRunWaay17ByF[1].transform.position.x) {  rotation360 = true; speed = 5; } }
        if (other.gameObject.CompareTag("Turn90AP")) { Debug.Log("cocho con turn 90"); rotation90 = true; }
        if (other.gameObject.CompareTag("Turn90APV")) { Debug.Log("cocho con turn 90 v"); rotation90V = true; }
        if (other.gameObject.CompareTag("Turn360V")) { Debug.Log("cocho con turn 360 v"); rotation360V = true; }
    }


    //---------------------------------------INICIAR APROXIMACION PISTA 17----------------------------------------------------------
    void ApproachR17()
    {
        transform.position = Vector3.MoveTowards(transform.position, ApproachRunWay17[ApproachRunWay17Index].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == ApproachRunWay17[ApproachRunWay17Index].transform.position) { ApproachRunWay17Index += 1; }
        if (transform.position == ApproachRunWay17[2].transform.position) { Approach17 = false; OutOfRunway17ByF= true; speed = +19; }
    }
    //-------------------------------------------------------------------------------------------------------------------------

    //---------------------------------------OUT OF RUN WAY  17 BY FOXTROX----------------------------------------------------------
    void OutOfRunWay17ByF()
    {//-------------------------------si la posicion de la aeronave no ha pasado por foxtrox entonces podra pasar por foxtrox de lo contrario no
        if (transform.position.x > OutOfRunWaay17ByF[1].transform.position.x)
        {

            transform.position = Vector3.MoveTowards(transform.position, OutOfRunWaay17ByF[OutOfRunWaay17ByFIndex].transform.position, speed * Time.deltaTime);
            if (transform.position == OutOfRunWaay17ByF[OutOfRunWaay17ByFIndex].transform.position) { OutOfRunWaay17ByFIndex += 1; }
            if (transform.position == OutOfRunWaay17ByF[1].transform.position) { OutOfRunway17ByF = false; }
        }
    }
    //-------------------------------------------------------------------------------------------------------------------------

    //---------------------------------------OUT OF RUN WAY  17 BY HOTEL----------------------------------------------------------
    // void OutOfRunWay17ByH()
    //{

    // //transform.position = Vector3.MoveTowards(transform.position, OutOfRunWaay17ByH[OutOfRunWaay17ByHIndex].transform.position, speed * Time.deltaTime);
    // if (transform.position == OutOfRunWaay17ByH[OutOfRunWaay17ByHIndex].transform.position) { OutOfRunWaay17ByHIndex += 1; }
    // if (transform.position == OutOfRunWaay17ByH[1].transform.position) { OutOfRunway17ByH = false; }
    //}
    //-------------------------------------------------------------------------------------------------------------------------
    //---------------------------------------TAXI TO GATE A2----------------------------------------------------------
    void taxiToGateA2()
    {
        transform.position = Vector3.MoveTowards(transform.position, TaxiToGateA2[TaxiToGateA2Index].transform.position, speed * Time.deltaTime);
        if (transform.position == TaxiToGateA2[TaxiToGateA2Index].transform.position) { TaxiToGateA2Index += 1; }
        if (transform.position == TaxiToGateA2[7].transform.position) { taxiTogateA2 = false; speed = 5; }
    }
    //-------------------------------------------------------------------------------------------------------------------------

    //---------------------------------------TAXI TO GATE A3----------------------------------------------------------
    void taxiToGateA3()
    {
        transform.position = Vector3.MoveTowards(transform.position, TaxiToGateA3[TaxiToGateA3Index].transform.position, speed * Time.deltaTime);
        if (transform.position == TaxiToGateA3[TaxiToGateA3Index].transform.position) { TaxiToGateA3Index += 1; }
        if (transform.position == TaxiToGateA3[7].transform.position) {  taxiTogateA3 = false; speed = 5; }
    }
    //-------------------------------------------------------------------------------------------------------------------------

    //---------------------------------------TAXI TO GATE A4----------------------------------------------------------
    void taxiToGateA4()
    {
        transform.position = Vector3.MoveTowards(transform.position, TaxiToGateA4[TaxiToGateA4Index].transform.position, speed * Time.deltaTime);
        if (transform.position == TaxiToGateA4[TaxiToGateA4Index].transform.position) { TaxiToGateA4Index += 1; }
        if (transform.position == TaxiToGateA4[7].transform.position) { taxiTogateA4 = false; speed = 5; }
    }
    //-------------------------------------------------------------------------------------------------------------------------

    //---------------------------------------TAXI TO GATE A5----------------------------------------------------------
    void taxiToGateA5()
    {
        transform.position = Vector3.MoveTowards(transform.position, TaxiToGateA5[TaxiToGateA5Index].transform.position, speed * Time.deltaTime);
        if (transform.position == TaxiToGateA5[TaxiToGateA5Index].transform.position) { TaxiToGateA5Index += 1; }
        if (transform.position == TaxiToGateA5[7].transform.position) { taxiTogateA5 = false; speed = 5; }
    }
    //-------------------------------------------------------------------------------------------------------------------------

    //---------------------------------------TAXI TO GATE A6----------------------------------------------------------
    void taxiToGateA6()
    {
        transform.position = Vector3.MoveTowards(transform.position, TaxiToGateA6[TaxiToGateA6Index].transform.position, speed * Time.deltaTime);
        if (transform.position == TaxiToGateA6[TaxiToGateA6Index].transform.position) { TaxiToGateA6Index += 1; }
        if (transform.position == TaxiToGateA6[7].transform.position) { taxiTogateA6 = false; speed = 5; }
    }
    //-------------------------------------------------------------------------------------------------------------------------



    // /void OutofRunwayByH () 
    //{
    // Debug.Log("ya paso sobre calle de salida foxtro");
    //OutOfRunway17ByH = true;
    // CancelInvoke();
    // }

}
