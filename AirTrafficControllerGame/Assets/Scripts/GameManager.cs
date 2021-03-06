using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    public bool desactivarTrillasAzules = false; // se a►4ade al update debajo de "desactivar tirillas azules" para que cuando se gane el nivel este bool se ponga true y tambien se desactiven las tirllas de aire
    public AudioManager audioManager;
    public int SecuenciaDeAterrizaje = 1;
    public int tirillaCounterAmarilla = 0;
    public int tirillaCounterAzul = 0;
    public float _cycleLenght = 0.3f;
    public int level;
    public GameObject pauseWinLvelFrame;
    public string nextLevel = "level02";
    public int levelToUnlock = 2;

    public bool airActive;

    public bool Call = true;
    [Header("badges con los buleanos ")]

    public Badges badges;

    [Header("todas las AERONAVES ")]
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
    public Transform A2;
    public Transform A3;
    public Transform A4;
    public Transform A5;
    public Transform A6;

    [Header("tirillas B ")]
    public Transform B1;
    public Transform B2;
    public Transform B3;
    public Transform B4;

    [Header("tirillas C ")]
    public Transform C1;
    public Transform C2;
    public Transform C3;

    [Header("tirillas GA ")]
    public Transform AV1;
    public Transform AV2;
    public Transform AV3;
    public Transform AV4;

    [Header("tirillas AIRE ")]
    public Transform AIR1;
    public Transform AIR2;
    


    public bool TurnTirilla1 = false;
    // Start is called before the first frame update

    public void Awake()
    {
       
        pauseWinLvelFrame.gameObject.GetComponent<pauseMenu>().GameIsPaused = false;
    }
    void Start()
    {
        //audioManager.gameObject.GetComponent<AudioManager>().PlayMusicBackGround("mainTheme");


        badges = GameObject.Find("Badges").GetComponent<Badges>();
        Call = true;

        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        airActive = false;
        _cycleLenght = 0.3f;
        port1 = GameObject.Find("tirilla1");
        port2 = GameObject.Find("tirilla2");
        port3 = GameObject.Find("tirilla3");
        port4 = GameObject.Find("tirilla4");
        port5 = GameObject.Find("tirilla5");
        port6 = GameObject.Find("tirilla6");

        badges.LoadBadges();


        //port1FinalPosition = new Vector3(port1.transform.position.x + 160, port1.transform.position.y, port1.transform.position.z);

    }

    public void winLevel()
    {
        Debug.Log("se gano el nivel");
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
    }

    // Update is called once per frame
    void Update()
    {


        //---------------------------------------------------------------------------------------------------------------------------------------------
        if(level == 1)
        {
            

            if (Call == true) 
            {

                //A6.GetComponentInParent<onclick>().InvokeAeronave(2);
                 
                //  A4.GetComponentInParent<onclick>().InvokeAeronave(18);
               
                B3.GetComponentInParent<onclick>().InvokeAeronave(2);

                C2.GetComponentInParent<onclick>().InvokeAeronave(1);
                //C1.GetComponentInParent<onclick>().InvokeAeronave(2);
                
               // A2.GetComponentInParent<onclick>().InvokeAeronave(17);
               // AV3.GetComponentInParent<onclick>().InvokeAeronave(30);
               // AV1.GetComponentInParent<onclick>().InvokeAeronave(39);
                Call = false; 
            }
            
            //A2.GetComponentInParent<onclick>().InvokeAeronave(2);
           
            /*
            A3.GetComponentInParent<onclick>().Invoke("ActivarAeronave", 2f);
            A4.GetComponentInParent<onclick>().Invoke("ActivarAeronave", 2f);
            A5.GetComponentInParent<onclick>().Invoke("ActivarAeronave", 2f);
            */
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------



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

    public void activarTirillasAire()
    {

        if (airActive == true)
        {
            AIR1.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
            AIR2.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
        }
    }

    public void desactivarTirillasAire()
    {
        //DESACTIVAR TIRILLAS DE AIRE

        if (airActive == false || desactivarTrillasAzules == true)
        {
            AIR1.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
            AIR2.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
        }
    }
    public void desactivarTirillasGround()
    {
        // DESACTIVA TIRILLAS DE A
        if (A2.GetComponentInParent<Aeronave>().isActive == true  )
        {
            A2.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
        }
        if (A3.GetComponentInParent<Aeronave>().isActive == true)
        {
            A3.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
        }
        if (A4.GetComponentInParent<Aeronave>().isActive == true)
        {
            A4.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
        }
        if (A5.GetComponentInParent<Aeronave>().isActive == true)
        {
            A5.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
        }
        if (A6.GetComponentInParent<Aeronave>().isActive == true)
        {
            A6.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
        }

        // DESACTIVA TIRILLAS DE B
        if (B1.GetComponentInParent<Aeronave>().isActive == true)
        {
            B1.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
        }

        if (B2.GetComponentInParent<Aeronave>().isActive == true)
        {
            B2.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
        }
        if (B3.GetComponentInParent<Aeronave>().isActive == true)
        {
            B3.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
        }
        if (B4.GetComponentInParent<Aeronave>().isActive == true)
        {
            B4.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
        }
        // DESACTIVA TIRILLAS DE C
        if (C1.GetComponentInParent<Aeronave>().isActive == true)
        {
            C1.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
        }
        if (C2.GetComponentInParent<Aeronave>().isActive == true)
        {
            C2.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
        }
        if (C3.GetComponentInParent<Aeronave>().isActive == true)
        {
            C3.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
        }

        // DESACTIVA TIRILLAS DE AV
        if (AV1.GetComponentInParent<Aeronave>().isActive == true)
        {
            AV1.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
        }

        if (AV2.GetComponentInParent<Aeronave>().isActive == true)
        {
            AV2.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
        }
        if (AV3.GetComponentInParent<Aeronave>().isActive == true)
        {
            AV3.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);
        }
        if (AV4.GetComponentInParent<Aeronave>().isActive == true)
        {
            AV4.DOScale(Vector3.zero, 0.1f).SetEase(Ease.InBounce);

        }

        
    }
    public void activarTirillasGround()
    
    {
        // ACTIVA TIRILLAS DE A
        if (A2.GetComponentInParent<Aeronave>().isActive == true)
        {
            A2.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
        }

        if (A3.GetComponentInParent<Aeronave>().isActive == true)
        {
            A3.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
        }
        if (A4.GetComponentInParent<Aeronave>().isActive == true)
        {
            A4.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
        }
        if (A5.GetComponentInParent<Aeronave>().isActive == true)
        {
            A5.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
        }
        if (A6.GetComponentInParent<Aeronave>().isActive == true)
        {
            A6.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
        }
        // ACTIVA TIRILLAS DE B
        if (B1.GetComponentInParent<Aeronave>().isActive == true)
        {
            B1.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
        }

        if (B2.GetComponentInParent<Aeronave>().isActive == true)
        {
            B2.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
        }
        if (B3.GetComponentInParent<Aeronave>().isActive == true)
        {
            B3.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
        }
        if (B4.GetComponentInParent<Aeronave>().isActive == true)
        {
            B4.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
        }
        // ACTIVA TIRILLAS DE C
        if (C1.GetComponentInParent<Aeronave>().isActive == true)
        {
            C1.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
        }
        if (C2.GetComponentInParent<Aeronave>().isActive == true)
        {
            C2.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
        }
        if (C3.GetComponentInParent<Aeronave>().isActive == true)
        {
            C3.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
        }

        // ACTIVAR TIRILLAS DE AV
        if (AV1.GetComponentInParent<Aeronave>().isActive == true)
        {
            AV1.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
        }

        if (AV2.GetComponentInParent<Aeronave>().isActive == true)
        {
            AV2.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
        }
        if (AV3.GetComponentInParent<Aeronave>().isActive == true)
        {
            AV3.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);
        }
        if (AV4.GetComponentInParent<Aeronave>().isActive == true)
        {
            AV4.DOScale(new Vector3(6.03f, 1.53f, 1), 0.3f).SetEase(Ease.InBounce);

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

    public void desactivarPortaTirrillasAzules()
    {
        portBLUE1.gameObject.SetActive(false);
        portBLUE2.gameObject.SetActive(false);
        portBLUE3.gameObject.SetActive(false);
        portBLUE4.gameObject.SetActive(false);
        portBLUE5.gameObject.SetActive(false);
        portBLUE6.gameObject.SetActive(false);

    }

    public void activarPortaTirillasAzules()
    {
        portBLUE1.gameObject.SetActive(true);
        portBLUE2.gameObject.SetActive(true);
        portBLUE3.gameObject.SetActive(true);
        portBLUE4.gameObject.SetActive(true);
        portBLUE5.gameObject.SetActive(true);
        portBLUE6.gameObject.SetActive(true);
    }


    public void desactivarTamarillasTAzulesPamarillasPAzules()
    {
        // esto es para desactivar porta tillias amarillas, las azules, las tirillas amarillas y azules de un fuetazo cuando se active el win level
        desactivarTrillasAzules = true;

        desactivarPortaTirrillasAzules();
        desactivarPropsUI();

        desactivarTirillasAire();
        desactivarTirillasGround();
        
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

    public void activarBackFrame()
    {
        pauseWinLvelFrame.SetActive(true);
    }

    public void tirllaAmarilla()
    {
        tirillaCounterAmarilla = tirillaCounterAmarilla + 1;
    }

    public void tirillaAzul()
    {
        tirillaCounterAzul = tirillaCounterAzul + 1;
    }

    public void callA2 ()

    {

    }

    public void SelectSound()
    {
        audioManager.PlayVFX("select");

    }
    public void HoverSound()
    {
        audioManager.PlayVFX("hover");

    }
    public void BackSound()
    {
        audioManager.PlayVFX("back");

    }

    public void SighnSound()
    {
        audioManager.PlayVFX("sighn");

    }

    public void PauseSound()
    {
        audioManager.PlayVFX("pause");

    }

    public void TirillaClickSound()
    {
        audioManager.PlayVFX("tirillaClickSound");

    }

    public void StopButton()
    {
        audioManager.PlayVFX("StopButton");

    }

    public void ContinueButton()
    {
        audioManager.PlayVFX("ContinueButton");

    }

    public void HoldShortOn()
    {
        audioManager.PlayVFX("HoldShortOn");

    }

    public void HoldShortOff()
    {
        audioManager.PlayVFX("HoldShortOff");

    }

    public void takeOffSound()
    {
        audioManager.PlayVFX("takeOff");

    }


    public void OnApplicationQuit()
    {
        badges.SaveBadges();
    }
}
