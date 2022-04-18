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
    // Start is called before the first frame update
    void Start()
    {
        //DOTween.Init();

        var sequence = DOTween.Sequence();

        sequence.Append(planeHead.DORotate(new Vector3(-10.635f, 0, 0), _cycleLenght).SetEase(Ease.InOutSine));
       // planeHead.DORotate(new Vector3(-10.635f, 0, 0), _cycleLenght).SetEase(Ease.InOutSine).OnComplete(() =>

        wheelFront.DORotate(new Vector3(91.31299f, 0, 0), _cycleLenght);
        wheelBack.DOMoveY((3.96F), _cycleLenght);
        wheelBack2.DOMoveY((3.96F), _cycleLenght);





    }
    public void hola()
    {
        print("hola");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
