using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Threading.Tasks;

public class levelClearSystem : MonoBehaviour
{
    [SerializeField] private Transform mainFrameGO;
    [SerializeField] private Transform[] stars;
    public bool levelClear;
    public bool Objective1;
    public bool Objective2;
    public bool Objective3;

    private void Start()
    {
            if (Objective1 == true)
            {
            mainFrameGO.DOScale(Vector3.one, 0.7f).SetEase(Ease.InCubic).OnComplete(() => {

                stars[0].DOScale(Vector3.one, 0.2f).SetEase(Ease.InBounce);
            });
        }         
        

        if (Objective1 == true && Objective2 == true)
        {
            mainFrameGO.DOScale(Vector3.one, 0.7f).SetEase(Ease.InCubic).OnComplete(() => {
                stars[0].DOScale(Vector3.one, 0.2f).SetEase(Ease.InBounce).OnComplete(() => {
                stars[1].DOScale(Vector3.one, 0.2f).SetEase(Ease.InBounce);
                
            });
            });
        }

        if (Objective1 == true && Objective2 == true && Objective3 == true)
        {
            mainFrameGO.DOScale(Vector3.one, 0.7f).SetEase(Ease.InCubic).OnComplete(() => {
                stars[0].DOScale(Vector3.one, 0.2f).SetEase(Ease.InBounce).OnComplete(() => {
                stars[1].DOScale(Vector3.one, 0.2f).SetEase(Ease.InBounce).OnComplete(() => {
                    stars[2].DOScale(Vector3.one, 0.2f).SetEase(Ease.InBounce);
                });
            });
            });

        }


    }

    }
