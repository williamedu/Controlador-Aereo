using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class handlerAnimations : MonoBehaviour
{
    public bool On;
    public bool off;
    public RectTransform handle;
    public float _cycleLenght;
    public GameObject plane;
    private Transform parent;

    public void Awake()
    {
        parent = transform.parent.parent.parent.parent.parent.parent;
        plane = parent.gameObject;
    }
    public void Start()
    {
        

    }
    public void Update()
    {

    }

    public void ShortA()
    {
        if (off == false && On == false)
        {

            handle.DOAnchorPos(new Vector2(-25, 11.468f), _cycleLenght);
            On = true;
            plane.GetComponent<Aeronave>().HoldShortOfAlfa = true;
            return;
        }

        if (On == true && off == false)
        {
            handle.DOAnchorPos(new Vector2(-35.3f, 11.468f), _cycleLenght);
            On = false;
            plane.GetComponent<Aeronave>().HoldShortOfAlfa = false;

            return;

        }
    }

    public void ShortB()
    {
        if (off == false && On == false)
        {

            handle.DOAnchorPos(new Vector2(-25, 11.468f), _cycleLenght);
            On = true;
            plane.GetComponent<Aeronave>().HoldShortOfAlfa = true;
            return;
        }

        if (On == true && off == false)
        {
            handle.DOAnchorPos(new Vector2(-35.3f, 11.468f), _cycleLenght);
            On = false;
            plane.GetComponent<Aeronave>().HoldShortOfAlfa = false;

            return;



        }
    }


    public void ShortC()
    {
        if (off == false && On == false)
        {

            handle.DOAnchorPos(new Vector2(-25, 11.468f), _cycleLenght);
            On = true;
            plane.GetComponent<Aeronave>().HoldShortOfCharlie = true;
            return;
        }

        if (On == true && off == false)
        {
            handle.DOAnchorPos(new Vector2(-35.3f, 11.468f), _cycleLenght);
            On = false;
            plane.GetComponent<Aeronave>().HoldShortOfCharlie = false;

            return;

        }
    }

    public void ShortD()
    {
        if (off == false && On == false)
        {

            handle.DOAnchorPos(new Vector2(-25, 11.468f), _cycleLenght);
            On = true;
            plane.GetComponent<Aeronave>().HoldShortOfDelta = true;
            return;
        }

        if (On == true && off == false)
        {
            handle.DOAnchorPos(new Vector2(-35.3f, 11.468f), _cycleLenght);
            On = false;
            plane.GetComponent<Aeronave>().HoldShortOfDelta = false;

            return;

        }
    }

    public void ShortJ()
    {
        if (off == false && On == false)
        {

            handle.DOAnchorPos(new Vector2(-25, 11.468f), _cycleLenght);
            On = true;
            plane.GetComponent<Aeronave>().HoldShortOfJuliet = true;
            return;
        }

        if (On == true && off == false)
        {
            handle.DOAnchorPos(new Vector2(-35.3f, 11.468f), _cycleLenght);
            On = false;
            plane.GetComponent<Aeronave>().HoldShortOfJuliet = false;

            return;

        }
    }
}