using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class GeneralAnimButtton : MonoBehaviour
{
    public RectTransform buttonToAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hoverAnim()
    {
        buttonToAnim.DOScale(new Vector3(1.05f, 1.05f, 1.05f), 0.1f);
    }

    public void backToNormal()
    {
        buttonToAnim.DOScale(Vector3.one, 0.1f);
    }
}
