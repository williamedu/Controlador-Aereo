using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class tirillaAnimations : MonoBehaviour
{
    public float _cycleLenght = 0.5f;
    public RectTransform tirilla;
    public GameObject plane;
    private Transform parent;

    
    void Start()
    {
        parent = transform.parent.parent;
        plane = parent.gameObject;
        tirilla.DOAnchorPos(new Vector2(497.7f, 76.19f), _cycleLenght);
    }

    public void Update()
    {
        if (plane.GetComponent<Aeronave>().tirillaOffScreen == true)
        {
            removeTirillaOfScreem();
        }

    }
    public void centerTirillaOnScreem()
    {
        tirilla.DOAnchorPos(new Vector2(361, 77), _cycleLenght);

    }

    public void backToSide()
    {
        tirilla.DOAnchorPos(new Vector2(497.7f, 76.19f), _cycleLenght);

    }

    public void removeTirillaOfScreem()
    {
        tirilla.DOAnchorPos(new Vector2(683,-20), _cycleLenght).OnComplete(() => destruirTirilla());

    }

    public void destruirTirilla()
    {
        this.gameObject.SetActive(false);
        plane.GetComponent<Aeronave>().destruirAeronave();
    }
}
