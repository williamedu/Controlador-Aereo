using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class valueChanger : MonoBehaviour
{
    public Scrollbar scrollBar;
    public bool full;

    // Start is called before the first frame update
    void Start()
    {
        full = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (full == true)
        {
            scrollBar.value = 1;
            full = false;
        }
    }
}
