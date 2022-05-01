using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    public bool rotate = false;
    public float speed = 0;
    public Aeronave propellerPlane;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0;
        propellerPlane = transform.parent.gameObject.GetComponent<Aeronave>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (propellerPlane.PushBackFacingNorthB == true || propellerPlane.PushBackFacingSouthB == true) { rotate = true; }

        if (rotate == true) {
            speed = speed + 20 * Time.deltaTime;
            transform.Rotate(Vector3.forward * speed * Time.deltaTime); }

        if (speed == 1500) { speed = 1500; }
       
    }
}
