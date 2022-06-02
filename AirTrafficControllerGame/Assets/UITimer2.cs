using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class UITimer2 : MonoBehaviour
{
    public TextMeshProUGUI text;
    float theTime;
    public float speed = 1;
    bool playing = true;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (playing == true)
        {
            theTime += Time.deltaTime * speed;
            string hours = Mathf.Floor((theTime % 216000) / 3600).ToString("00");
            string minutes = Mathf.Floor((theTime % 3600) / 60).ToString("00");
            string seconds = (theTime % 60).ToString("00");
            text.text = hours + ":" + minutes + ":" + seconds;
        }
    }

    public void ClickPlay()
    {
        playing = true;
    }

    public void ClickStop()
    {
        playing = false;
    }
}
