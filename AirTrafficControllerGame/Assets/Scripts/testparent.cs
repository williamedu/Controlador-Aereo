using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testparent : MonoBehaviour
{

     Transform parent;
    public GameObject parent2;
    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent;

        parent2 = parent.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
