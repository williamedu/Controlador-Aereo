using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class blink : MonoBehaviour { 
// this is the UI.Text or other UI element you want to toggle
     public MaskableGraphic imageToToggle;

public float interval = 1f;
public float startDelay = 0.5f;
public bool currentState = true;
public bool defaultState = true;
public bool isBlinking = false;

public AudioClip clip;

void Start()
{
    imageToToggle.enabled = defaultState;
    StartBlink();
}

public void StartBlink()
{
    // do not invoke the blink twice - needed if you need to start the blink from an external object
    if (isBlinking)
        return;

    if (imageToToggle != null)
    {
        isBlinking = true;
        InvokeRepeating("ToggleState", startDelay, interval);
    }
}

public void ToggleState()
{
    imageToToggle.enabled = !imageToToggle.enabled;

    // plays the clip at (0,0,0)
    if (clip)
        AudioSource.PlayClipAtPoint(clip, Vector3.zero);
}
     
 }