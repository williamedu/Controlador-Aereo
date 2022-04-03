using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tirilla : MonoBehaviour
{
    [SerializeField] private float _cycleLenght = 2;
    // Start is called before the first frame update
    void Start()
    {
        
        transform.DOMove(new Vector3(169.7f, 90.9f, 0),_cycleLenght);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
