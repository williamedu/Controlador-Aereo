using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onclick : MonoBehaviour
{
    public Outline craftOutLine;

    private void Start()
    {  
        craftOutLine = GetComponent<Outline>();
    }
    void OnMouseDown()
    {
        // this object was clicked - do something
        transform.Find("PlaneUI").gameObject.SetActive(true);     
        //Debug.Log("se clickeo");
        //Destroy(this.gameObject);
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

    
}
