using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onclick : MonoBehaviour
{
    public Outline craftOutLine;
    public static bool canClick = true;
    private void Start()
    {  
        craftOutLine = GetComponent<Outline>();
    }
    void OnMouseDown()
    {
        if (canClick == true)
        {
            // this object was clicked - do something
            transform.Find("PlaneUI").gameObject.SetActive(true);
            GetComponent<Aeronave>().isActive = true;
            //Debug.Log("se clickeo");
            //Destroy(this.gameObject);
        }
    }  
    public void OnMouseOver()
    {
       // Debug.Log("el over");
        craftOutLine.enabled = true;
    }

    public void OnMouseExit()
    {
        craftOutLine.enabled = false;

    }

    public void UnableToClick()
    {
        canClick = false;
    }
    
    public void ableToClick()
    {
        canClick = true;

    }
}
