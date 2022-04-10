using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class tirillaAnimations : MonoBehaviour
{
    public float _cycleLenght;
    public RectTransform tirilla;

    
    void Start()
    {
        tirilla.DOAnchorPos(new Vector2(497.7f, 76.19f), _cycleLenght);
    }

public void centerTirillaOnScreem()
    {
        tirilla.DOAnchorPos(new Vector2(361, 77), _cycleLenght);

    }

    public void backToSide()
    {
        tirilla.DOAnchorPos(new Vector2(497.7f, 76.19f), _cycleLenght);

    }
}
