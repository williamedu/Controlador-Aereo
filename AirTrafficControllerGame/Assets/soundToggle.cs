using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class soundToggle : MonoBehaviour
{
    public Image imageToToggle;
    public bool toggle;

    public void Start()
    {
        toggle = true;
    }
    public void toggleImage()
    {
        if (toggle == false)
        {
            imageToToggle.GetComponent<Image>().color = new Color32(28, 182, 247, 255);
        }

        else if (toggle == true)
        {
            imageToToggle.GetComponent<Image>().color = new Color32(101, 106, 108, 255);
        }
    }

    public void boolToggle()
    {
        if (toggle == false)
        {
            toggle = true;
        }

        else if(toggle == true)
        {
            toggle = false;
        }
    }
}
