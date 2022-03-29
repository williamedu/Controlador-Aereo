using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Aeronave : MonoBehaviour
{
    public int speed;
    public Rigidbody RB;
    public float ForwardInput;
    public bool Rotation = false;
    private Transform ps;
    Vector3 startPos;
    public float turnSpeed = 16;
    public bool PushBack = false;
    public bool rodaje = false;
    [SerializeField] private NavMeshAgent NavMeshAgent;
    private Transform P1;
    public bool stoppush = false;
    public Transform[] wayPoints;
    [SerializeField] float MoveSpeed;
    int wayPointIndex = 0;
    public bool taxi = false;
    bool rotate90 = false;

    // Start is called before the first frame update
    void Start()
    {

        NavMeshAgent = GetComponent<NavMeshAgent>();
        RB = GetComponent<Rigidbody>();



    }

    // Update is called once per frame
    void Update()

    {
        if (transform.position == wayPoints[0].transform.position)
        { taxi = false; rotate90 = true; }



        //-------------------------------------------------------------------------------------------------------
        if (taxi == true)
        {
            moveToWayPoint();
        }

        //-------------------------------------------------------------------------------------------------------



        //hace que la aeronave se mueva hacia atras en su eje Z
        if (PushBack == true && rodaje == false) { transform.Translate(Vector3.back * speed * Time.deltaTime); }


        //hace que la aeronave se mueva hacia adelante en su eje Z
        if (rodaje == true) { speed = 6; transform.Translate(Vector3.forward * speed * Time.deltaTime); }


        //-------------------------------------------------------------------------------------------------------
        if (Rotation == true)

        {
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);
            if (transform.rotation.eulerAngles.y <= 180)
            {
                Debug.Log("se situo en 180 el heading");
                Rotation = false;
            }

        }

            if (rotate90 == true)

            {
                transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);
                if (transform.rotation.eulerAngles.y <= 90)
                {
                    Debug.Log("se situo en 90 el heading");
                    rotate90 = false;
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
            if (other.gameObject.CompareTag("Stop"))

            { speed = 0; Rotation = true; PushBack = false; Debug.Log("Stop??"); }

        }


        void moveToWayPoint()
        {
            transform.position = Vector3.MoveTowards(transform.position, wayPoints[wayPointIndex].transform.position, MoveSpeed * Time.deltaTime);
            if (transform.position == wayPoints[wayPointIndex].transform.position) { wayPointIndex += 1; }
        }

    }






