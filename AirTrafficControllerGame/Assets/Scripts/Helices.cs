using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helices : MonoBehaviour
{

    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Helices")) { transform.Rotate(Vector3.up * speed * Time.deltaTime); }
        if (gameObject.CompareTag("Rotor")) { transform.Rotate(Vector3.left * speed * Time.deltaTime); }
        if (gameObject.name == "heli") { transform.Translate(Vector3.forward * speed * Time.deltaTime); }
         
    }
}
