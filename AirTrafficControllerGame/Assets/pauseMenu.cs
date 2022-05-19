using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public RectTransform pauseMenuFrame;
    public SceneFader sceneFader;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            print("holla llego el escape");
            pauseMenuFrame.DOScale(Vector3.one, 0.2f).SetEase(Ease.InBounce);
        }
    }

    public void HidePauseMenu()
    {
        pauseMenuFrame.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBounce);

    }

    public void retry()
    {
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
}
