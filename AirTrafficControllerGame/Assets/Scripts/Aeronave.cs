using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Aeronave : MonoBehaviour
{

    
    

    public Transform[] PushBackFacingNorthV;
    int PushBackFacingNorthVIndex = 0;

    public Transform[] PushBackFacingSouthV;
    int PushBackFacingSouthVIndex = 0;

    public Transform[] R17ViaCharlieJuliet;
     int wayPointIndex = 0;


    public Transform[] TakeOffRunWay117;
     int TakeOffRunWay17AIndex = 0;

    public Transform[] TakeOffRunWay17B;
    int TakeOffRunWay17BIndex = 0;

    public Transform[] R17ViaDeltaJuliet;
     int R17ViaDeltaJulietIndex;

    public Transform[] R17ViaCharlieJulietToBravo;
    int R17ViaCharlieJulietToBravoIndex;

    public Transform[] R17ViaDeltaJulietToBravo;
    int R17ViaDeltaJulietToBravoIndex;

    public Transform[] R17ViaAlfaToAlfa;
    int R17ViaAlfaToAlfaIndex;

    public Transform[] R17ViaCharlieJulietC;
    int R17ViaCharlieJulietToCIndex;

    public Transform[] R17ViaDeltaJulietC;
    int R17ViaDeltaJulietToCIndex;

    public Transform[] R35ViaDeltaJulietH;
    int R35ViaDeltaJulietHIndex;

    public Transform[] R35ViaDeltaJulietG;
    int R35ViaDeltaJulietGIndex;

    public Transform[] R35ViaCharlieJulietH;
    int R35ViaCharlieJulietHIndex;

    public Transform[] R35ViaCharlieJulietG;
    int R35ViaCharlieJulietGIndex;

    public Transform[] TakeOffRunWay35H;
    int TakeOffRunWay35HIndex;

    public Transform[] TakeOffRunWay35G;
    int TakeOffRunWay35GIndex;

    public bool TakeOffRunWay17FromA = false;
    public bool TakeOffRunWay17FromB = false;
    public bool InmediateTakeOff = false;
    public bool TakeOffRunWay35FromH = false;
    public bool TakeOffRunWay35FromG = false;


    public int speed = 6;
    Rigidbody RB;

    bool PushBackRotation90 = false;
    bool PushBackRotation = false;
    bool Rotation270 = false;
    bool Rotation270V = false;
    bool rotation180 = false;
    bool rotation90 = false;
    bool rotation90V = false;
    private Transform ps;
    Vector3 startPos;
    public float turnSpeed = 10;
    public bool PushBackCaraNorte = false;
    public bool PushBackCaraSur = false;
    public bool PushBackFacingNorthB = false;
    public bool PushBackFacingSouthB = false;
    public bool rodaje = false;
    private Transform P1;
    public bool stoppush = false;
    // public Transform[] wayPoints;
    [SerializeField] float MoveSpeed;

    float ConstSpeed;
   
    public bool taxiRunWay17ViaCJToA = false;
    public bool taxiRunWay17ViaDJToA = false;
    public bool taxiRunWay17ViaCJToB = false;
    public bool taxiRunWay17ViaDJToB = false;
    public bool taxiRunWay17ViaAToA = false;
    public bool taxiRunWay17ViaCJToC = false;
    public bool taxiRunWay17ViaDJToC = false;
    public bool taxiRunWay35ViaDJToH = false;
    public bool taxiRunWay35ViaDJToG = false;
    public bool taxiRunWay35ViaCJToH = false;
    public bool taxiRunWay35ViaCJToG = false;

    public bool HoldShortOfJuliet = false;
    private bool HoldingShortOfJuliet = false;

    public bool HoldShortOfAlfa = false;
    private bool HoldingShortOfAlfa = false;

    public bool HoldShortOfDelta = false;
    private bool HoldingShortOfDelta = false;

    public bool HoldShortOfCharlie = false;
    private bool HoldingShortOfCharlie = false;

    bool Rotation180Variant = false;
   

    // Start is called before the first frame update
    void Start()
    {
        

        RB = GetComponent<Rigidbody>();

        ConstSpeed = MoveSpeed;

         

    }

    // Update is called once per frame
    void Update()

    {
        //---------------------------PUSH BACK FACING NORTH V
        if (PushBackFacingNorthB== true) { MovetoWayPointPushBackCaraNorteV(); }

        //---------------------------PUSH BACK FACING SOUTH V
        if (PushBackFacingSouthB == true) { MovetoWayPointPushBackCaraSurV(); }

        //--------------------------take off run way 17 FROM ALFA-----------------------------------------------------------------------------
        if (TakeOffRunWay17FromA == true) { takeOffRunWay17FromA(); }

        //--------------------------take off run way 17 FROM BRAVO-----------------------------------------------------------------------------
        if (TakeOffRunWay17FromB == true) { takeOffRunWay17fromB(); }

        //--------------------------take off run way 35 FROM HOTEL-----------------------------------------------------------------------------
        if (TakeOffRunWay35FromH == true) { takeOffRunWay35fromH(); }

        //--------------------------take off run way 35 FROM GOLF-----------------------------------------------------------------------------
        if (TakeOffRunWay35FromG == true) { takeOffRunWay35fromG(); }


        //---------------INMEDIATE TAKE OFF RUN WAY 17 FROM ALFA----------------------------------------------------------------------------------------
        if (InmediateTakeOff == true && taxiRunWay17ViaCJToA == false && taxiRunWay17ViaDJToA == false) { TakeOffRunWay17FromA = true; }


        //para parar el proceso de push back de la aeronave------------------------------------------------------------------------------------------------------------------
        if (stoppush == true) { PushBackCaraNorte = false; PushBackCaraSur = false; stoppush = false; }

        //--------------------------------Hold Short Jul-----------------------------------------------------------------------
        if (HoldShortOfJuliet == false && MoveSpeed ==0 && HoldingShortOfJuliet == true) { Invoke("TaxiSpeed", 1); }
        //-------------------------------------------------------------------------------------------------------

        //--------------------------------Hold Short alfa-----------------------------------------------------------------------
         if (HoldShortOfAlfa == false && MoveSpeed == 0 && HoldingShortOfAlfa == true) { Invoke("TaxiSpeed", 1); }
        //-------------------------------------------------------------------------------------------------------

        //--------------------------------Hold Short Charlie-----------------------------------------------------------------------
        if (HoldShortOfCharlie == false && MoveSpeed == 0 && HoldingShortOfCharlie == true) { Invoke("TaxiSpeed", 1); }
        //-------------------------------------------------------------------------------------------------------

        //--------------------------------Hold Short DELTA-----------------------------------------------------------------------
        if (HoldShortOfDelta == false && MoveSpeed == 0 && HoldingShortOfDelta == true) { Invoke("TaxiSpeed", 1); }
        //-------------------------------------------------------------------------------------------------------

        //----------------------------PARA IR A LA PISTA 17 VIA CHARLIE JULIET TO ALFA

        if (taxiRunWay17ViaCJToA == true) { MovetoWayPointR17VIACJ(); }

        //-------------------------------------------------------------------------------------------------------

        //----------------------------PARA IR A LA PISTA 17 VIA DELTA JULIET TO ALFA

        if (taxiRunWay17ViaDJToA == true) { MovetoWayPointR17VIADJ(); }

        //-------------------------------------------------------------------------------------------------------

        //----------------------------PARA IR A LA PISTA 17 VIA CHARLIE JULIET TO BRAVO

        if (taxiRunWay17ViaCJToB == true) { MovetoWayPointR17VIACJToB(); }

        //-------------------------------------------------------------------------------------------------------

        //----------------------------PARA IR A LA PISTA 17 VIA DELTA JULIET TO BRAVO

        if (taxiRunWay17ViaDJToB == true) { MovetoWayPointR17VIADJToB(); }

        //-------------------------------------------------------------------------------------------------------

        //----------------------------PARA IR A LA PISTA 17 VIA ALFA  TO ALFA

        if (taxiRunWay17ViaAToA == true) { MovetoWayPointR17VIaAToA(); }

        //-------------------------------------------------------------------------------------------------------

        //----------------------------PARA IR A LA PISTA 17 VIA CHARLIE JULIET  TO CHARLIE  GA

        if (taxiRunWay17ViaCJToC == true) { MovetoWayPointR17VIaCJToC(); }

        //-------------------------------------------------------------------------------------------------------

        //----------------------------PARA IR A LA PISTA 17 VIA DELTA JULIET  TO CHARLIE  GA

        if (taxiRunWay17ViaDJToC == true) { MovetoWayPointR17VIaDJToC(); }

        //-------------------------------------------------------------------------------------------------------



        //----------------------------PARA IR A LA PISTA 35 VIA DELTA JULIET TO HOTEL

        if (taxiRunWay35ViaDJToH == true) { MovetoWayPointR35VIADJH(); }

        //-------------------------------------------------------------------------------------------------------


        //----------------------------PARA IR A LA PISTA 35 VIA DELTA JULIET TO HOTEL

        if (taxiRunWay35ViaDJToG == true) { MovetoWayPointR35VIADJG(); }

        //-------------------------------------------------------------------------------------------------------

        //----------------------------PARA IR A LA PISTA 35 VIA CHARLIE JULIET TO HOTEL

        if (taxiRunWay35ViaCJToH == true) { MovetoWayPointR35VIaCJH(); }

        //-------------------------------------------------------------------------------------------------------

        //----------------------------PARA IR A LA PISTA 35 VIA CHARLIE JULIET TO GOLF

        if (taxiRunWay35ViaCJToG == true) { MovetoWayPointR35VIaCJG(); }

        //-------------------------------------------------------------------------------------------------------


        //PUSH BACK CARA NORTE
        if (PushBackCaraNorte == true && rodaje == false)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);



            if (PushBackRotation90 == true)

            {
                speed = 0;
                transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
                if (transform.rotation.eulerAngles.y >= 90)
                {
                    
                    PushBackRotation90 = false;
                    speed = 6;

                    PushBackCaraNorte = false;
                }

            }




        }

        //PUSH BACK CARA SUR--------------------------------------------------------------------------------------------

        if (PushBackCaraSur == true && rodaje == false)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);



            if (PushBackRotation == true)

            {
                speed = 0;
                transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);
                if (transform.rotation.eulerAngles.y <= 270)
                {
                    Debug.Log("se situo en 270 el heading");
                    PushBackRotation = false;
                    PushBackCaraSur = false;
                    

                    
                }

            }




        }

        //-------------------------------------------------------------------------------------------------------

        //hace que la aeronave se mueva hacia adelante en su eje Z
        if (rodaje == true) { speed = 6; transform.Translate(Vector3.forward * speed * Time.deltaTime); }
        //-------------------------------------------------------------------------------------------------------

        //----------------------ROTAR 270---------------------------------------------------------------------------------

        if (Rotation270 == true)
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y >= 270)
            {

                Rotation270 = false;
            }
        }

        if (Rotation270V == true)
        {
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y <= 270)
            {

                Rotation270V = false;
            }
        }



        //------------------ROTAR 180-------------------------------------------------------------------------------------

        if (rotation180 == true) { transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y >= 180)
            {
                Debug.Log("se situo en 180 el heading");
                rotation180 = false;
            }

           }


        if (Rotation180Variant == true)
        {
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y <= 180)
            {
                Debug.Log("se situo en 180 el heading VARIANTE");
                Rotation180Variant = false;
            }

        }


        //----------------ROTAR 90--------------------------------------------------------------------------------------

        if (rotation90 == true)
        {
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y <= 90)
            {
                
                rotation90 = false;
            }
        }


        if (rotation90V == true)
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y >= 90)
            {
                Debug.Log("se situo en el heading 90 Variante");
                rotation90V = false;
            }
        }

        //-------------------------------------------------------------------------------------------------------




    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) { Debug.Log("hola cocho con collider"); }
    }
    void OnTriggerEnter(Collider other)
    {
        //------------------------------------------------------------------------------------------------------
        if (other.gameObject.CompareTag("Stop"))
        {
            if (PushBackCaraNorte == true) { PushBackRotation90 = true;  }
            if (PushBackCaraSur == true) { PushBackRotation = true; Debug.Log("cara sur"); }
        }
        //------------------------------------------------------------------------------------------------------

        //--------------------------------------PARA GIRAR LA AERONAVE EN DISTINTOS EJES----------------------------------------------------------------
        if (other.gameObject.CompareTag("Turn180")) { if (taxiRunWay17ViaCJToA == true || taxiRunWay17ViaDJToA == true || taxiRunWay17ViaCJToB == true || taxiRunWay17ViaDJToB== true || taxiRunWay35ViaCJToH == true || taxiRunWay35ViaCJToG == true) { rotation180 = true; } }

        if (other.gameObject.CompareTag("Turn180V")) { if (taxiRunWay17ViaDJToA == true || taxiRunWay17ViaDJToB == true || taxiRunWay35ViaDJToH == true || taxiRunWay35ViaDJToG == true || taxiRunWay35ViaCJToH || taxiRunWay35ViaCJToG == true) { Rotation180Variant = true; } }

        if (other.gameObject.CompareTag("Turn90")) { if (taxiRunWay17ViaDJToA == true || taxiRunWay17ViaCJToA == true || taxiRunWay17ViaCJToB == true || taxiRunWay17ViaDJToB == true || TakeOffRunWay35FromH == true || TakeOffRunWay35FromG == true ) { rotation90 = true; Debug.Log("va a girar ahora a 90"); } if (taxiRunWay35ViaDJToH == true || taxiRunWay35ViaDJToG == true || taxiRunWay35ViaCJToH == true || taxiRunWay35ViaCJToG == true) { Rotation270 = true; Debug.Log("va a girar 270");  } }

        if (other.gameObject.CompareTag("Turn90V")) { if (PushBackFacingNorthB == true) { rotation90V = true; } if (PushBackFacingSouthB == true) { Rotation270V = true; }  }

        if (other.gameObject.CompareTag("Turn270")) { Debug.Log("va a girar ahora a 270"); Rotation270 = true; }
        //------------------------------------------------------------------------------------------------------

        //----------------------------------DESACTIVAR GRAVEDAD DE LA AERONAVE--------------------------------------------------------------------
        if (other.gameObject.CompareTag("Drb")) { Debug.Log("0 de gravedad"); RB.useGravity = false; }
        //------------------------------------------------------------------------------------------------------

        //------------------------------------------Hold short of juliet 2------------------------------------------------------------
        if (other.gameObject.CompareTag("HoldShortJ")) { if (HoldShortOfJuliet == true) { HoldingShortOfJuliet = true;  MoveSpeed = 0; Debug.Log("Holding short of Juliet"); } }
        //------------------------------------------------------------------------------------------------------

        //------------------------------------------Hold short of alfa 2------------------------------------------------------------
        if (other.gameObject.CompareTag("HoldShortA")) { if (HoldShortOfAlfa == true) { HoldingShortOfAlfa = true; MoveSpeed = 0; Debug.Log("Holding short of Alfa"); } }
        //------------------------------------------------------------------------------------------------------

        //------------------------------------------Hold short of CHARLIE ------------------------------------------------------------
        if (other.gameObject.CompareTag("HoldShortC")) { if (HoldShortOfCharlie == true) { HoldingShortOfCharlie = true; MoveSpeed = 0; Debug.Log("Holding short of charlie"); } }
        //------------------------------------------------------------------------------------------------------

        //------------------------------------------Hold short of CHARLIE ------------------------------------------------------------
        if (other.gameObject.CompareTag("HoldShortD")) { if (HoldShortOfDelta == true) { HoldingShortOfDelta = true; MoveSpeed = 0; Debug.Log("Holding short of Delta"); } }
        //------------------------------------------------------------------------------------------------------

        //----------------------------------DESACTIVAR GRAVEDAD DE LA AERONAVE--------------------------------------------------------------------
        if (other.gameObject.CompareTag("Speed+")) { MoveSpeed += 6; }
    }


    private void OnTriggerExit(Collider other)
    {
        //------------------------------PARA DESMARCAR LOS HOLDING SHORT CUANDO SALGA DE EL TRIGGER-----------------------------------------------------------------------
        Debug.Log("sali de el trigger"); HoldingShortOfJuliet = false; HoldingShortOfAlfa = false; HoldingShortOfCharlie = false; HoldingShortOfDelta = false;
        //-----------------------------------------------------------------------------------------------------
    }

    //-------------------PUSH BACK CARA NORTE VARIANTE-----------------------------------------------------------------------------------
    public void MovetoWayPointPushBackCaraNorteV()
    {
        transform.position = Vector3.MoveTowards(transform.position, PushBackFacingNorthV[PushBackFacingNorthVIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == PushBackFacingNorthV[PushBackFacingNorthVIndex].transform.position) { PushBackFacingNorthVIndex += 1; }
        if (transform.position == PushBackFacingNorthV[3].transform.position) { PushBackFacingNorthB = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------PUSH BACK CARA SUR VARIANTE-----------------------------------------------------------------------------------
    public void MovetoWayPointPushBackCaraSurV()
    {
        transform.position = Vector3.MoveTowards(transform.position, PushBackFacingSouthV[PushBackFacingSouthVIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == PushBackFacingSouthV[PushBackFacingSouthVIndex].transform.position) { PushBackFacingSouthVIndex += 1; }
        if (transform.position == PushBackFacingSouthV[3].transform.position) { PushBackFacingSouthB = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 17 VIA CHARLEI JULIET TO ALFA HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR17VIACJ()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaCharlieJuliet[wayPointIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaCharlieJuliet[wayPointIndex].transform.position) { wayPointIndex += 1; }
        if (transform.position == R17ViaCharlieJuliet[7].transform.position) { taxiRunWay17ViaCJToA = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 17 VIA DELTA JULIET TO ALFA HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR17VIADJ()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaDeltaJuliet[R17ViaDeltaJulietIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaDeltaJuliet[R17ViaDeltaJulietIndex].transform.position) { R17ViaDeltaJulietIndex += 1; }
        if (transform.position == R17ViaCharlieJuliet[7].transform.position) { taxiRunWay17ViaDJToA = false; }
    }
    //------------------------------------------------------------------------------------------------------


    //-------------------TAXI RUN WAY 17 VIA CHARLIE JULIET TO BRAVO HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR17VIACJToB()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaCharlieJulietToBravo[R17ViaCharlieJulietToBravoIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaCharlieJulietToBravo[R17ViaCharlieJulietToBravoIndex].transform.position) { R17ViaCharlieJulietToBravoIndex += 1; }
        if (transform.position == R17ViaCharlieJulietToBravo[5].transform.position) { taxiRunWay17ViaCJToB = false; }
    }
    //------------------------------------------------------------------------------------------------------


    //-------------------TAXI RUN WAY 17 VIA DELTA JULIET TO BRAVO HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR17VIADJToB()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaDeltaJulietToBravo[R17ViaDeltaJulietToBravoIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaDeltaJulietToBravo[R17ViaDeltaJulietToBravoIndex].transform.position) { R17ViaDeltaJulietToBravoIndex += 1; }
        if (transform.position == R17ViaDeltaJulietToBravo[4].transform.position) { taxiRunWay17ViaDJToB = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 17 VIA ALFA  TO ALFA HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR17VIaAToA()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaAlfaToAlfa[R17ViaAlfaToAlfaIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaAlfaToAlfa[R17ViaAlfaToAlfaIndex].transform.position) { R17ViaAlfaToAlfaIndex += 1; }
        if (transform.position == R17ViaAlfaToAlfa[3].transform.position) { taxiRunWay17ViaAToA = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 17 VIA CHARLIE JULIET  TO CHARLIE HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR17VIaCJToC()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaCharlieJulietC[R17ViaCharlieJulietToCIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaCharlieJulietC[R17ViaCharlieJulietToCIndex].transform.position) { R17ViaCharlieJulietToCIndex += 1; }
        if (transform.position == R17ViaCharlieJulietC[8].transform.position) { taxiRunWay17ViaCJToC = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 17 VIA DELTA JULIET  TO CHARLIE HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR17VIaDJToC()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaDeltaJulietC[R17ViaDeltaJulietToCIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaDeltaJulietC[R17ViaDeltaJulietToCIndex].transform.position) { R17ViaDeltaJulietToCIndex += 1; }
        if (transform.position == R17ViaDeltaJulietC[8].transform.position) { taxiRunWay17ViaDJToC = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 35  VIA DELTA JULIET TO HOTEL HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR35VIADJH()
    {
        transform.position = Vector3.MoveTowards(transform.position, R35ViaDeltaJulietH[R35ViaDeltaJulietHIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R35ViaDeltaJulietH[R35ViaDeltaJulietHIndex].transform.position) { R35ViaDeltaJulietHIndex += 1; }
        if (transform.position == R35ViaDeltaJulietH[4].transform.position) { taxiRunWay35ViaDJToH = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 35  VIA DELTA JULIET TO GOLF HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR35VIADJG()
    {
        transform.position = Vector3.MoveTowards(transform.position, R35ViaDeltaJulietG[R35ViaDeltaJulietGIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R35ViaDeltaJulietG[R35ViaDeltaJulietGIndex].transform.position) { R35ViaDeltaJulietGIndex += 1; }
        if (transform.position == R35ViaDeltaJulietG[4].transform.position) { taxiRunWay35ViaDJToG = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 35  VIA CHARLIE JULIET TO HOTEL HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR35VIaCJH()
    {
        transform.position = Vector3.MoveTowards(transform.position, R35ViaCharlieJulietH[R35ViaCharlieJulietHIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R35ViaCharlieJulietH[R35ViaCharlieJulietHIndex].transform.position) { R35ViaCharlieJulietHIndex += 1; }
        if (transform.position == R35ViaCharlieJulietH[7].transform.position) { taxiRunWay35ViaCJToH = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 35  VIA CHARLIE JULIET TO GOLF HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR35VIaCJG()
    {
        transform.position = Vector3.MoveTowards(transform.position, R35ViaCharlieJulietG[R35ViaCharlieJulietGIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R35ViaCharlieJulietG[R35ViaCharlieJulietGIndex].transform.position) { R35ViaCharlieJulietGIndex += 1; }
        if (transform.position == R35ViaCharlieJulietG[7].transform.position) { taxiRunWay35ViaCJToG = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //--------------------------TAKE OFF RUN WAY 17 FROM ALFA----------------------------------------------------------------------------
    public void takeOffRunWay17FromA() 
    {
        transform.position = Vector3.MoveTowards(transform.position, TakeOffRunWay117[TakeOffRunWay17AIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == TakeOffRunWay117[TakeOffRunWay17AIndex].transform.position) { TakeOffRunWay17AIndex += 1; }
        if (transform.position == TakeOffRunWay117[7].transform.position) { TakeOffRunWay17FromA = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //--------------------------TAKE OFF RUN WAY 17 FROM BRAVO----------------------------------------------------------------------------
    public void takeOffRunWay17fromB()
    {
        transform.position = Vector3.MoveTowards(transform.position, TakeOffRunWay17B[TakeOffRunWay17BIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == TakeOffRunWay17B[TakeOffRunWay17BIndex].transform.position) { TakeOffRunWay17BIndex += 1; }
        if (transform.position == TakeOffRunWay17B[7].transform.position) { TakeOffRunWay17FromB = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //--------------------------TAKE OFF RUN WAY 35 FROM HOTEL----------------------------------------------------------------------------
    public void takeOffRunWay35fromH()
    {
        transform.position = Vector3.MoveTowards(transform.position, TakeOffRunWay35H[TakeOffRunWay35HIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == TakeOffRunWay35H[TakeOffRunWay35HIndex].transform.position) { TakeOffRunWay35HIndex += 1; }
        if (transform.position == TakeOffRunWay35H[7].transform.position) { TakeOffRunWay35FromH = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //--------------------------TAKE OFF RUN WAY 35 FROM GOLF----------------------------------------------------------------------------
    public void takeOffRunWay35fromG()
    {
        transform.position = Vector3.MoveTowards(transform.position, TakeOffRunWay35G[TakeOffRunWay35GIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == TakeOffRunWay35G[TakeOffRunWay35GIndex].transform.position) { TakeOffRunWay35GIndex += 1; }
        if (transform.position == TakeOffRunWay35G[7].transform.position) { TakeOffRunWay35FromG = false; }
    }
    //------------------------------------------------------------------------------------------------------


    public void TaxiSpeed () 
    {
        MoveSpeed = 5;
        Debug.Log("se invoko la speed de 5");
        CancelInvoke();

    }

    
    public void PushBackFacingNorth () 
    {
        PushBackCaraNorte = true;
    }

    public void PushBackFacingSouth () 
    {
        PushBackCaraSur = true;

    }

}




