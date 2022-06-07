using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;


public class MainObjetive : MonoBehaviour
{

    public levelClearSystem levelClear; // para hacer referencia al scrip level clear donde se activaran los objetives
    public TextMeshProUGUI objectivesNumber; // para referencial el texto que se va a cambiar
    public TextMeshProUGUI winCondition; // muestra el mensaje de la mision principal
    public AudioManager audioManager; // referencia audio manager para los sonidos


    private string oneOfThree = "1/3";
    private string twoOfThree = "2/3";
    private string threeOfThree = "3/3";

    public bool objetiveOne;
    public bool objetiveTwo;
    public bool objetiveThree;


    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();

    }

    void Update()
    {
        if (levelClear.QuestCounter == 1 && objetiveOne == false)
        {
            //objectivesNumber.DOText("1/2", 2, true, ScrambleMode.All).SetEase(Ease.Linear);
            objetiveOne = true;
            audioManager.PlayVFX("ObjectiveDone");
            objectivesNumber.text = oneOfThree;


        }

        if (levelClear.QuestCounter == 2 && objetiveTwo == false)
        {
            objetiveTwo = true;
            audioManager.PlayVFX("ObjectiveDone");
            objectivesNumber.text = twoOfThree;

        }

        if (levelClear.QuestCounter == 3 && objetiveThree == false)
        {
            objetiveThree = true;
            audioManager.PlayVFX("ObjectiveDone");
            objectivesNumber.text = threeOfThree;

        }
    }

   
}
