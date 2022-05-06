using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Approach : MonoBehaviour
{
   public GameObject Wheel1;
   public GameObject Wheel2;
   public GameObject Wheel3;

    Rigidbody RB;

    public Transform[] ApproachRunWay17;
    int ApproachRunWay17Index = 0;

    public Transform[] ApproachEast;
    int ApproachEastIndex = 0;

    public Transform[] secuencia2;
    int secuencia2Index = 0;

    public Transform[] secuencia3;
    int secuencia3Index = 0;

    public Transform[] GoAround;
    int GoAroundIndex = 0;

    public Transform[] OutOfRunWaay17ByF;
    int OutOfRunWaay17ByFIndex = 0;


    // public Transform[] OutOfRunWaay17ByH;
    // int OutOfRunWaay17ByHIndex = 0;


    //--------WAYPOINTS-------
    public Transform[] TaxiToGeneralAviation;
    int TaxiToGeneralAviationIndex = 0;


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

    public Transform[] TaxiToGateB1;
    int TaxiToGateB1Index = 0;

    public Transform[] TaxiToGateB2;
    int TaxiToGateB2Index = 0;

    public Transform[] TaxiToGateB3;
    int TaxiToGateB3Index = 0;

    public Transform[] TaxiToGateB4;
    int TaxiToGateB4Index = 0;

    public bool tirillaOffScreen = false;     // para animaciones de tirilla 

    public bool Approach17 = false;
    public bool rodaje = false;
    public bool OutOfRunway17ByF = false;
    //public bool OutOfRunway17ByH = false;

    //--------BOOL TO ACTIVATE THE WAYPOINTS------
    public bool ClearToLand = false;
    public bool Inclinacion = false;
    float AnguloDeAtaque = 2;
    float wheelliftspeed = 15;
    public bool goAround = false; 
    public bool No1 = false; 
    public bool No2 = false;
    public bool No3 = false;
    public bool Onsight = false;
    public bool Forward = false;
    public bool AproachEast = false;
    public bool TaxiToGateGeneralAviation = false;
    public bool taxiTogateA2 = false;
    public bool taxiTogateA3 = false;
    public bool taxiTogateA4 = false;
    public bool taxiTogateA5 = false;
    public bool taxiTogateA6 = false;
    public bool taxiTogateB1 = false;
    public bool taxiTogateB2 = false;
    public bool taxiTogateB3 = false;
    public bool taxiTogateB4 = false;
//------------HOLD SHORT OF---------------
    public bool HoldShortOfDelta = false;
     bool HoldingShortOfDelta = false;
    public bool HoldShortOfRamp = false;
     bool HoldingShortOfRamp = false;
   public bool taxing = false;
    public bool HoldPosition = false;
    //--------SPPEDS-------------
    public int speed;
    public int MoveSpeed = 40;
    int turnSpeed = 8;
    //---------ROTATIONS--------------
     bool rotation360 = false;
     bool rotation360V = false;
     bool rotation270 = false;
    public bool rotation270V = false;
     bool rotation251A2 = false;
     bool rotationA4 = false;
     bool rotationA6 = false;
     bool rotation90 = false;
     bool rotation90V = false;
     bool rotation90VV = false;

    //--------DESICION-----
    bool desicion = false;
    public bool Holding2 = false;
    public bool Holding3 = false;
    //------------------------

    public GameManager GM;
    public GameObject jet;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();

        jet = GameObject.FindGameObjectWithTag("test");
        GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        if (gameObject.CompareTag("Final"))
        {
            Wheel1 = transform.GetChild(6).gameObject;
            Wheel2 = transform.GetChild(7).gameObject;
            Wheel3 = transform.GetChild(8).gameObject;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HoldPosition == true && taxing == true) { speed = 0;   }
        if (HoldPosition == false && taxing == true && speed ==0) { Invoke("TaxiSpeed", 1);    }


        if (goAround == true && gameObject.CompareTag("Final"))
        {
            Wheel3.transform.Rotate(Vector3.right * wheelliftspeed * Time.deltaTime);
            Wheel2.transform.Rotate(Vector3.right * wheelliftspeed * Time.deltaTime);
            Wheel1.transform.Rotate(Vector3.right * wheelliftspeed * Time.deltaTime);
            Invoke("stoplifting", 8);

            transform.Rotate(Vector3.left * AnguloDeAtaque * Time.deltaTime);
            if (gameObject.transform.rotation.eulerAngles.x <= 349) { AnguloDeAtaque = 0; }
        }

        if (goAround == true && gameObject.CompareTag("Visual") || goAround == true && gameObject.CompareTag("Visual"))
        {
           

            transform.Rotate(Vector3.left * AnguloDeAtaque * Time.deltaTime);
            if (gameObject.transform.rotation.eulerAngles.x <= 349) { AnguloDeAtaque = 0; }
        }

        //--------------------------------------------------------------------------------------------------
        //----------------LA AERONAVE SE APROXIMA DE ACUERDO A SU UBICACION---------------
        if (Forward == true) { transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime); }


        //----------------cuando la aeronave aterriza se empezara a mover a cierta velocidad hacia adelante
        if (rodaje == true) {  transform.Translate(Vector3.forward * speed * Time.deltaTime); }

        //IDA AL AIRE OR GO AROUND-------------
        if (goAround == true) { Approach17 = false; GoAround1(); }

        //INICIAR LA APROXIMACION DESDE EL ESTE
        if (AproachEast == true) { ApproachEste(); }


        //INICIAR LA APROXIMACION HACIA LA PISTA 17
        if (Approach17 == true) { ApproachR17(); }

        //INICIAR LA SALIDA DE LA PISTA 17 POR FOXTROX
        if (OutOfRunway17ByF == true) { rodaje = false; OutOfRunWay17ByF(); }

        //INICIAR LA APROXIMACION EN LA SECUENCIA 2
        if (No2 == true && desicion == true) { Land2(); }
        if (Holding2 == true && GM.SecuenciaDeAterrizaje == 2) { print("aeronave en P2 inicia aproximacion final pista 17"); Approach17 = true; }  

        //INICIAR LA APROXIMACION EN LA SECUENCIA 3
        if (No3 == true && desicion == true) { Land3();}
        if (Holding3 == true && GM.SecuenciaDeAterrizaje == 3 ) { print("aeronave en P3 inicia aproximacion final pista 17"); Approach17 = true; }
        //INICIAR LA SALIDA DE LA PISTA 17 POR HOTEL
        // if (OutOfRunway17ByH == true) { rodaje = false; OutOfRunWay17ByH(); }
        //  if (transform.position.x < OutOfRunWaay17ByF[1].transform.position.x ) { Invoke("OutofRunwayByH", 0.5f); OutOfRunway17ByF = false;  }


        //TAXI TO GATE GENERAL AVIATION--------------------
        if (TaxiToGateGeneralAviation == true && taxing == true) { taxiToGateGA(); }
        //TAXI TO GATE A2--------------------
        if (taxiTogateA2 == true && taxing == true) { taxiToGateA2(); }
        //TAXI TO GATE A3--------------------
        if (taxiTogateA3 == true && taxing == true) { taxiToGateA3(); }
        //TAXI TO GATE A4--------------------
        if (taxiTogateA4 == true && taxing == true) { taxiToGateA4(); }
        //TAXI TO GATE A5--------------------
        if (taxiTogateA5 == true && taxing == true) { taxiToGateA5(); }
        //TAXI TO GATE A6--------------------
        if (taxiTogateA6 == true && taxing == true) { taxiToGateA6(); }
        //TAXI TO GATE B1--------------------
        if (taxiTogateB1 == true && taxing == true) { taxiToGateB1(); }
        //TAXI TO GATE B2--------------------
        if (taxiTogateB2 == true && taxing == true) { taxiToGateB2(); }
        //TAXI TO GATE B3--------------------
        if (taxiTogateB3 == true && taxing == true) { taxiToGateB3(); }
        //TAXI TO GATE B4--------------------
        if (taxiTogateB4 == true && taxing == true) { taxiToGateB4(); }
        //TAXI TO GATE GENERAL AVIATION--------------------
        if (TaxiToGateGeneralAviation == true && taxing == true) { taxiToGateGA(); }


        //--------------------------------Hold Short DELTA-----------------------------------------------------------------------
        if (HoldShortOfDelta == false && speed == 0 && HoldingShortOfDelta == true) { Invoke("TaxiSpeed", 1); }

        //--------------------------------Hold Short RAMP-----------------------------------------------------------------------
        if (HoldShortOfRamp == false && speed == 0 && HoldingShortOfRamp == true) { Invoke("TaxiSpeed", 1); }


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

        //---------------------ROTAR LA  AERONAVE AL HEADING 90 VARIANTE VARIANTE-----------------------------------------
        if (rotation90VV == true)
        {
            Debug.Log("deberia de empezar a rotar");
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y <= 90)
            {
                Debug.Log("se situo en el heading 90 Variante");
                rotation90VV = false;
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
        //-------------------ROTAR LA AERONAVE 251 GRADOS 
        if (rotation251A2 == true)
        {
            Debug.Log("deberia de empezar a girar a la izquierda");
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y <= 309)
            {
                Debug.Log("se sitio en el heading 251 ");
                rotation251A2 = false;
            }
        }

        //-------------------ROTAR LA AERONAVE 270 GRADOS 
        if (rotation270 == true)
        {
            Debug.Log("deberia de empezar a girar a la izquierda");
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y <= 270)
            {
                Debug.Log("se sitio en el heading 270 ");
                rotation270 = false;
            }
        }
        //-------------------ROTAR LA AERONAVE 270 GRADOS VARIANTE
        if (rotation270V == true)
        {
            Debug.Log("deberia de empezar a girar a la izquierda");
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y >= 90)
            {
                print("se situo 1 variante");
                transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);
                if (transform.rotation.eulerAngles.y <= 270) { Debug.Log("se sitio en el heading 270 VARIANTE "); rotation270V = false; }
                    
                
            }
        }

        //-------------------ROTAR LA AERONAVE 180 y luego 35 GRADOS para A4  
        if (rotationA4 == true)
        {
            Debug.Log("deberia de empezar a girar a la DERECHA");
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y <= 180)
            {
                Debug.Log("se sitio en el heading 180 ");
                transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime); if (transform.rotation.eulerAngles.y >= 35) { rotationA4 = false; Debug.Log("se sitio en el heading 55 "); }
                
            }
        }
        //-------------------ROTAR LA AERONAVE 135  para A6
        if (rotationA6 == true)
        {
            Debug.Log("deberia de empezar a girar a la DERECHA");
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y >= 145)
            {
                print("se situo en el heading 135");
                rotationA6 = false;

            }
        }

    }

   


    private void OnTriggerEnter(Collider other)
    {
        //--------------------------------TRIGGERSSS---------------------------------
        if (other.gameObject.CompareTag("GoAround")) {if (ClearToLand == false) { Approach17 = false; goAround = true; } if (gameObject.CompareTag("Visual") || gameObject.CompareTag("West")) { GM.Invoke("secuenciaUpdate", 15);print("secuencia actualizada debio a ida al aire"); } }
        if (other.gameObject.CompareTag("GravityOn")) { RB.useGravity = true; Debug.Log("se activo la gravedad"); }
        if (other.gameObject.CompareTag("MoveSpeed-")) { MoveSpeed = 30; }
        if (other.gameObject.CompareTag("Turn360")) { if (OutOfRunway17ByF == true && transform.position.x > OutOfRunWaay17ByF[1].transform.position.x) { rotation360 = true; speed = 5; } if (taxiTogateA5 == true) { print("deberia girar a la derecha hacia a5"); rotation360 = true; } }    
        if (other.gameObject.CompareTag("Turn90AP")) { Debug.Log("cocho con turn 90"); rotation90 = true; if (taxiTogateA5 == true) { rotation90 = true; } }
        if (other.gameObject.CompareTag("Turn90APV")) { Debug.Log("cocho con turn 90 v"); rotation90V = true; }
        if (other.gameObject.CompareTag("Turn360V")) { if (taxiTogateA2 == true || taxiTogateA3 || taxiTogateA4 || taxiTogateA5 || taxiTogateA6 || taxiTogateB1 || taxiTogateB2 || taxiTogateB3 || taxiTogateB4 || TaxiToGateGeneralAviation == true) { Debug.Log("cocho con turn 360 v"); rotation360V = true; } }
        if (other.gameObject.CompareTag("Gates")) {if (taxiTogateA2 == true || taxiTogateB1 == true || taxiTogateB2 || taxiTogateB3 || taxiTogateB4 ||  AproachEast == true) { print("va hacia a2 gate"); rotation90 = true; } if (taxiTogateA4 == true || taxiTogateA5 == true || taxiTogateA6 == true || TaxiToGateGeneralAviation == true) { rotation270 = true; } if (gameObject.CompareTag("West")&& RB. useGravity == false) { rotation90VV = true; print("aeronave del oeste girando 90 grados"); }  }
        if (other.gameObject.CompareTag("Turn251")) { if (taxiTogateA2 == true) { rotation251A2 = true; print("tiene que girar 251"); } if (taxiTogateA4 == true) { rotationA4 = true; } }
        if (other.gameObject.CompareTag("Turn34")) { if (taxiTogateA4 == true) { rotationA4 = true; print("choco con colicionador 34"); } }
        if (other.gameObject.CompareTag("Turn0")) { if (taxiTogateA6 == true) { rotation360 = true; } if (TaxiToGateA6Index == 5) { TaxiToGateA6Index = 6; } }
        if (other.gameObject.CompareTag("Turn90AP")) { if (taxiTogateA6 == true && transform.position == TaxiToGateA6[6].transform.position) { rotation90 = true; } if (TaxiToGateA6Index == 6) { TaxiToGateA6Index = 7; } }
        if (other.gameObject.CompareTag("HoldShortD")) {if (HoldShortOfDelta == true) { speed = 0; } HoldingShortOfDelta = true; }
        if (other.gameObject.CompareTag("HoldShortR")) { if (HoldShortOfRamp == true) { speed = 0; } HoldingShortOfRamp = true; }
        if (other.gameObject.CompareTag("Desicion")) { if (No2 == true || No3 == true) { desicion = true; print("la decicion ha sido tomada"); AproachEast = false;  }     else { print("usted es el numero 1"); } if (No2 == true) { print("usted es el numero 2 en secuencia"); } if (No3 == true) { print("usted es el numero 3 en secuencia"); } }
        //if (other.gameObject.CompareTag("Holding2")) { Holding2 = true; }
        // if (other.gameObject.CompareTag("Holding3")) { Holding3 = true; }
        //-------------------------------REPARAR CODIGO CORROMPIDO---------------------------------------------------
        if (other.gameObject.CompareTag("ContinueExit")) { OutOfRunway17ByF = false; taxing = true; }
        if (other.gameObject.CompareTag("Onsight")) { Onsight = true; print(gameObject.name + "is on sight"); }

    }

    private void OnTriggerExit(Collider other)
    {
        //------------------------------PARA DESMARCAR LOS HOLDING SHORT CUANDO SALGA DE EL TRIGGER-----------------------------------------------------------------------
        Debug.Log("sali de el trigger"); HoldingShortOfDelta = false; HoldingShortOfRamp = false; Holding2 = false; Holding3 = false;
        //-----------------------------------------------------------------------------------------------------
    }

    private void OnTriggerStay(Collider other)
    {
       // if (other.gameObject.CompareTag("Holding2")) { Holding2 = true; }
    }
    //---------------------------------------INICIAR APROXIMACION PISTA 17----------------------------------------------------------
    void ApproachR17()
    {
        transform.position = Vector3.MoveTowards(transform.position, ApproachRunWay17[ApproachRunWay17Index].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == ApproachRunWay17[ApproachRunWay17Index].transform.position) { ApproachRunWay17Index += 1; }
        if (transform.position == ApproachRunWay17[1].transform.position) { Approach17 = false; OutOfRunway17ByF= true; speed = +30; }
    }
    //-------------------------------------------------------------------------------------------------------------------------

    //---------------------------------------INICIAR APROXIMACION EAST FROM THE STATION----------------------------------------------------------
    void ApproachEste()
    {
        transform.position = Vector3.MoveTowards(transform.position, ApproachEast[ApproachEastIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == ApproachEast[ApproachEastIndex].transform.position) { ApproachEastIndex += 1; }
        if (transform.position == ApproachEast[1].transform.position) { AproachEast = false; Approach17 = true; rotation270V = true;  }
    }
    //-------------------------------------------------------------------------------------------------------------------------

    //---------------------------------------GO AROUND O IDA AL AIRE----------------------------------------------------------
    void GoAround1()
    {
        transform.position = Vector3.MoveTowards(transform.position, GoAround[GoAroundIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == GoAround[GoAroundIndex].transform.position) { GoAroundIndex += 1; }
        if (transform.position == GoAround[2].transform.position) { goAround = false;  }
    }
    //-------------------------------------------------------------------------------------------------------------------------

    //---------------------------------------INICIAR APROXIMACION Final Position 2----------------------------------------------------------
    void Land2()
    {
        transform.position = Vector3.MoveTowards(transform.position, secuencia2[secuencia2Index].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == secuencia2[secuencia2Index].transform.position) { secuencia2Index += 1; }
        if (transform.position == secuencia2[0].transform.position) { No2 = false;  rotation270V = true; Holding2 = true; }
    }
    //-------------------------------------------------------------------------------------------------------------------------

    //---------------------------------------INICIAR APROXIMACION Final Position 3----------------------------------------------------------
    void Land3()
    {
        transform.position = Vector3.MoveTowards(transform.position, secuencia3[secuencia3Index].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == secuencia3[secuencia3Index].transform.position) { secuencia3Index += 1; }
        if (transform.position == secuencia3[0].transform.position) { No3 = false; rotation270V = true; Holding3 = true; }
    }
    //-------------------------------------------------------------------------------------------------------------------------

    //---------------------------------------OUT OF RUN WAY  17 BY FOXTROX----------------------------------------------------------
    void OutOfRunWay17ByF()
    {//-------------------------------si la posicion de la aeronave no ha pasado por foxtrox entonces podra pasar por foxtrox de lo contrario no
        if (transform.position.x > OutOfRunWaay17ByF[1].transform.position.x)
        {

            transform.position = Vector3.MoveTowards(transform.position, OutOfRunWaay17ByF[OutOfRunWaay17ByFIndex].transform.position, speed * Time.deltaTime);
            if (transform.position == OutOfRunWaay17ByF[OutOfRunWaay17ByFIndex].transform.position) { OutOfRunWaay17ByFIndex += 1; }
            if (transform.position == OutOfRunWaay17ByF[1].transform.position) { taxing = true; OutOfRunway17ByF = false;  if (gameObject.CompareTag("West") || (gameObject.CompareTag("Visual")) ){ speed = 2; }  }
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

    //---------------------------------------TAXI TO GENERAL AVIATION----------------------------------------------------------
    void taxiToGateGA()
    {
        transform.position = Vector3.MoveTowards(transform.position, TaxiToGeneralAviation[TaxiToGeneralAviationIndex].transform.position, speed * Time.deltaTime);
        if (transform.position == TaxiToGeneralAviation[TaxiToGeneralAviationIndex].transform.position) { TaxiToGeneralAviationIndex += 1; }
        if (transform.position == TaxiToGeneralAviation[5].transform.position) { TaxiToGateGeneralAviation = false; speed = 5; Destroy(gameObject); }
        //if (transform.position == TaxiToGateA2[5].transform.position) { rotation360V = true; }
    }
    //-------------------------------------------------------------------------------------------------------------------------
    //---------------------------------------TAXI TO GATE A2----------------------------------------------------------
    void taxiToGateA2()
    {
        transform.position = Vector3.MoveTowards(transform.position, TaxiToGateA2[TaxiToGateA2Index].transform.position, speed * Time.deltaTime);
        if (transform.position == TaxiToGateA2[TaxiToGateA2Index].transform.position) { TaxiToGateA2Index += 1; }
        if (transform.position == TaxiToGateA2[7].transform.position) { taxiTogateA2 = false; speed = 5; }
        if (transform.position == TaxiToGateA2[5].transform.position) { rotation360V = true; }
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
        if (transform.position == TaxiToGateA6[8].transform.position) { taxiTogateA6 = false; speed = 5; }
        if (transform.position == TaxiToGateA6[7].transform.position) { print("llego a la posicion final"); rotationA6 = true;  }
       
    }
    //-------------------------------------------------------------------------------------------------------------------------

    //---------------------------------------TAXI TO GATE B1----------------------------------------------------------
    void taxiToGateB1()
    {
        transform.position = Vector3.MoveTowards(transform.position, TaxiToGateB1[TaxiToGateB1Index].transform.position, speed * Time.deltaTime);
        if (transform.position == TaxiToGateB1[TaxiToGateB1Index].transform.position) { TaxiToGateB1Index += 1; }
        if (transform.position == TaxiToGateB1[6].transform.position) { taxiTogateB1 = false;  }
        if (transform.position == TaxiToGateB1[5].transform.position) { print("llego a la  posicion semi final de b1"); rotation360V = true;  }
        

    }
    //-------------------------------------------------------------------------------------------------------------------------

    //---------------------------------------TAXI TO GATE B2----------------------------------------------------------
    void taxiToGateB2()
    {
        transform.position = Vector3.MoveTowards(transform.position, TaxiToGateB2[TaxiToGateB2Index].transform.position, speed * Time.deltaTime);
        if (transform.position == TaxiToGateB2[TaxiToGateB2Index].transform.position) { TaxiToGateB2Index += 1; }
        if (transform.position == TaxiToGateB2[6].transform.position) { taxiTogateB2 = false; }
        if (transform.position == TaxiToGateB2[5].transform.position) { print("llego a la  posicion semi final de b2"); rotation360V = true; }


    }
    //-------------------------------------------------------------------------------------------------------------------------

    //---------------------------------------TAXI TO GATE B3----------------------------------------------------------
    void taxiToGateB3()
    {
        transform.position = Vector3.MoveTowards(transform.position, TaxiToGateB3[TaxiToGateB3Index].transform.position, speed * Time.deltaTime);
        if (transform.position == TaxiToGateB3[TaxiToGateB3Index].transform.position) { TaxiToGateB3Index += 1; }
        if (transform.position == TaxiToGateB3[6].transform.position) { taxiTogateB3 = false; }
        if (transform.position == TaxiToGateB3[5].transform.position) { print("llego a la  posicion semi final de b3"); rotation360V = true; }


    }
    //-------------------------------------------------------------------------------------------------------------------------

    //---------------------------------------TAXI TO GATE B4----------------------------------------------------------
    void taxiToGateB4()
    {
        transform.position = Vector3.MoveTowards(transform.position, TaxiToGateB4[TaxiToGateB4Index].transform.position, speed * Time.deltaTime);
        if (transform.position == TaxiToGateB4[TaxiToGateB4Index].transform.position) { TaxiToGateB4Index += 1; }
        if (transform.position == TaxiToGateB4[6].transform.position) { taxiTogateB4 = false; }
        if (transform.position == TaxiToGateB4[5].transform.position) { print("llego a la  posicion semi final de b4"); rotation360V = true; }


    }
    //-------------------------------------------------------------------------------------------------------------------------


    public void TaxiSpeed()
    {
        speed = 5;
        if (gameObject.CompareTag("Visual") || (gameObject.CompareTag("West"))) { speed = 3; }
        Debug.Log("se invoko la speed de 5 o 3 dependiendo el caso ");
        CancelInvoke();

    }

    void stoplifting()
    {
        wheelliftspeed = 0;
        print("se detuvo la rotacion");

    }

}
