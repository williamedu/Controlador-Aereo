using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Threading.Tasks;

public class levelClearSystem : MonoBehaviour
{
    [SerializeField] private Transform mainFrameGO;
    [SerializeField] private GameObject GameManager;
    [SerializeField] private GameObject questFrameAnim;
    [SerializeField] private GameObject numerOfTakeOff;
    [SerializeField] private Transform[] stars;

    public bool levelClear;
    public bool Objective1;
    public bool Objective2;
    public bool Objective3;
    public bool seActivoLevelComplete;
    public int QuestCounter;

    private void Start()
    {
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
                levelClear = true;
                levelComplete();
            }
        }
             
    }


public void levelComplete()
    {
        if (QuestCounter == 1 && levelClear == true && seActivoLevelComplete == false)
        {
            print("estrella1");
            seActivoLevelComplete = true;

            mainFrameGO.DOScale(Vector3.one, 0.2f).SetEase(Ease.InCubic).OnComplete(() => {

                stars[0].DOScale(Vector3.one, 0.4f).SetEase(Ease.InBounce).OnComplete(() => {
                    
            });
        });
        }


        if (QuestCounter == 2 && levelClear == true && seActivoLevelComplete == false)
        {
            print("estrella2");
            seActivoLevelComplete = true;

            mainFrameGO.DOScale(Vector3.one, 0.2f).SetEase(Ease.InCubic).OnComplete(() => {
                stars[0].DOScale(Vector3.one, 0.4f).SetEase(Ease.InBounce).OnComplete(() => {
                    stars[1].DOScale(Vector3.one, 0.4f).SetEase(Ease.InBounce);

                });
            });
        }

        if (QuestCounter == 3 && levelClear == true && seActivoLevelComplete == false)
        {
            print("estrella3");
            seActivoLevelComplete = true;

            mainFrameGO.DOScale(Vector3.one, 0.2f).SetEase(Ease.InCubic).OnComplete(() => {
                stars[0].DOScale(Vector3.one, 0.4f).SetEase(Ease.InBounce).OnComplete(() => {
                    stars[1].DOScale(Vector3.one, 0.4f).SetEase(Ease.InBounce).OnComplete(() => {
                        stars[2].DOScale(Vector3.one, 0.4f).SetEase(Ease.OutElastic);
                    });
                });
            });

        }

    }

}
