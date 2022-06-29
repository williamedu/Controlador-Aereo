using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class levelController : MonoBehaviour
{
    public GameObject[] OutLine; // para el outline cuando se selecciona
    public GameObject[] missionText; // para los mission descriptions
    public GameObject[] startButtons; // para los starts buttons de cada nivel
    public GameObject[] levelDificulty; // para los distinis niveles de dificultad de los niveles
    public GameObject[] levelsImages; // imagenes que apareceran en el frame del nivel


    public void changeLevelProps()
    {
        selectOutLine();
        selectMissionText();
        selectStartButton();
        selectLevelDificulty();
        selectImage();
    }
    public void selectOutLine()
    {
        foreach ( GameObject s in OutLine)
        {
            s.SetActive(false);
        }

    }

    public void selectMissionText()
    {
        foreach (GameObject s in missionText)
        {
            s.SetActive(false);
        }

    }

    public void selectStartButton()
    {
        foreach (GameObject s in startButtons)
        {
            s.SetActive(false);
        }

    }

    public void selectLevelDificulty()
    {
        foreach (GameObject s in levelDificulty)
        {
            s.SetActive(false);
        }

    }

    public void selectImage()
    {
        foreach (GameObject s in levelsImages)
        {
            s.SetActive(false);
        }

    }

}
