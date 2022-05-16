using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class planeMoveTEST : MonoBehaviour
{

    public float _cycleLenght;
    [SerializeField] Transform planeMove;

    // Start is called before the first frame update
    void Start()
    {
        transform.DOMove(new Vector3(205.73f, 0.05000019f, 126.8f), _cycleLenght);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
