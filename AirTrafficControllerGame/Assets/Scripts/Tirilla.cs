using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Tirilla : MonoBehaviour
{
    [SerializeField] private float _cycleLenght = 2;

    public RectTransform tirilla;
    // Start is called before the first frame update
    void Start()
    {
        tirilla.DOAnchorPos(new Vector3(476.7f, 72.5f,0), _cycleLenght);
        //transform.DOMove(new Vector3(274.5F, 3.42F, 122.5F),_cycleLenght);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
