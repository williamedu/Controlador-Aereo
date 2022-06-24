using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class badgeAnim : MonoBehaviour
{

    public RectTransform badgeToAnim;
    public bool is_Selected;

   public void Selected()
    {
        badgeToAnim.DOScale(new Vector3(1.05f, 1.05f, 1f), 0.1f);
    }

    public void UnSelected()
    {
        badgeToAnim.DOScale(new Vector3(1.0f, 1.0f, 1f), 0.1f);
    }
}
