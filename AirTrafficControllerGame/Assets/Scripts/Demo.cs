using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Demo : MonoBehaviour {

   [SerializeField] Timer timer1 ;

    public RectTransform timerGO;
    public RectTransform routeDropDown;
    public RectTransform requestATCbutton;


    private void Start () {
        timer1
        .SetDuration(Random.Range(30,60))
      .OnEnd(() => desactivate())
      .Begin () ;
        
    }

    public void desactivate()
    {
        print("tiempo limite");
        timerGO.DOScale(Vector3.zero, 0.3f).SetEase(Ease.InBounce);
        requestATCbutton.DOScale(Vector3.zero, 0.3f).SetEase(Ease.InBounce);
        routeDropDown.DOScale(new Vector3 (0.1658375f, 0.6535947f,1),0.3f).SetEase(Ease.InBounce);
        this.gameObject.SetActive(false);
    }

}
