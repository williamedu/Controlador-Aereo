using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badgesController : MonoBehaviour
{
    public GameObject[] badgesOutLine; // para el outline cuando se selecciona
    public GameObject[] badgesText; // para los mission descriptions
    public GameObject[] badgeDificulty; // para los distinis niveles de dificultad de los niveles
    public GameObject[] badgesImages; // imagenes que apareceran en el frame del nivel


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OutLineBadges()
    {
        foreach (GameObject s in badgesOutLine)
        {
            s.SetActive(false);
        }

    }

    public void BadgesTextDescription()
    {
        foreach (GameObject s in badgesText)
        {
            s.SetActive(false);
        }

    }
}
