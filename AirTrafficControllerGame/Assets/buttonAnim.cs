using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class buttonAnim : MonoBehaviour
{
    public RectTransform button;
    public bool canHover = true;
    public GameObject Lock;

  
    public void OverAnim()
    {
        if(!Lock.activeSelf)
            
         {
            //print("si esta activo");
            button.DOScale(new Vector3(1.05f, 1.05f, 1f), 0.1f);

        }

     


    }

    public void Normal()
    {
        if (!Lock.activeSelf)
        {
            //print("si sigue activo");

            button.DOScale(new Vector3(1, 1, 1), 0.1f);
        }



    }

}
