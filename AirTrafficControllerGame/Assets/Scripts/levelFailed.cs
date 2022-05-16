using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using DG.Tweening;


public class levelFailed : MonoBehaviour
{
    [SerializeField] private Transform mainFrameGO;
    [SerializeField] private GameObject GameManager;
    public bool seActivoGameOver;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.GetComponent<GameManager>().gameOver == true && seActivoGameOver ==false)
        {
            gameOver();
        }
    }

    public void gameOver()
    {
        mainFrameGO.DOScale(Vector3.one, 0.7f).SetEase(Ease.InCubic);
        seActivoGameOver = true;


    }

}
