using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class tips : MonoBehaviour
{

    public RectTransform tip;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void animate()
    {
        tip.DOAnchorPosX(1124, 0.2f);

    }
}
