using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;



public class exit : MonoBehaviour
{
    public RectTransform frame;
    public float _cycle;


    void Start()
    {
        
    }

    public void exitAnim()
    {
        frame.DOAnchorPos(new Vector3(535, 0, 0), _cycle);
    }

}
