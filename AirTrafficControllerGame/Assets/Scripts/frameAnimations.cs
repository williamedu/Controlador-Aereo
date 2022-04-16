using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class frameAnimations : MonoBehaviour
{

    public float _cycleLenght;
    public RectTransform frame;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //taxyOptionAnimation();
    }

    public void taxyOptionAnimation()
    {
        frame.DOAnchorPos(new Vector2(-216.6773f, -10.83317f), _cycleLenght);

    }

    public void holdShortAnim()
    {
        frame.DOAnchorPos(new Vector2(-239, 29.6f), _cycleLenght);

    }


    public void removeOffScreen()
    {
        frame.DOAnchorPos(new Vector2(496, -11), _cycleLenght);
        //Invoke("disapear",2);
        

    }

    public void disapear()
    {
        gameObject.SetActive(false);
        //CancelInvoke();

    }

}
