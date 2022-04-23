using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlusSighnAnim : MonoBehaviour
{

    public RectTransform sighn;

    void Start()
    {
        sighn.DOScale(Vector3.one, 0.3f).SetEase(Ease.Flash);
    }

    public void disapear()
    {
        sighn.DOScale(Vector3.zero, 0.3f).SetEase(Ease.InBounce);

    }

}
