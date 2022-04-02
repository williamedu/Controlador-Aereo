using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Aeronave : MonoBehaviour
{

    public Transform[] R17ViaCharlieJuliet;
     int wayPointIndex = 0;


    public Transform[] TakeOffRunWay117;
     int TakeOffRunWay17Index = 0;

    public Transform[] R17ViaDeltaJuliet;
     int R17ViaDeltaJulietIndex;

    public Transform[] R17ViaCharlieJulietToBravo;
    int R17ViaCharlieJulietToBravoIndex;

    public Transform[] R35ViaDeltaJulietH;
    int R35ViaDeltaJulietHIndex;

    public Transform[] R35ViaDeltaJulietG;
    int R35ViaDeltaJulietGIndex;

    public bool TakeOffRunWay17 = false;
    public bool InmediateTakeOff = false;

    public int speed = 6;
    Rigidbody RB;

    bool PushBackRotation90 = false;
    bool PushBackRotation = false;
    bool Rotation270 = false;
    bool rotation180 = false;
     public bool rotation90 = false;
    private Transform ps;
    Vector3 startPos;
    public float turnSpeed = 10;
    public bool PushBackCaraNorte = false;
    public bool PushBackCaraSur = false;
    public bool rodaje = false;
    private Transform P1;
    public bool stoppush = false;
    // public Transform[] wayPoints;
    [SerializeField] float MoveSpeed;

    float ConstSpeed;
   
    public bool taxiRunWay17ViaCJToA = false;
    public bool taxiRunWay17ViaDJToA = false;
    public bool taxiRunWay17ViaCJToB = false;
    public bool taxiRunWay35ViaDJToH = false;
    public bool taxiRunWay35ViaDJToG = false;
    public bool HoldShortOfJuliet = false;
    private bool HoldingShortOfJuliet = false;
    public bool HoldShortOfAlfa = false;
    private bool HoldingShortOfAlfa = false;


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
        

        //--------------------------take off run way 17-----------------------------------------------------------------------------
        if (TakeOffRunWay17 == true) { takeOffRunWay17(); }

        //---------------INMEDIATE TAKE OFF----------------------------------------------------------------------------------------
        if (InmediateTakeOff == true && taxiRunWay17ViaCJToA == false && taxiRunWay17ViaDJToA == false) { TakeOffRunWay17 = true; }


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

        //----------------------------PARA IR A LA PISTA 17 VIA CHARLIE JULIET

        if (taxiRunWay17ViaCJToA == true) { MovetoWayPointR17VIACJ(); }

        //-------------------------------------------------------------------------------------------------------

        //----------------------------PARA IR A LA PISTA 17 VIA DELTA JULIET TO ALFA

        if (taxiRunWay17ViaDJToA == true) { MovetoWayPointR17VIADJ(); }

        //-------------------------------------------------------------------------------------------------------

        //----------------------------PARA IR A LA PISTA 17 VIA DELTA JULIET TO ALFA

        if (taxiRunWay17ViaCJToB == true) { MovetoWayPointR17VIACJToB(); }

        //-------------------------------------------------------------------------------------------------------

        //----------------------------PARA IR A LA PISTA 35 VIA DELTA JULIET TO HOTEL

        if (taxiRunWay35ViaDJToH == true) { MovetoWayPointR35VIADJH(); }

        //-------------------------------------------------------------------------------------------------------


        //----------------------------PARA IR A LA PISTA 35 VIA DELTA JULIET TO HOTEL

        if (taxiRunWay35ViaDJToG == true) { MovetoWayPointR35VIADJG(); }

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
        if (other.gameObject.CompareTag("Turn180")) { if (taxiRunWay17ViaCJToA == true || taxiRunWay17ViaDJToA == true || taxiRunWay17ViaCJToB == true) { rotation180 = true; } }

        if (other.gameObject.CompareTag("Turn180V")) { if (taxiRunWay17ViaDJToA == true) { Rotation180Variant = true; } if (taxiRunWay35ViaDJToH == true) { Rotation180Variant = true; } if (taxiRunWay35ViaDJToG == true) { Debug.Log("goldd 180 variante co;o"); Rotation180Variant = true; }   }

        if (other.gameObject.CompareTag("Turn90")) { if (taxiRunWay17ViaDJToA == true || taxiRunWay17ViaCJToA == true || taxiRunWay17ViaCJToB == true) { rotation90 = true; Debug.Log("va a girar ahora a 90"); } if (taxiRunWay35ViaDJToH == true || taxiRunWay35ViaDJToG == true) { Rotation270 = true;  } }

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

        //------------------------------------------Hold short of alfa 2------------------------------------------------------------
        if (other.gameObject.CompareTag("HoldShortC")) { if (HoldShortOfCharlie == true) { HoldingShortOfCharlie = true; MoveSpeed = 0; Debug.Log("Holding short of charlie"); } }
        //------------------------------------------------------------------------------------------------------

    }


    private void OnTriggerExit(Collider other)
    {
        //------------------------------PARA DESMARCAR LOS HOLDING SHORT CUANDO SALGA DE EL TRIGGER-----------------------------------------------------------------------
        Debug.Log("sali de el trigger"); HoldingShortOfJuliet = false; HoldingShortOfAlfa = false; HoldingShortOfCharlie = false;
        //-----------------------------------------------------------------------------------------------------
    }

    //-------------------TAXI RUN WAY 17 VIA CHARLEI JULIET TO ALFA HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    void MovetoWayPointR17VIACJ()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaCharlieJuliet[wayPointIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaCharlieJuliet[wayPointIndex].transform.position) { wayPointIndex += 1; }
        if (transform.position == R17ViaCharlieJuliet[7].transform.position) { taxiRunWay17ViaCJToA = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 17 VIA DELTA JULIET TO ALFA HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    void MovetoWayPointR17VIADJ()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaDeltaJuliet[R17ViaDeltaJulietIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaDeltaJuliet[R17ViaDeltaJulietIndex].transform.position) { R17ViaDeltaJulietIndex += 1; }
        if (transform.position == R17ViaCharlieJuliet[7].transform.position) { taxiRunWay17ViaDJToA = false; }
    }
    //------------------------------------------------------------------------------------------------------


    //-------------------TAXI RUN WAY 17 VIA CHARLIE JULIET TO BRAVO HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    void MovetoWayPointR17VIACJToB()
    {
        transform.position = Vector3.MoveTowards(transform.position, R17ViaCharlieJulietToBravo[R17ViaCharlieJulietToBravoIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R17ViaCharlieJulietToBravo[R17ViaCharlieJulietToBravoIndex].transform.position) { R17ViaCharlieJulietToBravoIndex += 1; }
        if (transform.position == R17ViaCharlieJulietToBravo[5].transform.position) { taxiRunWay17ViaCJToB = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 35  VIA DELTA JULIET TO HOTEL HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    void MovetoWayPointR35VIADJH()
    {
        transform.position = Vector3.MoveTowards(transform.position, R35ViaDeltaJulietH[R35ViaDeltaJulietHIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R35ViaDeltaJulietH[R35ViaDeltaJulietHIndex].transform.position) { R35ViaDeltaJulietHIndex += 1; }
        if (transform.position == R35ViaDeltaJulietH[4].transform.position) { taxiRunWay35ViaDJToH = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //-------------------TAXI RUN WAY 35  VIA DELTA JULIET TO GOLF HOLD SHORT OF RUN WAY-----------------------------------------------------------------------------------
    void MovetoWayPointR35VIADJG()
    {
        transform.position = Vector3.MoveTowards(transform.position, R35ViaDeltaJulietG[R35ViaDeltaJulietGIndex].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == R35ViaDeltaJulietG[R35ViaDeltaJulietGIndex].transform.position) { R35ViaDeltaJulietGIndex += 1; }
        if (transform.position == R35ViaDeltaJulietG[4].transform.position) { taxiRunWay35ViaDJToG = false; }
    }
    //------------------------------------------------------------------------------------------------------

    //--------------------------TAKE OFF RUN WAY 17----------------------------------------------------------------------------
    void takeOffRunWay17() 
    {
        transform.position = Vector3.MoveTowards(transform.position, TakeOffRunWay117[TakeOffRunWay17Index].transform.position, MoveSpeed * Time.deltaTime);
        if (transform.position == TakeOffRunWay117[TakeOffRunWay17Index].transform.position) { TakeOffRunWay17Index += 1; }
    }
    //------------------------------------------------------------------------------------------------------
    void TaxiSpeed () 
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




