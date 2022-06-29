using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class loadingScene : MonoBehaviour
{
    public GameObject LoadingScreem;
    public Image LoadingBarFill;
    public TextMeshProUGUI loadingPercentage;


    public void loadScene(int sceneId)
    {
        StartCoroutine(LoadSceneAsync(sceneId));
    }


    IEnumerator LoadSceneAsync(int sceneId)
    {
        LoadingScreem.SetActive(true);

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);

        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);

            LoadingBarFill.fillAmount = progressValue;
            loadingPercentage.text = "Loading..." + progressValue * 100f + "%";
            //slider.value = progressValue;

            yield return null;
        }
    }
}
