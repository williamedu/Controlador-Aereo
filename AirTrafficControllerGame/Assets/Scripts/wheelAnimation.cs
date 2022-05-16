using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class wheelAnimation : MonoBehaviour
{

    public float _cycleLenght;
    public Transform wheelFront;
    public Transform wheelBack;
    public Transform wheelBack2;
    public Transform planeHead;

    public bool ACTIVE = false;
    // Start is called before the first frame update
    void Start()
    {
        
      




    }
    
    // Update is called once per frame
    void Update()
    {
        if (ACTIVE == true) { hola(); }
    }



    public void hola()
    {
        //DOTween.Init();

        var sequence = DOTween.Sequence();

        sequence.Append(planeHead.DORotate(new Vector3(-10.635f, 0, 0), _cycleLenght).SetEase(Ease.InOutSine));
        // planeHead.DORotate(new Vector3(-10.635f, 0, 0), _cycleLenght).SetEase(Ease.InOutSine).OnComplete(() =>

        wheelFront.DORotate(new Vector3(91.31299f, 0, 0), _cycleLenght);
        wheelBack.DOMoveY((3.96F), _cycleLenght);
        wheelBack2.DOMoveY((3.96F), _cycleLenght);
    }
}
