using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public int SecuenciaDeAterrizaje = 1;
    public int tirillaCounterAmarilla = 0;
    public int tirillaCounterAzul = 0;
    public float _cycleLenght = 0.3f;

    public bool airActive;

    [Header("Port Tirillas Amarillas ")]
    public GameObject port1;
    public GameObject port2;
    public GameObject port3;
    public GameObject port4;
    public GameObject port5;
    public GameObject port6;

    [Header("Port Tirillas azules ")]
    public GameObject portBLUE1;
    public GameObject portBLUE2;
    public GameObject portBLUE3;
    public GameObject portBLUE4;
    public GameObject portBLUE5;
    public GameObject portBLUE6;

    [Header("transformsAmarillas ")]
    public RectTransform T1;
    public RectTransform T2;
    public RectTransform T3;
    public RectTransform T4;
    public RectTransform T5;
    public RectTransform T6;

    [Header("transformsAmarillas ")]
    public RectTransform T1B;
    public RectTransform T2B;
    public RectTransform T3B;
    public RectTransform T4B;
    public RectTransform T5B;
    public RectTransform T6B;

    [Header("tirillas A ")]
    public GameObject A2;
    public GameObject A3;
    public GameObject A4;
    public GameObject A5;
    public GameObject A6;

    [Header("tirillas B ")]
    public GameObject B1;
    public GameObject B2;
    public GameObject B3;
    public GameObject B4;

    [Header("tirillas C ")]
    public GameObject C1;
    public GameObject C2;
    public GameObject C3;

    [Header("tirillas GA ")]
    public GameObject AV1;
    public GameObject AV2;
    public GameObject AV3;
    public GameObject AV4;

    [Header("tirillas AIRE ")]
    public GameObject AIR1;
    public GameObject AIR2;
    


    public bool TurnTirilla1 = false;
    // Start is called before the first frame update

    public void Awake()
    {

    }
    void Start()
    {
        airActive = false;
        _cycleLenght = 0.3f;
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

        //DESACTIVAR TIRILLAS DE AIRE

        if (airActive == false)
        {
            AIR1.gameObject.SetActive(false);
            AIR2.gameObject.SetActive(false);
        }

        if (airActive == true)
        {
            AIR1.gameObject.SetActive(true);
            AIR2.gameObject.SetActive(true);
        }

        if (SecuenciaDeAterrizaje == 4) { SecuenciaDeAterrizaje = 1; }
   
     if (tirillaCounterAmarilla == 1) { T1.DOAnchorPosX(480, _cycleLenght); }
     if (tirillaCounterAmarilla == 2) { T2.DOAnchorPosX(480, _cycleLenght); }
     if (tirillaCounterAmarilla == 3) { T3.DOAnchorPosX(480, _cycleLenght); }
     if (tirillaCounterAmarilla == 4) { T4.DOAnchorPosX(480, _cycleLenght); }
     if (tirillaCounterAmarilla == 5) { T5.DOAnchorPosX(480, _cycleLenght); }
     if (tirillaCounterAmarilla == 6) { T6.DOAnchorPosX(480, _cycleLenght); }

        if (tirillaCounterAzul == 1) { T1B.DOAnchorPosX(480, _cycleLenght); }
        if (tirillaCounterAzul == 2) { T2B.DOAnchorPosX(480, _cycleLenght); }
        if (tirillaCounterAzul == 3) { T3B.DOAnchorPosX(480, _cycleLenght); }
        if (tirillaCounterAzul == 4) { T4B.DOAnchorPosX(480, _cycleLenght); }
        if (tirillaCounterAzul == 5) { T5B.DOAnchorPosX(480, _cycleLenght); }
        if (tirillaCounterAzul == 6) { T6B.DOAnchorPosX(480, _cycleLenght); }


    }

    public void desactivarTirillasGround()
    {
        // DESACTIVA TIRILLAS DE A
        if (A2.GetComponentInParent<Aeronave>().isActive == true)
        {
            A2.gameObject.SetActive(false);
        }
        if (A3.GetComponentInParent<Aeronave>().isActive == true)
        {
            A3.gameObject.SetActive(false);
        }
        if (A4.GetComponentInParent<Aeronave>().isActive == true)
        {
            A4.gameObject.SetActive(false);
        }
        if (A5.GetComponentInParent<Aeronave>().isActive == true)
        {
            A5.gameObject.SetActive(false);
        }
        if (A6.GetComponentInParent<Aeronave>().isActive == true)
        {
            A6.gameObject.SetActive(false);
        }

        // DESACTIVA TIRILLAS DE B
        if (B1.GetComponentInParent<Aeronave>().isActive == true)
        {
            B1.gameObject.SetActive(false);
        }

        if (B2.GetComponentInParent<Aeronave>().isActive == true)
        {
            B2.gameObject.SetActive(false);
        }
        if (B3.GetComponentInParent<Aeronave>().isActive == true)
        {
            B3.gameObject.SetActive(false);
        }
        if (B4.GetComponentInParent<Aeronave>().isActive == true)
        {
            B4.gameObject.SetActive(false);
        }
        // DESACTIVA TIRILLAS DE C
        if (C1.GetComponentInParent<Aeronave>().isActive == true)
        {
            C1.gameObject.SetActive(false);
        }
        if (C2.GetComponentInParent<Aeronave>().isActive == true)
        {
            C2.gameObject.SetActive(false);
        }
        if (C3.GetComponentInParent<Aeronave>().isActive == true)
        {
            C3.gameObject.SetActive(false);
        }

        // DESACTIVA TIRILLAS DE AV
        if (AV1.GetComponentInParent<Aeronave>().isActive == true)
        {
            AV1.gameObject.SetActive(false);
        }

        if (AV2.GetComponentInParent<Aeronave>().isActive == true)
        {
            AV2.gameObject.SetActive(false);
        }
        if (AV3.GetComponentInParent<Aeronave>().isActive == true)
        {
            AV3.gameObject.SetActive(false);
        }
        if (AV4.GetComponentInParent<Aeronave>().isActive == true)
        {
            AV4.gameObject.SetActive(false);

        }

        
    }
    public void activarTirillasGround()
    
    {
        // ACTIVA TIRILLAS DE A
        if (A2.GetComponentInParent<Aeronave>().isActive == true)
        {
            A2.gameObject.SetActive(true);
        }

        if (A3.GetComponentInParent<Aeronave>().isActive == true)
        {
            A3.gameObject.SetActive(true);
        }
        if (A4.GetComponentInParent<Aeronave>().isActive == true)
        {
            A4.gameObject.SetActive(true);
        }
        if (A5.GetComponentInParent<Aeronave>().isActive == true)
        {
            A5.gameObject.SetActive(true);
        }
        if (A6.GetComponentInParent<Aeronave>().isActive == true)
        {
            A6.gameObject.SetActive(true);
        }
        // ACTIVA TIRILLAS DE B
        if (B1.GetComponentInParent<Aeronave>().isActive == true)
        {
            B1.gameObject.SetActive(true);
        }

        if (B2.GetComponentInParent<Aeronave>().isActive == true)
        {
            B2.gameObject.SetActive(true);
        }
        if (B3.GetComponentInParent<Aeronave>().isActive == true)
        {
            B3.gameObject.SetActive(true);
        }
        if (B4.GetComponentInParent<Aeronave>().isActive == true)
        {
            B4.gameObject.SetActive(true);
        }
        // ACTIVA TIRILLAS DE C
        if (C1.GetComponentInParent<Aeronave>().isActive == true)
        {
            C1.gameObject.SetActive(true);
        }
        if (C2.GetComponentInParent<Aeronave>().isActive == true)
        {
            C2.gameObject.SetActive(true);
        }
        if (C3.GetComponentInParent<Aeronave>().isActive == true)
        {
            C3.gameObject.SetActive(true);
        }

        // ACTIVAR TIRILLAS DE AV
        if (AV1.GetComponentInParent<Aeronave>().isActive == true)
        {
            AV1.gameObject.SetActive(true);
        }

        if (AV2.GetComponentInParent<Aeronave>().isActive == true)
        {
            AV2.gameObject.SetActive(true);
        }
        if (AV3.GetComponentInParent<Aeronave>().isActive == true)
        {
            AV3.gameObject.SetActive(true);
        }
        if (AV4.GetComponentInParent<Aeronave>().isActive == true)
        {
            AV4.gameObject.SetActive(true);

        }
    }

    public void desactivarPropsUI()
    {
        port1.gameObject.SetActive(false);
        port2.gameObject.SetActive(false);
        port3.gameObject.SetActive(false);
        port4.gameObject.SetActive(false);
        port5.gameObject.SetActive(false);
        port6.gameObject.SetActive(false);
    }

    public void activarProps()
    {
        port1.gameObject.SetActive(true);
        port2.gameObject.SetActive(true);
        port3.gameObject.SetActive(true);
        port4.gameObject.SetActive(true);
        port5.gameObject.SetActive(true);
        port6.gameObject.SetActive(true);
    }

    public void airTrue()
    {
        airActive = true;
    }

    public void airFalse()
    {
        airActive = false;
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
        CancelInvoke();
    }


    public void tirllaAmarilla()
    {
        tirillaCounterAmarilla = tirillaCounterAmarilla + 1;
    }

    public void tirillaAzul()
    {
        tirillaCounterAzul = tirillaCounterAzul + 1;
    }

}
