using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelSelector : MonoBehaviour
{

    public SceneFader fader;
    public buttonAnim buttonAnim;
    public Button[] levelButtons;

    private void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)

                levelButtons[i].interactable = false;
            levelButtons[i].GetComponent<buttonAnim>().Lock.SetActive(true);
            //levelButtons[i].GetComponent<buttonAnim>().canHover = false;

          

        }

      
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 <= levelReached)

                levelButtons[i].GetComponent<buttonAnim>().Lock.SetActive(false);
                levelButtons[i].GetComponent<buttonAnim>().canHover = true;


        }
      
    }
    public void Select (string levelName)
    {
        fader.FadeTo(levelName);
    }
}
