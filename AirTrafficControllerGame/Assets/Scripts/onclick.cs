using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onclick : MonoBehaviour
{
    public float ActivacionAeronave = 10000;
    public static bool canClick = true;
    public bool activar;
    public Outline craftOutLine;
    public AudioManager audioManager;
    public float constt = 2;
    public bool tryingToTalk = false;
    public bool tryToTalk = false;

    public float cliplength = 0;

    private void Start()
    {
        



        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        // Invoke("ActivarAeronave", ActivacionAeronave);
        craftOutLine = GetComponent<Outline>();
    }

    public void Update()
    {
        if (activar == true)
        {
            craftOutLine.enabled = true;
        }


        if (tryToTalk == true)
        {
            if (audioManager.hablando == false) { talkiing(); tryToTalk = false; }
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
            this.gameObject.GetComponent<Waypoint_Indicator>().enableGameObject = false;
            this.gameObject.GetComponent<Waypoint_Indicator>().enableText = true;
            this.gameObject.GetComponent<Waypoint_Indicator>().enableSprite = true;

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
        this.gameObject.GetComponent<Waypoint_Indicator>().enableGameObject = true;
        
        tryToTalk = true;
       // StartCoroutine(playsound());
        //audioManager.Play(gameObject.name);
        //  else if (!audioSource.isPlaying) { audioManager.Play(gameObject.name); voice = false; }

        CancelInvoke();

    }

    IEnumerator playsound()
    {
        cliplength = audioManager.wait1;
        print("la duracion del clip que esta en cola es de  " + cliplength);
        yield return new WaitForSeconds(cliplength );
        
        
        print("se le dio play ");
    }


    public void talkiing()
    {
        audioManager.Play(gameObject.name + "P");
        
        
    }



    public void InvokeAeronave(int i)
    {
       
        Invoke("ActivarAeronave", i);
       
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
//----------------codigo de espaciador de audio funcional-----------------------

// (voz == true)
//{
   // if (audioManager.fuentes[0].isPlaying) { cliplength = audioManager.fuentes[0].clip.length + constt; voz = false; print(audioManager.fuentes[0].clip.name); }
   // if (audioManager.fuentes[1].isPlaying) { cliplength = audioManager.fuentes[1].clip.length + constt; voz = false; print(audioManager.fuentes[1].clip.name); }
   // if (audioManager.fuentes[2].isPlaying) { cliplength = audioManager.fuentes[2].clip.length + constt; voz = false; print(audioManager.fuentes[2].clip.name); }
   // if (audioManager.fuentes[3].isPlaying) { cliplength = audioManager.fuentes[3].clip.length + constt; voz = false; print(audioManager.fuentes[3].clip.name); }
   // if (audioManager.fuentes[4].isPlaying) { cliplength = audioManager.fuentes[4].clip.length + constt; voz = false; print(audioManager.fuentes[4].clip.name); }
   // if (audioManager.fuentes[5].isPlaying) { cliplength = audioManager.fuentes[5].clip.length + constt; voz = false; print(audioManager.fuentes[5].clip.name); }
   // if (audioManager.fuentes[6].isPlaying) { cliplength = audioManager.fuentes[6].clip.length + constt; voz = false; print(audioManager.fuentes[6].clip.name); }
   // if (audioManager.fuentes[7].isPlaying) { cliplength = audioManager.fuentes[7].clip.length + constt; voz = false; print(audioManager.fuentes[7].clip.name); }
   // if (audioManager.fuentes[8].isPlaying) { cliplength = audioManager.fuentes[8].clip.length + constt; voz = false; print(audioManager.fuentes[8].clip.name); }
   // if (audioManager.fuentes[9].isPlaying) { cliplength = audioManager.fuentes[9].clip.length + constt; voz = false; print(audioManager.fuentes[9].clip.name); }
   // if (audioManager.fuentes[10].isPlaying) { cliplength = audioManager.fuentes[10].clip.length + constt; voz = false; print(audioManager.fuentes[10].clip.name); }


//}