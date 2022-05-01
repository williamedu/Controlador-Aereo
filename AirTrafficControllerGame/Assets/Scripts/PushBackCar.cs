using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBackCar : MonoBehaviour
{
    public Vector3 angle;
    public Vector3 offset = new Vector3(0, 60,0);
    public Aeronave parent;
    public GameObject padre;
    public Vector3 carPosition;
    float lockY;
    float speed = 5;
    float Turnspeed = 10;
    public bool turnR = false;
    public bool turnL = false;
   public bool MovingForward = false;
   public bool MovingR = false;
   public bool MovingS = false;

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
        carPosition.y = lockY;
        if (parent.taxing == true) { transform.parent = null; }

        if (parent.isFacingN == true) { MovingR = true; }

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

        if (parent.isFacingS == true) { MovingS = true; }
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



    public void TurnRight()
    {
        turnR = true;
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
    }
}
