using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testparent : MonoBehaviour
{
    public GameObject child;
    
    // Start is called before the first frame update
    void Start()
    {
        child = transform.GetChild(0).GetChild(1).gameObject;
       

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
