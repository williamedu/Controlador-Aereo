using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class planeStatus : MonoBehaviour
{
    public GameObject plane;
    public TextMeshProUGUI status;
    public string facingNorth;
    public string facingSouth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (plane.GetComponent<Aeronave>().PushBackFacingNorthB == true)
        {
            status.text = facingNorth;
        }
    }
}
