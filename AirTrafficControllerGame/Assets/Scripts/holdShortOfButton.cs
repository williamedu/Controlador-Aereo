using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class holdShortOfButton : MonoBehaviour
{
    public RectTransform frame;
    public float _cycleLenght;


    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    public void disapear()
    {
        gameObject.SetActive(false);
        //CancelInvoke();

    }

    public void holdShortOffOptionAnimation()
    {
        frame.DOAnchorPos(new Vector2(-238.6f, 29.6f), _cycleLenght);

    }

    public void removeOffScreen()
    {
        frame.DOAnchorPos(new Vector2(526, 29.6f), _cycleLenght).OnComplete(() => disapear());
        //Invoke("disapear",2);


    }


}
