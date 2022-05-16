using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class QuestFrameAnim : MonoBehaviour
{

    public RectTransform FRAMEQUEST;
    public GameObject completion1;
    public GameObject completion2;
    public GameObject completion3;
    // Start is called before the first frame update
    public void FrameAppearAnim()
    {
        FRAMEQUEST.DOScale(Vector3.one, 0.3f).SetEase(Ease.InBounce);
    }

    public void FrameDisapearAnim()
    {
        FRAMEQUEST.DOScale(Vector3.zero, 0.3f).SetEase(Ease.InBounce);
    }

    public void ConditionsAppearAnim()
    {
        FRAMEQUEST.DOScale(new Vector3(1.56f,1,1), 0.3f).SetEase(Ease.InBounce);
    }
}
