using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
     GameManager GM;
    levelClearSystem LCS;
    DeltaChecker DeltaCounter;
    TakeOffChecker takeoffcounter;
    BravoChecker bravoCounter;

    public bool Objetive1 = true;
   public bool Objetive2 = true;
    public bool Objetive3 = true;













    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        LCS = GameObject.FindGameObjectWithTag("LCS").GetComponent<levelClearSystem>();
        DeltaCounter = GameObject.FindGameObjectWithTag("DC").GetComponent<DeltaChecker>();
        takeoffcounter = GameObject.FindGameObjectWithTag("TOC").GetComponent<TakeOffChecker>();
        bravoCounter = GameObject.FindGameObjectWithTag("BC").GetComponent<BravoChecker>();

    }

    // Update is called once per frame
    void Update()
    {
       if (GM.level == 1) 
        {
            print("estamos en el level 1");
            if (DeltaChecker.DeltaCounter == 2 && Objetive1 == true) { LCS.Objective1 = true; Objetive1 = false; }
            if (DeltaChecker.CharlieCounter == 1 && Objetive2 == true) { print("objetivo 2 completo"); LCS.Objective2 = true; Objetive2 = false; }
            if (bravoCounter.BravoCounter == 1 && Objetive3 == true) { LCS.Objective3 = true; Objetive3 = false; }
        } 
    }

    void Objetive1Complete()
    {

    }

    void Objetive2Complete()
    {

    }

    void Objetive3Complete()
    {

    }







}
