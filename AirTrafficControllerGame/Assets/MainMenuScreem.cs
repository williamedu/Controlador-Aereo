using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MainMenuScreem : MonoBehaviour
{

    public RectTransform campaingFrame;
    public RectTransform mainMenuScreen;
   

    public void showCampaing()
    {
        print("hola");
        mainMenuScreen.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBounce);

        campaingFrame.DOScale(Vector3.one, 0.2f).SetEase(Ease.InBounce);


    }

    public void hideCampaing()
    {
        campaingFrame.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBounce);
        
        mainMenuScreen.DOScale(Vector3.one, 0.2f).SetEase(Ease.InBounce);

    }
}
