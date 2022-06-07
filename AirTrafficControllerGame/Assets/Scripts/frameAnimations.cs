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

    public void takeOffButtonAnim()
    {
        frame.DOAnchorPos(new Vector2(-217.5f, -10.83317f), _cycleLenght);

    }

    public void takeOffRemoveAnim()
    {
        frame.DOAnchorPos(new Vector2(277, -10.83317f), _cycleLenght);

    }

    public void taxyOptionAnimation()
    {
        frame.DOAnchorPos(new Vector2(-244.3f, -11.4f), _cycleLenght);

    }

    public void takeOffFrameAnim()
    {
        frame.DOAnchorPos(new Vector2(-176.9f, -11.4f), _cycleLenght);

    }

    public void holdShortAnim()
    {
        frame.DOAnchorPos(new Vector2(-347, 29.6f), _cycleLenght);

    }


    public void removeOffScreen()
    {
        frame.DOAnchorPos(new Vector2(293, -11.4f), _cycleLenght).OnComplete(() => disapear());
        //Invoke("disapear",2);
    }

    public void removeOffScreenHoldShortOff()
    {
        frame.DOAnchorPos(new Vector2(412, 29.6f), _cycleLenght).OnComplete(() => disapear());
        //Invoke("disapear",2);
    }



    public void disapear()
    {
        gameObject.SetActive(false);
        //CancelInvoke();

    }

    public void bounceoutAnim()
    {
        frame.DOAnchorPos(Vector3.zero, 0.5f).SetEase(Ease.InBounce).onComplete();
        {
            print("maldito dootween");
            //frame.DOAnchorPos(new Vector2(-216.6773f, -10.83317f), _cycleLenght);

        }


    }

    }


