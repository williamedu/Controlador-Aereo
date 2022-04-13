using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int SecuenciaDeAterrizaje = 1; 
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

     if (SecuenciaDeAterrizaje == 4) { SecuenciaDeAterrizaje = 1; }







    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("West")) { secuenciaUpdate(); print("cocho con west gm"); }
        if (other.gameObject.CompareTag("Visual")) { secuenciaUpdate(); print("cocho con visual GM"); }
        
    }

    void secuenciaUpdate () 
    {
        SecuenciaDeAterrizaje++;
        print("se deberia de aumentar el numero");
    }


}
