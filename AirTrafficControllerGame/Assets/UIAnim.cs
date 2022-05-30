using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIAnim : MonoBehaviour
{
    public RectTransform UIframe;
   

    public void animUI()
    {
        UIframe.DOScale(new Vector3(1.05f, 1.05f, 1f), 0.1f);
    }

    public void animUINormal()
    {
        UIframe.DOScale(Vector3.one, 0.1f);
    }
}
