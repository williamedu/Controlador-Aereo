using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onclick : MonoBehaviour
{
    public float ActivacionAeronave = 10000;

    public static bool canClick = true;
    public bool activar;
    public Outline craftOutLine;
    private void Start()
    {
        
       Invoke("ActivarAeronave", ActivacionAeronave);
        craftOutLine = GetComponent<Outline>();
    }

    public void Update()
    {
        if (activar == true)
        {
            craftOutLine.enabled = true;
        }
    }
    void OnMouseDown()
    {
        if (canClick == true && activar== true)
        {
            // this object was clicked - do something
            transform.Find("PlaneUI").gameObject.SetActive(true);
            GetComponent<Aeronave>().isActive = true;
            craftOutLine.enabled = false;
            activar = false;

            //desechable
            //activar = false; se desactivo ahora
            //Debug.Log("se clickeo");
            //Destroy(this.gameObject);
        }
    }  
    /*public void OnMouseOver()
    {
       // Debug.Log("el over");
        craftOutLine.enabled = true;
    }*/

   /* public void OnMouseExit()
    {
        craftOutLine.enabled = false;

    }*/

    public void ActivarAeronave()
    {
        activar = true;
    }
    public void UnableToClick()
    {
        canClick = false;
    }
    
    public void ableToClick()
    {
        canClick = true;

    }

     /*IEnumerator luces()
    {
        if (activarLuces == true)
        {
            craftOutLine.enabled = true;
            yield return new WaitForSeconds(3);
            craftOutLine.enabled = false;
        }
    }*/
}
