using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBackCar : MonoBehaviour
{
    public Vector3 angle;
    public Vector3 offset = new Vector3(0, 60, 0);
    public Aeronave parent;
    public GameObject padre;
    public Vector3 carPosition;
    float lockY;
    public float speed = 5;
    public float speed2 = 20;
    float Turnspeed = 10;
    public bool turnR = false;
    public bool turnL = false;
    public bool MovingForward = false;
    public bool MovingR = false;
    public bool MovingS = false;
    public bool c1 = false;
    public bool c2 = false;
    public bool c3 = false;
    public bool c1car = false;
    public bool c2car = false;
    public bool c3car = false;
    public bool A4car = false;
    public bool A5car = false;
    public bool A6car = false;
    public bool C123 = false;
    public bool Check = false;

    // Start is called before the first frame update


    void Start()
    {
        padre = transform.parent.gameObject;
        carPosition.y = lockY;
        carPosition = transform.position;
        parent = transform.parent.gameObject.GetComponent<Aeronave>();





    }

    // Update is called once per frame
    void Update()
    {
        



            if (padre.gameObject.CompareTag("C1") || padre.gameObject.CompareTag("C2") || padre.gameObject.CompareTag("C3") ||  padre.gameObject.CompareTag("A4") || padre.gameObject.CompareTag("A5") || padre.gameObject.CompareTag("A6"))

        {


            carPosition.y = lockY;

            
            if (padre.GetComponent<Aeronave>().isFacingN == true || padre.GetComponent<Aeronave>().isFacingS == true)
            {
                transform.parent = null; 
                if (padre.gameObject.CompareTag("C1")) { c1car = true; } 
                if (padre.gameObject.CompareTag("C2")) { c2car = true; }
                if (padre.gameObject.CompareTag("C3")) { c3car = true; }
                if (padre.gameObject.CompareTag("A4")) { A4car = true; }
                if (padre.gameObject.CompareTag("A5")) { A5car = true; }
                if (padre.gameObject.CompareTag("A6")) { A6car = true; }
            }

            if (c1car == true)
            {
                Invoke("MovingForwarddactive", 2); if (MovingForward == true) { MovingForwardd(); }
                if (padre.gameObject.CompareTag("C1")) { Invoke("C1", 4); }
                if (c1 == true) { charlies(); }
            }

            if (c2car == true)
            {
                Invoke("MovingForwarddactive", 2); if (MovingForward == true) { MovingForwardd(); }
                if (padre.gameObject.CompareTag("C2")) { Invoke("C1", 18); }
                if (c1 == true) { charlies(); }
            }

            if (c3car == true)
            {
                Invoke("MovingForwarddactive", 2); if (MovingForward == true) { MovingForwardd(); }
                if (padre.gameObject.CompareTag("C3")) { Invoke("C1", 32); }
                if (c1 == true) { charlies(); }
            }

            if (A4car == true)
            {
                Invoke("MovingForwarddactive", 0.5f); if (MovingForward == true) { MovingForwardd(); }
                if (padre.gameObject.CompareTag("A4")) { Invoke("C1", 2); }
                if (c1 == true) { ALFAS4(); }
            }
            if (A5car == true)
            {
                Invoke("MovingForwarddactive", 2); if (MovingForward == true) { MovingForwardd(); }
                if (padre.gameObject.CompareTag("A5")) { Invoke("C1", 4); }
                if (c1 == true) { ALFAS5(); }
            }

            if (A6car == true)
            {
                Invoke("MovingForwarddactive", 1); if (MovingForward == true) { MovingForwardd(); }
                if (padre.gameObject.CompareTag("A6")) { Invoke("C1", 2); }
                if (c1 == true) { ALFAS6(); }
            }

        }





        else
        {


            carPosition.y = lockY;
            //if (parent.taxing == true) { transform.parent = null; }

            if (parent.isFacingN == true) { MovingR = true; transform.parent = null; }

            if (MovingR == true)
            {
                Invoke("TurnLeft", 4);
                Invoke("MovingForwarddactive", 2);
                if (MovingForward == true) { MovingForwardd(); }

                if (turnL == true)
                {
                    transform.Rotate(Vector3.down * speed * Time.deltaTime);
                    if (transform.rotation.eulerAngles.y >= 255) { print("carrito con heading de 0"); turnL = false; }
                }




            }

            if (parent.isFacingS == true) { MovingS = true; transform.parent = null; }
            if (MovingS == true)
            {
                print("aeronave del carrito is facing south");
                Invoke("TurnRight", 4);
                Invoke("MovingForwarddactive", 2);
                if (MovingForward == true) { MovingForwardd(); }

                if (turnR == true)
                {
                    transform.Rotate(Vector3.up * speed * Time.deltaTime);
                    if (transform.rotation.eulerAngles.y <= 255) { print("carrito con heading de 0"); turnR = false; }
                }




            }
        }
    }



    public void TurnRight()
    {
        turnR = true;
        print("se invoco turn r");
        CancelInvoke();
    }

    public void TurnLeft()
    {
        turnL = true;
       CancelInvoke();
    }


    public void MovingForwardd()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void MovingForwarddactive()
    {
        MovingForward = true;
        print("se activo move forward");
      //  CancelInvoke();
    }


    void C1()
    {
        c1 = true;

        CancelInvoke();
    }

    void C2()
    {

    }

    void C3()
    {

    }

    void charlies () 
    {
        print("el carrito debe empezar a doblar");
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
        if (transform.rotation.eulerAngles.y <= 258) { print("carrito con heading de 0"); c1 = false; }
    }

    void ALFAS4()
    {
        transform.Rotate(Vector3.down * speed2 * Time.deltaTime);
        if (transform.rotation.eulerAngles.y >= 258) { print("carrito con heading de 0"); c1 = false; }
        print("llegoooo");
    }

    void ALFAS5()
    {
        transform.Rotate(Vector3.down * speed2 * Time.deltaTime);
        if (transform.rotation.eulerAngles.y <= 90) { print("carrito con heading de 90"); c1 = false; }
        print("llegoooo");
    }

    void ALFAS6()
    {
        transform.Rotate(Vector3.up * speed2 * Time.deltaTime);
        if (transform.rotation.eulerAngles.y <= 258) { print("carrito con heading de 90"); c1 = false; }
        print("llegoooo");
    }

    void check()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PushBackCarsDestroyer"))
        {
            Destroy(gameObject);
            print("cocho con destroyer");
        }
    }

}
