using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Aeronave : MonoBehaviour
{

     GameObject child;
     GameObject Wheel1;
     GameObject Wheel2;
     GameObject Wheel3;
   public  GameObject TaxingLights;
    public GameObject LandingLights;
    public GameObject AntiCollisionLights;

    

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

    public bool takeOff = false;
    public bool ATakeOff = false;
    public  bool BTakeOff = false;
     bool CTakeOff = false;
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
    bool rotation180VVV = false;
    bool rotation90 = false;
    bool rotation90V = false;
    private Transform ps;
    Vector3 startPos;
    public float turnSpeed = 10;
     float AnguloDeAtaque = 2;
    float wheelliftspeed = 15;
    bool Inclinacion = false;
    public bool PushBackCaraNorte = false;
    public bool PushBackCaraSur = false;
    public bool PushBackFacingNorthB = false;
    public bool PushBackFacingSouthB = false;
    public bool rodaje = false;
    private Transform P1;
    public bool stoppush = false;
    // public Transform[] wayPoints;
    public float MoveSpeed;

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
    public bool taxing = false;

    public bool HoldShortOfJuliet = false;
    private bool HoldingShortOfJuliet = false;

    public bool HoldShortOfAlfa = false;
    private bool HoldingShortOfAlfa = false;

    public bool HoldShortOfBravo = false;
    private bool HoldingShortOfBravo = false;

    public bool HoldShortOfDelta = false;
    private bool HoldingShortOfDelta = false;

    public bool HoldShortOfCharlie = false;
    private bool HoldingShortOfCharlie = false;

    bool Rotation180Variant = false;

    public bool HoldPosition = false;

   public bool isFacingS = false;
    bool FACESOUTH = false;
   public bool isFacingN = false;
   public bool ReadyToTaxi = false;

   public bool ReadyForDeparture = false;
    
    public bool tirillaOffScreen = false;

    public  bool isActive; // para referenciar que la tirilla esta active o no
    // Start is called before the first frame update
    void Start()
    {
        
        
        RB = GetComponent<Rigidbody>();

        ConstSpeed = MoveSpeed;

        child = transform.GetChild(5).gameObject;
        Wheel1 = transform.GetChild(0).gameObject;
        Wheel2 = transform.GetChild(1).gameObject;
        Wheel3 = transform.GetChild(2).gameObject;
        LandingLights = transform.GetChild(7).gameObject;
        TaxingLights = transform.GetChild(8).gameObject;
        AntiCollisionLights = transform.GetChild(9).gameObject;

        //DEACTIVATE AT START-------------------
        LandingLights.gameObject.SetActive(false);
        TaxingLights.gameObject.SetActive(false);
        AntiCollisionLights.gameObject.SetActive(false);
        //---------------------------




    }

    // Update is called once per frame
    void Update()

    {

        //-------------------------------------------------------------------------------------------------------
        if (ReadyToTaxi == true) { TaxingLights.SetActive(true); }
        if (takeOff == true) { TaxingLights.SetActive(false);  InvokeRepeating("antiCollisionLights1", 2, 120); }
        //-------------------------------------------------------------------------------------------------------


        //INCLINAR LA AERONAVE AL DESPEGAR------------------------
        if (Inclinacion == true)
        {
            Wheel3.transform.Rotate(Vector3.right * wheelliftspeed * Time.deltaTime);
            Wheel2.transform.Rotate(Vector3.right * wheelliftspeed * Time.deltaTime);
            Wheel1.transform.Rotate(Vector3.right * wheelliftspeed * Time.deltaTime);
            Invoke("stoplifting", 8);

            transform.Rotate(Vector3.left * AnguloDeAtaque * Time.deltaTime); 
            if (gameObject.transform.rotation.eulerAngles.x <= 349) { AnguloDeAtaque = 0; } }
        //----------------------------------------------

        if (takeOff == true && ATakeOff == true) { TakeOffRunWay17FromA = true; ReadyForDeparture = false; }
        if (takeOff == true && BTakeOff == true) { TakeOffRunWay17FromB = true; ReadyForDeparture = false; }
        
       
        

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

        //--------------------------------Hold Short Bravo-----------------------------------------------------------------------
        if (HoldShortOfBravo == false && MoveSpeed == 0 && HoldingShortOfBravo == true) { Invoke("TaxiSpeed", 1); }
        //-------------------------------------------------------------------------------------------------------

        //--------------------------------Hold Short Charlie-----------------------------------------------------------------------
        if (HoldShortOfCharlie == false && MoveSpeed == 0 && HoldingShortOfCharlie == true) { Invoke("TaxiSpeed", 1); }
        //-------------------------------------------------------------------------------------------------------

        //--------------------------------Hold Short DELTA-----------------------------------------------------------------------
        if (HoldShortOfDelta == false && MoveSpeed == 0 && HoldingShortOfDelta == true) { Invoke("TaxiSpeed", 1); }
        //-------------------------------------------------------------------------------------------------------

        //--------------------------------HOLD POSITION-----------------------------------------------------------------------
        if (HoldPosition == true && taxing == true  ) { MoveSpeed = 0; }

        //--------------------------------UNHOLD POSITION-----------------------------------------------------------------------
        if (HoldPosition == false &&  MoveSpeed == 0 && HoldingShortOfCharlie == false  && HoldingShortOfDelta == false  && HoldingShortOfAlfa == false  && HoldingShortOfJuliet == false && child.GetComponent<FrontAndBack>().colliing == false ) { Invoke("TaxiSpeed", 1); print("here");    }

        //--------------------------------TAXING-----------------------------------------------------------------------
        if (taxiRunWay17ViaCJToA == true || taxiRunWay17ViaDJToA == true || taxiRunWay17ViaCJToB || taxiRunWay17ViaDJToB == true || taxiRunWay17ViaAToA == true  || taxiRunWay17ViaCJToC == true || taxiRunWay35ViaDJToH == true || taxiRunWay35ViaDJToG == true || taxiRunWay35ViaCJToH == true || taxiRunWay35ViaCJToG == true) { taxing = true; }

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
        if (rodaje == true) {  transform.Translate(Vector3.forward * speed * Time.deltaTime); }
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

        //------------------ROTAR 180VARIANTE VARIANTE PARA A2-------------------------------------------------------------------------------------

        if (rotation180VVV == true)
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y <= 180)
            {
                Debug.Log("se situo en 180 el heading");
                rotation180VVV = false;
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
        
    }

    private void OnCollisionExit(Collision collision)
    {
        speed = 5;
    }
    void OnTriggerEnter(Collider other)
    {

        //-------------------------para detener l;a aeronave si esta esta cerca de otra-----------------------------------------------------------------------------
        if (gameObject.CompareTag("Front")) { if (other.gameObject.CompareTag("Back")) { speed = 0; print(gameObject.name + "choco con" + other.gameObject.name); } }
        //---------------------------------------------------------------------------

        //-------------------------para el push back, ya no se usa-----------------------------------------------------------------------------
        if (other.gameObject.CompareTag("Stop"))
        {
            if (PushBackCaraNorte == true) { PushBackRotation90 = true; }
            if (PushBackCaraSur == true) { PushBackRotation = true; Debug.Log("cara sur"); }
        }
        //------------------------------------------------------------------------------------------------------

        //--------------------------------------PARA GIRAR LA AERONAVE EN DISTINTOS EJES----------------------------------------------------------------
        if (other.gameObject.CompareTag("Turn180")) { if (taxiRunWay17ViaCJToA == true || taxiRunWay17ViaDJToA == true || taxiRunWay17ViaCJToB == true || taxiRunWay17ViaDJToB == true || taxiRunWay35ViaCJToH == true || taxiRunWay35ViaCJToG == true) { rotation180 = true; } 
        if (gameObject.CompareTag("B4")&& taxiRunWay17ViaCJToA == true && FACESOUTH == true) { Rotation180Variant = true; print("b4 deberia girar"); }
        if (gameObject.CompareTag("B4")&& taxiRunWay17ViaCJToB == true && FACESOUTH == true) { Rotation180Variant = true; print("b4 deberia girar"); }
        if (gameObject.CompareTag("C1") && taxiRunWay17ViaCJToA == true && FACESOUTH == true) { Rotation180Variant = true; print("b4 deberia girar"); }
        if (gameObject.CompareTag("C1") && taxiRunWay17ViaCJToB == true && FACESOUTH == true) { Rotation180Variant = true; print("b4 deberia girar"); }
        if (gameObject.CompareTag("C2") && taxiRunWay17ViaCJToA == true && FACESOUTH == true) { Rotation180Variant = true; print("b4 deberia girar"); }
        if (gameObject.CompareTag("C2") && taxiRunWay17ViaCJToB == true && FACESOUTH == true) { Rotation180Variant = true; print("b4 deberia girar"); }
        if (gameObject.CompareTag("C3") && taxiRunWay17ViaCJToA == true && FACESOUTH == true) { Rotation180Variant = true; print("b4 deberia girar"); }
        if (gameObject.CompareTag("C3") && taxiRunWay17ViaCJToB == true && FACESOUTH == true) { Rotation180Variant = true; print("b4 deberia girar"); }
        }

        //------------------------------------------VARIANTE PARA BRAVO, GIRAR 180 VV ------------------------------------------------------------
        if (other.gameObject.CompareTag("180VV")) { if (taxiRunWay17ViaCJToB == true || taxiRunWay17ViaDJToB == true) { rotation180 = true; } }
        //------------------------------------------------------------------------------------------------------

        if (other.gameObject.CompareTag("Turn180V"))
        {
            if (taxiRunWay17ViaDJToA == true || taxiRunWay17ViaDJToB == true || taxiRunWay35ViaDJToH == true || taxiRunWay35ViaDJToG == true || taxiRunWay35ViaCJToH || taxiRunWay35ViaCJToG == true) { Rotation180Variant = true; }
            if (gameObject.CompareTag("A2") && PushBackFacingSouthB == true || gameObject.CompareTag("A2") && PushBackFacingNorthB == true) { rotation180VVV = true; print("condicion unica para a2 met"); }
            if (gameObject.CompareTag("A4")) { if (taxiRunWay17ViaDJToA == true || taxiRunWay17ViaDJToB == true) { rotation180 = true; print("condicion unica desbloqueada"); } }
            if (gameObject.CompareTag("A5") && PushBackFacingSouthB == true || gameObject.CompareTag("A5") && PushBackFacingNorthB == true) { rotation180 = true; print("condicion 2 unica dada"); }
            if (gameObject.CompareTag("A5") && taxiRunWay17ViaDJToA == true || gameObject.CompareTag("A5") && taxiRunWay17ViaDJToB == true) { rotation180 = true; }
            if (gameObject.CompareTag("A6") && taxiRunWay17ViaDJToA == true || gameObject.CompareTag("A6") && taxiRunWay17ViaDJToB == true) { rotation180 = true; }
            if (gameObject.CompareTag("GA") && taxiRunWay17ViaDJToA == true || gameObject.CompareTag("GA") && taxiRunWay17ViaDJToB == true) { rotation180 = true; }
            
        }


        if (other.gameObject.CompareTag("Turn90")) { if (taxiRunWay17ViaDJToA == true || taxiRunWay17ViaCJToA == true || taxiRunWay17ViaCJToB == true || taxiRunWay17ViaDJToB == true || TakeOffRunWay35FromH == true || TakeOffRunWay35FromG == true ) { rotation90 = true; Debug.Log("va a girar ahora a 90"); } if (taxiRunWay35ViaDJToH == true || taxiRunWay35ViaDJToG == true || taxiRunWay35ViaCJToH == true || taxiRunWay35ViaCJToG == true) { Rotation270 = true; Debug.Log("va a girar 270");  }
            //---------------------PUSH BACK CONDITIONS----------------------------------------------------
            if (gameObject.CompareTag("A2") && PushBackFacingNorthB == true) { rotation90V = true; } 
            if (gameObject.CompareTag("A2") && PushBackFacingSouthB == true) { Rotation270V = true; }
            if (gameObject.CompareTag("B1") && PushBackFacingNorthB == true) { rotation90V = true; }
            if (gameObject.CompareTag("B1") && PushBackFacingSouthB == true) { Rotation270V = true; }
            if (gameObject.CompareTag("B2") && PushBackFacingNorthB == true) { rotation90V = true; }
            if (gameObject.CompareTag("B2") && PushBackFacingSouthB == true) { Rotation270V = true; }
            if (gameObject.CompareTag("B3") && PushBackFacingNorthB == true) { rotation90V = true; }
            if (gameObject.CompareTag("B3") && PushBackFacingSouthB == true) { Rotation270V = true; }
            if (gameObject.CompareTag("B4") && PushBackFacingNorthB == true) { rotation90V = true; }
            if (gameObject.CompareTag("B4") && PushBackFacingSouthB == true) { Rotation270V = true; }
            if (gameObject.CompareTag("C1") && PushBackFacingNorthB == true) { Rotation270V = true; }
            if (gameObject.CompareTag("C1") && PushBackFacingSouthB == true) { Rotation270V = true; }
            if (gameObject.CompareTag("C2") && PushBackFacingNorthB == true) { Rotation270V = true; }
            if (gameObject.CompareTag("C2") && PushBackFacingSouthB == true) { Rotation270V = true; }
            if (gameObject.CompareTag("C3") && PushBackFacingNorthB == true) { Rotation270V = true; }
            if (gameObject.CompareTag("C3") && PushBackFacingSouthB == true) { Rotation270V = true; }
            if (gameObject.CompareTag("GA") && PushBackFacingNorthB == true) { rotation90V = true; }
            if (gameObject.CompareTag("GA") && PushBackFacingSouthB == true) { rotation90V = true; }
            //-------------------------------------------------------------------------------
        }

        if (other.gameObject.CompareTag("Turn90V")) { if (PushBackFacingNorthB == true) { rotation90V = true; } if (PushBackFacingSouthB == true) { Rotation270V = true; } if (gameObject.CompareTag("A4") && PushBackFacingSouthB == true) { rotation90V = true; }  }

        if (other.gameObject.CompareTag("Turn270")) { Debug.Log("va a girar ahora a 270"); Rotation270 = true; }


        if (other.gameObject.CompareTag("A6Push")) { if (gameObject.CompareTag("A6")) { Rotation180Variant = true; } }
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

        //------------------------------------------Hold short of alfa 2------------------------------------------------------------
        if (other.gameObject.CompareTag("HoldShortB")) { if (HoldShortOfBravo == true) { HoldingShortOfBravo = true; MoveSpeed = 0; Debug.Log("Holding short of Bravo"); } }
        //------------------------------------------------------------------------------------------------------

        //------------------------------------------Hold short of CHARLIE ------------------------------------------------------------
        if (other.gameObject.CompareTag("HoldShortC")) { if (HoldShortOfCharlie == true) { HoldingShortOfCharlie = true; MoveSpeed = 0; Debug.Log("Holding short of charlie"); } }
        //------------------------------------------------------------------------------------------------------

        //------------------------------------------Hold short of CHARLIE ------------------------------------------------------------
        if (other.gameObject.CompareTag("HoldShortD")) { if (HoldShortOfDelta == true) { HoldingShortOfDelta = true; MoveSpeed = 0; Debug.Log("Holding short of Delta"); } }
        //------------------------------------------------------------------------------------------------------

        //----------------------------------DESACTIVAR GRAVEDAD DE LA AERONAVE--------------------------------------------------------------------
        if (other.gameObject.CompareTag("Speed+")) { MoveSpeed += 6; }

        //----------------------------------PROCESO DE DESPEGUE--------------------------------------------------------------------

        if (other.gameObject.CompareTag("TakeOffA")) { ATakeOff = true; }
        if (other.gameObject.CompareTag("TakeOffB")) { BTakeOff = true; }
        if (other.gameObject.CompareTag("TakeOffC")) { CTakeOff = true; }


        //----------------------------------reparar codigo corrompido--------------------------------------------------------------------
        //if (other.gameObject.CompareTag("Update")) { if (taxiRunWay17ViaCJToA == true) { if (wayPointIndex == 3) { wayPointIndex = 4; } } }
    }


    private void OnTriggerExit(Collider other)
    {
        //------------------------------PARA DESMARCAR LOS HOLDING SHORT CUANDO SALGA DE EL TRIGGER-----------------------------------------------------------------------
        Debug.Log("sali de el trigger"); HoldingShortOfJuliet = false; HoldingShortOfAlfa = false; HoldingShortOfCharlie = false; HoldingShortOfDelta = false; HoldingShortOfBravo = false;
        //-----------------------------------------------------------------------------------------------------
    }

    //-------------------PUSH BACK CARA NORTE VARIANTE-----------------------------------------------------------------------------------
    public void MovetoWayPointPushBackCaraNorteV()
    {
        transform.position = Vector3.MoveTowards(transform.position, PushBackFacingNorthV[PushBackFacingNorthVIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == PushBackFacingNorthV[PushBackFacingNorthVIndex].transform.position) { PushBackFacingNorthVIndex += 1; }
        if (transform.position == PushBackFacingNorthV[3].transform.position) { PushBackFacingNorthB = false; isFacingN = true; ReadyToTaxi = true; FACESOUTH = true;  }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------PUSH BACK CARA SUR VARIANTE-----------------------------------------------------------------------------------
    public void MovetoWayPointPushBackCaraSurV()
    {
        transform.position = Vector3.MoveTowards(transform.position, PushBackFacingSouthV[PushBackFacingSouthVIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == PushBackFacingSouthV[PushBackFacingSouthVIndex].transform.position) { PushBackFacingSouthVIndex += 1; }
        if (transform.position == PushBackFacingSouthV[3].transform.position) { PushBackFacingSouthB = false; isFacingS = true; FACESOUTH = true;  ReadyToTaxi = true; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 17 VIA CHARLEI JULIET TO ALFA HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR17VIACJ()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaCharlieJuliet[wayPointIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaCharlieJuliet[wayPointIndex].transform.position) { wayPointIndex += 1; }
        if (transform.position == R17ViaCharlieJuliet[7].transform.position) { taxiRunWay17ViaCJToA = false; ReadyForDeparture = true; }
       // if (wayPointIndex == 4) { wayPointIndex = 5; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 17 VIA DELTA JULIET TO ALFA HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR17VIADJ()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaDeltaJuliet[R17ViaDeltaJulietIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaDeltaJuliet[R17ViaDeltaJulietIndex].transform.position) { R17ViaDeltaJulietIndex += 1; }
        if (transform.position == R17ViaCharlieJuliet[7].transform.position) { taxiRunWay17ViaDJToA = false; ReadyForDeparture = true; }
    }
    //------------------------------------------------------------------------------------------------------


    //-------------------TAXI RUN WAY 17 VIA CHARLIE JULIET TO BRAVO HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR17VIACJToB()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaCharlieJulietToBravo[R17ViaCharlieJulietToBravoIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaCharlieJulietToBravo[R17ViaCharlieJulietToBravoIndex].transform.position) { R17ViaCharlieJulietToBravoIndex += 1; }
        if (transform.position == R17ViaCharlieJulietToBravo[5].transform.position) { taxiRunWay17ViaCJToB = false; ReadyForDeparture = true; }
    }
    //------------------------------------------------------------------------------------------------------


    //-------------------TAXI RUN WAY 17 VIA DELTA JULIET TO BRAVO HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR17VIADJToB()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaDeltaJulietToBravo[R17ViaDeltaJulietToBravoIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaDeltaJulietToBravo[R17ViaDeltaJulietToBravoIndex].transform.position) { R17ViaDeltaJulietToBravoIndex += 1; }
        if (transform.position == R17ViaDeltaJulietToBravo[4].transform.position) { taxiRunWay17ViaDJToB = false; ReadyForDeparture = true; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 17 VIA ALFA  TO ALFA HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR17VIaAToA()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaAlfaToAlfa[R17ViaAlfaToAlfaIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaAlfaToAlfa[R17ViaAlfaToAlfaIndex].transform.position) { R17ViaAlfaToAlfaIndex += 1; }
        if (transform.position == R17ViaAlfaToAlfa[3].transform.position) { taxiRunWay17ViaAToA = false; ReadyForDeparture = true; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 17 VIA CHARLIE JULIET  TO CHARLIE HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR17VIaCJToC()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaCharlieJulietC[R17ViaCharlieJulietToCIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaCharlieJulietC[R17ViaCharlieJulietToCIndex].transform.position) { R17ViaCharlieJulietToCIndex += 1; }
        if (transform.position == R17ViaCharlieJulietC[8].transform.position) { taxiRunWay17ViaCJToC = false; ReadyForDeparture = true;  }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 17 VIA DELTA JULIET  TO CHARLIE HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR17VIaDJToC()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaDeltaJulietC[R17ViaDeltaJulietToCIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaDeltaJulietC[R17ViaDeltaJulietToCIndex].transform.position) { R17ViaDeltaJulietToCIndex += 1; }
        if (transform.position == R17ViaDeltaJulietC[8].transform.position) { taxiRunWay17ViaDJToC = false; ReadyForDeparture = true; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 35  VIA DELTA JULIET TO HOTEL HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR35VIADJH()
    {
        transform.position = Vector3.MoveTowards(transform.position, R35ViaDeltaJulietH[R35ViaDeltaJulietHIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R35ViaDeltaJulietH[R35ViaDeltaJulietHIndex].transform.position) { R35ViaDeltaJulietHIndex += 1; }
        if (transform.position == R35ViaDeltaJulietH[4].transform.position) { taxiRunWay35ViaDJToH = false; ReadyForDeparture = true; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 35  VIA DELTA JULIET TO GOLF HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR35VIADJG()
    {
        transform.position = Vector3.MoveTowards(transform.position, R35ViaDeltaJulietG[R35ViaDeltaJulietGIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R35ViaDeltaJulietG[R35ViaDeltaJulietGIndex].transform.position) { R35ViaDeltaJulietGIndex += 1; }
        if (transform.position == R35ViaDeltaJulietG[4].transform.position) { taxiRunWay35ViaDJToG = false; ReadyForDeparture = true; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 35  VIA CHARLIE JULIET TO HOTEL HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR35VIaCJH()
    {
        transform.position = Vector3.MoveTowards(transform.position, R35ViaCharlieJulietH[R35ViaCharlieJulietHIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R35ViaCharlieJulietH[R35ViaCharlieJulietHIndex].transform.position) { R35ViaCharlieJulietHIndex += 1; }
        if (transform.position == R35ViaCharlieJulietH[7].transform.position) { taxiRunWay35ViaCJToH = false; ReadyForDeparture = true; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 35  VIA CHARLIE JULIET TO GOLF HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    public void MovetoWayPointR35VIaCJG()
    {
        transform.position = Vector3.MoveTowards(transform.position, R35ViaCharlieJulietG[R35ViaCharlieJulietGIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R35ViaCharlieJulietG[R35ViaCharlieJulietGIndex].transform.position) { R35ViaCharlieJulietGIndex += 1; }
        if (transform.position == R35ViaCharlieJulietG[7].transform.position) { taxiRunWay35ViaCJToG = false; ReadyForDeparture = true; }
    }
    //------------------------------------------------------------------------------------------------------

    //--------------------------TAKE OFF RUN WAY 17 FROM ALFA----------------------------------------------------------------------------
    public void takeOffRunWay17FromA() 
    {
        transform.position = Vector3.MoveTowards(transform.position, TakeOffRunWay117[TakeOffRunWay17AIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == TakeOffRunWay117[TakeOffRunWay17AIndex].transform.position) { TakeOffRunWay17AIndex += 1; }
        if (transform.position == TakeOffRunWay117[7].transform.position) { TakeOffRunWay17FromA = false; takeOff = false; tirillaOffScreen = true;   }
        if (transform.position == TakeOffRunWay117[5].transform.position) { Inclinacion = true;  }

        
    }
    //------------------------------------------------------------------------------------------------------

    //--------------------------TAKE OFF RUN WAY 17 FROM BRAVO----------------------------------------------------------------------------
    public void takeOffRunWay17fromB()
    {
        transform.position = Vector3.MoveTowards(transform.position, TakeOffRunWay17B[TakeOffRunWay17BIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == TakeOffRunWay17B[TakeOffRunWay17BIndex].transform.position) { TakeOffRunWay17BIndex += 1; }
        if (transform.position == TakeOffRunWay17B[7].transform.position) { TakeOffRunWay17FromB = false; takeOff = false; tirillaOffScreen = true; }
        if (transform.position == TakeOffRunWay17B[5].transform.position) { Inclinacion= true; }
    }
    //------------------------------------------------------------------------------------------------------

    //--------------------------TAKE OFF RUN WAY 35 FROM HOTEL----------------------------------------------------------------------------
    public void takeOffRunWay35fromH()
    {
        transform.position = Vector3.MoveTowards(transform.position, TakeOffRunWay35H[TakeOffRunWay35HIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == TakeOffRunWay35H[TakeOffRunWay35HIndex].transform.position) { TakeOffRunWay35HIndex += 1; }
        if (transform.position == TakeOffRunWay35H[7].transform.position) { TakeOffRunWay35FromH = false; takeOff = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //--------------------------TAKE OFF RUN WAY 35 FROM GOLF----------------------------------------------------------------------------
    public void takeOffRunWay35fromG()
    {
        transform.position = Vector3.MoveTowards(transform.position, TakeOffRunWay35G[TakeOffRunWay35GIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == TakeOffRunWay35G[TakeOffRunWay35GIndex].transform.position) { TakeOffRunWay35GIndex += 1; }
        if (transform.position == TakeOffRunWay35G[7].transform.position) { TakeOffRunWay35FromG = false; takeOff = false; }
    }
    //------------------------------------------------------------------------------------------------------


    public void TaxiSpeed () 
    {
        if(HoldShortOfAlfa == true || HoldShortOfBravo == true || HoldShortOfJuliet == true || HoldShortOfCharlie == true || HoldShortOfDelta == true) { MoveSpeed = 0; }

       MoveSpeed = 5;
        Debug.Log("se invoko la speed de 5");
        CancelInvoke();

    }

   void stoplifting()
    {
        wheelliftspeed = 0;
        print("se detuvo la rotacion");
            
    }

    
    public void PushBackFacingNorth () 
    {
        PushBackCaraNorte = true;
    }

    public void PushBackFacingSouth () 
    {
        PushBackCaraSur = true;

    }

    public void destruirAeronave()
    {
        Destroy(gameObject, 5);
    }

    public void antiCollisionLights1 ()
    {
        AntiCollisionLights.SetActive(true);
        LandingLights.SetActive(true);
        Invoke("antiCollisionLights2", 6f);
    }

    public void antiCollisionLights2()
    {
        AntiCollisionLights.SetActive(false);
        LandingLights.SetActive(false);
        Invoke("antiCollisionLights1", 50f);
    }

    
}




