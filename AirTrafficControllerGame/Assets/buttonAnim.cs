using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class buttonAnim : MonoBehaviour
{
    public RectTransform button;
    public void OverAnim()
    {
        button.DOScale(new Vector3(1.05f, 1.05f, 1f), 0.1f);
    }

    public void Normal()
    {
        button.DOScale(new Vector3(1, 1, 1), 0.1f);
    }

}
