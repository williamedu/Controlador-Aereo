using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;


public class mainMenuAudioManager : MonoBehaviour
{
    public Sounds[] sounds;
    public Sounds[] VFXsounds;
    public Sounds[] backGround_MusicSounds;
    public AudioSource[] fuentes;  
    public AudioMixerGroup voices;
    public AudioMixerGroup SFX;
    public AudioMixerGroup backGround_Music;


    private void Awake()
    {


        foreach (Sounds s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.Clip;
            s.source.volume = s.Volume;
            s.source.pitch = s.Pitch;
            s.source.outputAudioMixerGroup = voices;
        }

        foreach (Sounds s in VFXsounds)
        {

            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.Clip;

            s.source.volume = s.Volume;
            s.source.pitch = s.Pitch;
            s.source.outputAudioMixerGroup = voices;
            s.source.ignoreListenerPause = true;
            s.source.outputAudioMixerGroup = SFX;

        }

        foreach (Sounds s in backGround_MusicSounds)
        {

            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.Clip;

            s.source.volume = s.Volume;
            s.source.pitch = s.Pitch;
            s.source.outputAudioMixerGroup = backGround_Music;
            s.source.outputAudioMixerGroup = backGround_Music;
            s.source.loop = true;

        }

    }
    // lista de sonidos a utilizar en el main menu



    public void Play(string name)
    {
        Sounds s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();

    }
    public void PlayVFX(string name)
    {
        Sounds s = Array.Find(VFXsounds, sound => sound.name == name);
        s.source.Play();
    }

    public void PlayMusicBackGround(string name)
    {
        Sounds s = Array.Find(backGround_MusicSounds, sound => sound.name == name);
        s.source.Play();
    }

    
}
