using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCircuit : MonoBehaviour
{
    public Transform[] Circuit1;
    public int Circuit1Index = 0;

    public Transform[] Circuit2;
    public int Circuit2Index = 0;

    Rigidbody rigitbody;

    public MenuManager MenuManager;







    public bool Circcuit1 = false;
    public bool Circcuit2 = false;
   public  bool Turn90 = false;
     bool Turn90V = false;
     bool Turn180 = false;
     bool Turn180V = false;
     bool Turn270 = false;
     bool Turn270V = false;
     bool Turn360 = false;
     bool Turn360V = false;
    public bool rodaje = false;

    public float speed;
    public float turnSpeed;
    public int Decision = 0;
    // Start is called before the first frame update

    private void Awake()
    {
        
    }
    void Start()
    {
       
        rigitbody = gameObject.GetComponent<Rigidbody>();
        MenuManager = GameObject.FindGameObjectWithTag("MenuManager").GetComponent<MenuManager>();
    }

    // Update is called once per frame
    void Update()

    {
        if (gameObject.CompareTag("BagCar")) { Decision = 1; }


       

       if (Circcuit1 == true) { circuit1(); }
       if (Circcuit2 == true) { circuit2(); }
       if (Decision > 4) { Circcuit2 = true; Circcuit1 = false; }
       if (Decision <= 4  ) { Circcuit1 = true; Circcuit2 = false; }

        if (rodaje == true) { transform.Translate(Vector3.forward * speed * Time.deltaTime); }

        //fix bug 
        


        if (Turn90 == true)
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y >= 90)
            {
                

                Turn90 = false;
            }
        }


        if (Turn90V == true)
        {
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y <= 90)
            {

                Turn90V = false;
            }
        }

        if (Turn180 == true)
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y >= 180)
            {

                Turn180 = false;
            }
        }

        if (Turn180V == true)
        {
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y <= 180)
            {
                
                Turn180V = false;
            }

        }

        if (Turn270 == true )
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y >= 270)
            {

                Turn270 = false; 
            }
        }

        if (Turn270V == true)
        {
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y <= 270)
            {

                Turn270V = false;
            }
        }
        if (Turn360 == true)
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y <= 259)
            {

                Turn360 = false;
                
            }
        }

        if (Turn360V == true)
        {
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y >= 259)
            {

                Turn360V = false;
                
            }
        }

    }



    public void circuit1()
    {
        //INICIA SU RECORRIDO ATRAVEZ DEL CIRCUITO 1
        transform.position = Vector3.MoveTowards(transform.position, Circuit1[Circuit1Index].transform.position, speed * Time.deltaTime);
        if (transform.position == Circuit1[Circuit1Index].transform.position) { Circuit1Index += 1; }
        if (transform.position == Circuit1[3].transform.position) { Circuit1Index = 0; }




    }

    public void circuit2()
    {
        //INICIA SU RECORRIDO ATRAVEZ DEL CIRCUITO 2
        transform.position = Vector3.MoveTowards(transform.position, Circuit2[Circuit2Index].transform.position, speed * Time.deltaTime);
        if (transform.position == Circuit2[Circuit2Index].transform.position) { Circuit2Index += 1; }
        if (transform.position == Circuit2[7].transform.position) { Circuit2Index = 0; }

    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Turn90"))  {   Turn90  = true; }
        if (other.gameObject.CompareTag("Turn90V"))  {  Turn90V  = true; }
        if (other.gameObject.CompareTag("Turn180V"))  { if (Circcuit2 == true) { Turn180 = true; } }
        if (other.gameObject.CompareTag("Turn180")) {  Turn180 = true; }
        if (other.gameObject.CompareTag("Turn180VV")) {  Turn180V = true; }
        if (other.gameObject.CompareTag("Turn270")) {  Turn270 = true; }
        if (other.gameObject.CompareTag("Turn270V")) {  Turn270V = true; }
        if (other.gameObject.CompareTag("Turn360")) {  Turn360 = true; }
        if (other.gameObject.CompareTag("Turn259")) {  Turn360V = true; }

        if (other.gameObject.CompareTag("GravityOff") ) { rigitbody.useGravity = false;  }
        if (other.gameObject.CompareTag("GravityOn") ) { rigitbody.useGravity = true;  }
        if (other.gameObject.CompareTag("KineticOn") ) { rigitbody.isKinematic = true;  }

        if (other.gameObject.CompareTag("Decision") ) { bakeDecision(); }
        if (other.gameObject.CompareTag("TaxiCarIssue") ) { if (gameObject.CompareTag("TaxiCar") && Circcuit2 == true) { Circuit2Index = 5; } }
        if (other.name == ("taxicarTurnFix") && Turn90 == false) { if (gameObject.CompareTag("TaxiCar")) { Turn90 = true; print("se activo gracias al fix"); } }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("KineticOn")) { rigitbody.isKinematic = false; }
        if (other.gameObject.CompareTag("Corredor")) { MenuManager.CanPass = true; }


    }

    private void OnTriggerStay(Collider other)
    {
       if (other.gameObject.CompareTag("Corredor")) { MenuManager.CanPass = false; }
        if (other.gameObject.CompareTag("Elevado") && MenuManager.CanPass == false) { speed = 0; }
        if (other.gameObject.CompareTag("Elevado") && MenuManager.CanPass == true) { speed = 4; }

    }




    void bakeDecision()
    {
        Decision = Random.Range(1, 8);
        
    }


    void decision1()
    {
        Circcuit1 = true; 
        Circcuit2 = false;
      
    }

    void decision2()
    {
        Circcuit1 = false;
        Circcuit2 = true;
       
    }

    public void stop()
    {
        speed = 0;
        
    }

   public void continuee()
    {
        speed = 4;
        
    }
}
