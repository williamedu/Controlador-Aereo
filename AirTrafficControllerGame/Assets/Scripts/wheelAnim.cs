using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class wheelAnim : MonoBehaviour
{

    public RectTransform wheel;
    void Start()
    {
        //wheel.DORotate(new Vector3(0f, 0f, -1000f), 5).SetLoops(-1);
        wheel.DOLocalRotate(new Vector3(0f, 0f, -1000), 1).SetLoops(-1);
    }

   
}
