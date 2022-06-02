using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Threading.Tasks;

public class levelClearSystem : MonoBehaviour
{
    AudioManager audioManager;
    [SerializeField] private Transform mainFrameGO;
    [SerializeField] private GameObject GameManager;
    [SerializeField] private GameObject questFrameAnim;
    [SerializeField] private GameObject numerOfTakeOff;
    [SerializeField] private Transform[] stars;
    public GameObject ParticleStart1;
    public GameObject ParticleStart2;
    public GameObject ParticleStart3;
    public GameObject confetti1;
    public GameObject confetti2;

    public GameObject pauseMenu;

    bool ActivatePart1 = true;
    bool ActivatePart2 = true;
    bool ActivatePart3 = true;

    public bool levelClear;
    public bool Objective1;
    public bool Objective2;
    public bool Objective3;
    public bool seActivoLevelComplete;
    public int QuestCounter;

    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        GameManager = GameObject.FindGameObjectWithTag("GM").gameObject;
        numerOfTakeOff = GameObject.FindGameObjectWithTag("TOC").gameObject;

       
    }

    


    private void Update()
    {
        if (Objective1 == true) { int i = 1; QuestCounter = QuestCounter + i; questFrameAnim.GetComponent<QuestFrameAnim>().completion1.SetActive(true); Objective1 = false; }
        if (Objective2 == true) { int i = 1; QuestCounter = QuestCounter + i; questFrameAnim.GetComponent<QuestFrameAnim>().completion2.SetActive(true); Objective2 = false; }
        if (Objective3 == true) { int i = 1; QuestCounter = QuestCounter + i; questFrameAnim.GetComponent<QuestFrameAnim>().completion3.SetActive(true); Objective3 = false; }

        if (GameManager.GetComponent<GameManager>().level == 1)
        {
           

            if (numerOfTakeOff.GetComponent<TakeOffChecker>().takeoffCounter == 3)
            {
                GameManager.GetComponent<GameManager>().activarBackFrame();
                GameManager.GetComponent<GameManager>().winLevel(); // para el playerPrebs
                levelClear = true;
                levelComplete();
            }
        }
             
    }


public void levelComplete()
    {
        if (QuestCounter == 1 && levelClear == true && seActivoLevelComplete == false)
        {
            GameManager.GetComponent<GameManager>().desactivarTamarillasTAzulesPamarillasPAzules();
            audioManager.GetComponent<AudioManager>().desactivarSonido();
            pauseMenu.GetComponent<pauseMenu>().activarBackFrame();
            pauseMenu.GetComponent<pauseMenu>().removeButtonsOffScreem();
            seActivoLevelComplete = true;

            mainFrameGO.DOScale(Vector3.one, 0.2f).SetEase(Ease.InCubic).OnComplete(() => {

                particle1();
                stars[0].DOScale(Vector3.one, 0.4f).SetEase(Ease.InBounce).OnComplete(() => {
                    pauseMenu.GetComponent<pauseMenu>().winLevel();

            
        });
            });
        }


        if (QuestCounter == 2 && levelClear == true && seActivoLevelComplete == false)
        {
            GameManager.GetComponent<GameManager>().desactivarTamarillasTAzulesPamarillasPAzules();
            audioManager.GetComponent<AudioManager>().desactivarSonido();
            pauseMenu.GetComponent<pauseMenu>().activarBackFrame();
            pauseMenu.GetComponent<pauseMenu>().removeButtonsOffScreem();
            seActivoLevelComplete = true;

            mainFrameGO.DOScale(Vector3.one, 0.2f).SetEase(Ease.InCubic).OnComplete(() => {
                particle1();
                stars[0].DOScale(Vector3.one, 0.4f).SetEase(Ease.InBounce).OnComplete(() => {
                    particle2();
                    stars[1].DOScale(Vector3.one, 0.6f).SetEase(Ease.InBounce).OnComplete(() => {
                        pauseMenu.GetComponent<pauseMenu>().winLevel();



                    });
            });
     });
        }

        if (QuestCounter == 3 && levelClear == true && seActivoLevelComplete == false)
        {
            GameManager.GetComponent<GameManager>().desactivarTamarillasTAzulesPamarillasPAzules();
            audioManager.GetComponent<AudioManager>().desactivarSonido();
            pauseMenu.GetComponent<pauseMenu>().activarBackFrame();
            pauseMenu.GetComponent<pauseMenu>().removeButtonsOffScreem();
            seActivoLevelComplete = true;

            mainFrameGO.DOScale(Vector3.one, 0.2f).SetEase(Ease.InCubic).OnComplete(() => {
                particle1();
                stars[0].DOScale(Vector3.one, 0.4f).SetEase(Ease.InBounce).OnComplete(() => {
                    particle2();
                    stars[1].DOScale(Vector3.one, 0.4f).SetEase(Ease.InBounce).OnComplete(() => {
                        particle3();
                        
                        stars[2].DOScale(Vector3.one, 0.4f).SetEase(Ease.OutElastic).OnComplete(() => {
                            pauseMenu.GetComponent<pauseMenu>().winLevel();

                            
                        });
                });
            });
         });
        }

    }


    public void particle1()
    {
        ParticleStart1.SetActive(true);
        audioManager.PlayVFX("Start1");

    }

    public void particle2()
    {
        ParticleStart2.SetActive(true);
        audioManager.PlayVFX("Start2");
    }

    public void particle3()
    {
        ParticleStart3.SetActive(true);
        audioManager.PlayVFX("Start3");
        confetti1.SetActive(true);
        confetti2.SetActive(true);
    }

    public void paraPruebaPasarNivelObjetivo()
    {
        Objective1 = true;
    }

}
