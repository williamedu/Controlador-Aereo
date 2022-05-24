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
    public GameObject pauseCanvas;
    public RectTransform SettingsMenuFrame;
    public static bool GameIsPaused = false;
    public bool ImOnGround = true;


    [Header("Otehr Objects")]
    public RectTransform ground;
    public RectTransform approach;
    public RectTransform conditions;
    public RectTransform quest;
    public RectTransform portaTirillasAmarillas;
    public RectTransform portaTirillasAzules;


    public GameObject gameManager;

    [Header("SingsAmarillas ")]
    public RectTransform T1;
    public RectTransform T2;
    public RectTransform T3;
    public RectTransform T4;
    public RectTransform T5;
    public RectTransform T6;

    [Header("singsBlues ")]
    public RectTransform T1B;
    public RectTransform T2B;
    public RectTransform T3B;
    public RectTransform T4B;
    public RectTransform T5B;
    public RectTransform T6B;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                    Resume();
                ground.DOAnchorPosY(-10.59998f, 0.1f).SetEase(Ease.InBounce);
                approach.DOAnchorPosY(-10.59998f, 0.1f).SetEase(Ease.InBounce);
                conditions.DOAnchorPosY(-10.59998f, 0.1f).SetEase(Ease.InBounce);
                quest.DOAnchorPosX(-766f, 0.1f).SetEase(Ease.InBounce);

                if(ImOnGround == true)
                {
                    gameManager.GetComponent<GameManager>().activarTirillasGround();
                    gameManager.GetComponent<GameManager>().activarProps();
                    activarSingsAmarillas();
                }
                else
                {
                    gameManager.GetComponent<GameManager>().airActive = true;
                    gameManager.GetComponent<GameManager>().activarTirillasAire();
                    //estas 2 lineas arribas son necesarias para activar tirrillas aire
                    gameManager.GetComponent<GameManager>().activarPortaTirillasAzules();
                    activarSingsAzules();

                }
                
              
            }
            else
            {


                if(ImOnGround == true)
                {
                    gameManager.GetComponent<GameManager>().desactivarPropsUI();
                    gameManager.GetComponent<GameManager>().desactivarTirillasGround();
                    desactivateSingsAmarillas();

                }
                else
                {
                    gameManager.GetComponent<GameManager>().airActive = false;
                    gameManager.GetComponent<GameManager>().desactivarTirillasAire();
                    //estas 2 lineas arribas son necesarias para desactivar tirrillas aire
                    gameManager.GetComponent<GameManager>().desactivarPortaTirrillasAzules();
                    desactivateSingsAzules();
                }

                

                // gameManager
                ground.DOAnchorPosY(16, 0.1f).SetEase(Ease.InBounce);
                approach.DOAnchorPosY(16, 0.1f).SetEase(Ease.InBounce);
                conditions.DOAnchorPosY(16, 0.1f).SetEase(Ease.InBounce);
                quest.DOAnchorPosX(-843f, 0.1f).SetEase(Ease.InBounce).OnComplete(() => {
                Pause();

                });

            }
       

        //pauseMenuFrame.DOScale(Vector3.one, 0.2f).SetEase(Ease.InBounce);
    }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        pauseMenuFrame.DOScale(Vector3.zero, 0.1f);
        pauseCanvas.SetActive(false);
        GameIsPaused = false;

    }

    public void Pause()
    {
        
        pauseMenuFrame.DOScale(Vector3.one, 0.1f).SetEase(Ease.InBounce).OnComplete(() =>
        {
            pauseCanvas.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;

        });
    }
    

    public void retry()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        pauseCanvas.SetActive(false);
        pauseMenuFrame.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBounce);
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void desactivateSingsAmarillas()
    {
        T1.DOAnchorPosX(459,0.1f).SetEase(Ease.InBounce);
        T2.DOAnchorPosX(459, 0.1f).SetEase(Ease.InBounce);
        T3.DOAnchorPosX(459, 0.1f).SetEase(Ease.InBounce);
        T4.DOAnchorPosX(459, 0.1f).SetEase(Ease.InBounce);
        T5.DOAnchorPosX(459, 0.1f).SetEase(Ease.InBounce);
        T6.DOAnchorPosX(459, 0.1f).SetEase(Ease.InBounce);
    }
    public void desactivateSingsAzules()
    {
        T1B.DOAnchorPosX(459, 0.1f).SetEase(Ease.InBounce);
        T2B.DOAnchorPosX(459, 0.1f).SetEase(Ease.InBounce);
        T3B.DOAnchorPosX(459, 0.1f).SetEase(Ease.InBounce);
        T4B.DOAnchorPosX(459, 0.1f).SetEase(Ease.InBounce);
        T5B.DOAnchorPosX(459, 0.1f).SetEase(Ease.InBounce);
        T6B.DOAnchorPosX(459, 0.1f).SetEase(Ease.InBounce);
    }

    public void activarSingsAmarillas()
    {
        T1.DOAnchorPosX(370.7864F, 0.1f).SetEase(Ease.InBounce);
        T2.DOAnchorPosX(370.7864F, 0.1f).SetEase(Ease.InBounce);
        T3.DOAnchorPosX(370.7864F, 0.1f).SetEase(Ease.InBounce);
        T4.DOAnchorPosX(370.7864F, 0.1f).SetEase(Ease.InBounce);
        T5.DOAnchorPosX(370.7864F, 0.1f).SetEase(Ease.InBounce);
        T6.DOAnchorPosX(370.7864F, 0.1f).SetEase(Ease.InBounce);
    }
    public void activarSingsAzules()
    {
        T1B.DOAnchorPosX(370.7864F, 0.1f).SetEase(Ease.InBounce);
        T2B.DOAnchorPosX(370.7864F, 0.1f).SetEase(Ease.InBounce);
        T3B.DOAnchorPosX(370.7864F, 0.1f).SetEase(Ease.InBounce);
        T4B.DOAnchorPosX(370.7864F, 0.1f).SetEase(Ease.InBounce);
        T5B.DOAnchorPosX(370.7864F, 0.1f).SetEase(Ease.InBounce);
        T6B.DOAnchorPosX(370.7864F, 0.1f).SetEase(Ease.InBounce);
    }

    public void toggle()
    {
        if (ImOnGround)
        {
            ImOnGround = false;
        }
        else
        {
            ImOnGround = true;
        }
    }

    public void SettingsFrameAnim()
    {
        SettingsMenuFrame.DOScale(Vector3.one, 0.2f).SetEase(Ease.InBounce);
    }

    public void HideSettingsFrame()
    {
        SettingsMenuFrame.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBounce);

    }

    public void continueButton()
    {
        if (GameIsPaused)
        {
            Resume();
            ground.DOAnchorPosY(-10.59998f, 0.1f).SetEase(Ease.InBounce);
            approach.DOAnchorPosY(-10.59998f, 0.1f).SetEase(Ease.InBounce);
            conditions.DOAnchorPosY(-10.59998f, 0.1f).SetEase(Ease.InBounce);
            quest.DOAnchorPosX(-766f, 0.1f).SetEase(Ease.InBounce);

            if (ImOnGround == true)
            {
                gameManager.GetComponent<GameManager>().activarTirillasGround();
                gameManager.GetComponent<GameManager>().activarProps();
                activarSingsAmarillas();
            }
            else
            {
                gameManager.GetComponent<GameManager>().airActive = true;
                gameManager.GetComponent<GameManager>().activarTirillasAire();
                //estas 2 lineas arribas son necesarias para activar tirrillas aire
                gameManager.GetComponent<GameManager>().activarPortaTirillasAzules();
                activarSingsAzules();

            }


        }
        else
        {


            if (ImOnGround == true)
            {
                gameManager.GetComponent<GameManager>().desactivarPropsUI();
                gameManager.GetComponent<GameManager>().desactivarTirillasGround();
                desactivateSingsAmarillas();

            }
            else
            {
                gameManager.GetComponent<GameManager>().airActive = false;
                gameManager.GetComponent<GameManager>().desactivarTirillasAire();
                //estas 2 lineas arribas son necesarias para desactivar tirrillas aire
                gameManager.GetComponent<GameManager>().desactivarPortaTirrillasAzules();
                desactivateSingsAzules();
            }



            // gameManager
            ground.DOAnchorPosY(16, 0.1f).SetEase(Ease.InBounce);
            approach.DOAnchorPosY(16, 0.1f).SetEase(Ease.InBounce);
            conditions.DOAnchorPosY(16, 0.1f).SetEase(Ease.InBounce);
            quest.DOAnchorPosX(-843f, 0.1f).SetEase(Ease.InBounce).OnComplete(() => {
                Pause();

            });

        }


        //pauseMenuFrame.DOScale(Vector3.one, 0.2f).SetEase(Ease.InBounce);
    }
}

