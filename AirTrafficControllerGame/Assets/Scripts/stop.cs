using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{
    public GameObject plane;
    private Transform parent;

    public void Awake()
    {
        parent = transform.parent.parent.parent;
        plane = parent.gameObject;

    }

    public void Start()
    {
        this.gameObject.SetActive(false);
    }

    public void stopPlane()
    {
        plane.GetComponent<Aeronave>().HoldPosition = true;
    }

    public void stopPlaneaAir()
    {
        plane.GetComponent<Approach>().HoldPosition = true;
    }

    public void continueMovingAir()
    {
        plane.GetComponent<Approach>().HoldPosition = false;

    }
    public void continueMoving()
    {
        plane.GetComponent<Aeronave>().HoldPosition = false;

    }


}
