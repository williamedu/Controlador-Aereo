using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class pauseMenuAniButtom : MonoBehaviour
{
    public RectTransform button;

    public Animator _anin;
    public AudioManager audioManager;


    public void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        _anin = gameObject.GetComponent<Animator>();
    }

    
    public void OverAnim()
    {

        audioManager.PlayVFX("hover");

        _anin.SetBool("OverAnim",true);
           // button.DOScale(new Vector3(1.05f, 1.05f, 1f), 0.1f);  
    }

    public void Normal()
{
        _anin.SetBool("OverAnim", false);
        // button.DOScale(new Vector3(1, 1, 1), 0.1f);

    }
}
