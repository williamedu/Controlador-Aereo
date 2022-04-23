using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public int SecuenciaDeAterrizaje = 1;
    public int tirillaCounter = 0;

    public GameObject port1;
    public GameObject port2;
    public GameObject port3;
    public GameObject port4;
    public GameObject port5;
    public GameObject port6;

    public RectTransform T1;
    public RectTransform T2;
    public RectTransform T3;
    public RectTransform T4;
    public RectTransform T5;
    public RectTransform T6;
    public float _cycleLenght = 2;


    public bool TurnTirilla1 = false;
    // Start is called before the first frame update
    void Start()
    {
        port1 = GameObject.Find("tirilla1");
        port2 = GameObject.Find("tirilla2");
        port3 = GameObject.Find("tirilla3");
        port4 = GameObject.Find("tirilla4");
        port5 = GameObject.Find("tirilla5");
        port6 = GameObject.Find("tirilla6");

        //port1FinalPosition = new Vector3(port1.transform.position.x + 160, port1.transform.position.y, port1.transform.position.z);

       

        
    }

    // Update is called once per frame
    void Update()
    {

     if (SecuenciaDeAterrizaje == 4) { SecuenciaDeAterrizaje = 1; }


     
     if (tirillaCounter == 1) { T1.DOAnchorPos(new Vector2(480, 150.6f), _cycleLenght); }
     if (tirillaCounter == 2) { T2.DOAnchorPos(new Vector2(480, 91.9f), _cycleLenght); }
     if (tirillaCounter == 3) { T3.DOAnchorPos(new Vector2(480, 33.7f), _cycleLenght); }
     if (tirillaCounter == 4) { T4.DOAnchorPos(new Vector2(480, -25.3f), _cycleLenght); }
     if (tirillaCounter == 5) { T5.DOAnchorPos(new Vector2(480, -84.3f), _cycleLenght); }
     if (tirillaCounter == 6) { T6.DOAnchorPos(new Vector2(480, -143.3f), _cycleLenght); }


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


    public void tirilla()
    {
        tirillaCounter = tirillaCounter + 1;
    }


}
