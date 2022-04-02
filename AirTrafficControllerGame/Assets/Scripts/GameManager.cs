using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Transform[] Pista17ViaCJ;
    int wayPointIndex = 0;
    public GameObject[] aeronaves;
    public int MoveSpeed = 5;
    public bool taxiRunWay17ViaDJ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        //if (transform.position == wayPoints[0].transform.position)
        // { taxi = false; rotate90 = true; }



        if (taxiRunWay17ViaDJ == true)
        {
            aeronaves[0].transform.position = Vector3.MoveTowards(aeronaves[0].transform.position, Pista17ViaCJ[wayPointIndex].transform.position, MoveSpeed * Time.deltaTime);

            if (aeronaves[0].transform.position == Pista17ViaCJ[wayPointIndex].transform.position) { wayPointIndex += 1; }
        }


    }



}

