using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static bool playing = false;
    public Sounds[] sounds;
    public Sounds[] VFXsounds;
    public Sounds[] backGround_MusicSounds;
    public AudioSource[] fuentes;
    public static float cliplength = 0;
    public bool availableToTalk = false;
    bool bigDomie = false;
    public float wait1 = 0;
    public float wait2 = 0;
    public float wait3 = 0;
    public bool hablando = false;
    public AudioSource currentClip;
    public float Queue = 0;
    public AudioMixerGroup voices;
    public AudioMixerGroup SFX;
    public AudioMixerGroup backGround_Music;



    private void Awake()
    {
        availableToTalk = true;


        foreach (Sounds s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.Clip;

            s.source.volume = s.Volume;
            s.source.pitch = s.Pitch;
            if (s.source.isPlaying) { playing = true; }
            if (!s.source.isPlaying) { playing = false; }
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


    // Start is called before the first frame update
    void Start()
    {
        PlayMusicBackGround("mainTheme");

      //  fuentes = GameObject.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

    }

    private void Update()
    {
        /*
        if (pauseMenu.GameIsPaused == true)
        {
            
                AudioListener.pause = true;
            
        }
        else
        {
            AudioListener.pause = false;

        }
        */

        //if (hablando == true) { InvokeRepeating("normalize", , 3); }

        for (int i = 0; i < sounds.Length; i++)
        {
            // fuentes.Length;
            // currentClip = fuentes[i];

            currentClip = sounds[i].source;
            if (currentClip.isPlaying == true) { hablando = true; }
            if (!sounds[0].source.isPlaying && !sounds[1].source.isPlaying && !sounds[2].source.isPlaying && !sounds[3].source.isPlaying &&
                !sounds[4].source.isPlaying && !sounds[5].source.isPlaying && !sounds[6].source.isPlaying && !sounds[7].source.isPlaying &&
                !sounds[8].source.isPlaying && !sounds[9].source.isPlaying && !sounds[10].source.isPlaying && !sounds[11].source.isPlaying &&
                !sounds[12].source.isPlaying && !sounds[13].source.isPlaying && !sounds[14].source.isPlaying && !sounds[15].source.isPlaying &&
                !sounds[16].source.isPlaying && !sounds[17].source.isPlaying && !sounds[18].source.isPlaying && !sounds[19].source.isPlaying &&
                !sounds[20].source.isPlaying && !sounds[21].source.isPlaying && !sounds[22].source.isPlaying && !sounds[23].source.isPlaying &&
                !sounds[24].source.isPlaying && !sounds[25].source.isPlaying && !sounds[26].source.isPlaying && !sounds[27].source.isPlaying &&
                !sounds[28].source.isPlaying && !sounds[29].source.isPlaying && !sounds[30].source.isPlaying && !sounds[31].source.isPlaying && 
                !sounds[32].source.isPlaying && !sounds[33].source.isPlaying && !sounds[34].source.isPlaying && !sounds[35].source.isPlaying &&
                !sounds[36].source.isPlaying && !sounds[37].source.isPlaying && !sounds[38].source.isPlaying && !sounds[39].source.isPlaying &&
                !sounds[40].source.isPlaying && !sounds[41].source.isPlaying && !sounds[42].source.isPlaying && !sounds[43].source.isPlaying &&
                !sounds[44].source.isPlaying && !sounds[45].source.isPlaying && !sounds[46].source.isPlaying && !sounds[47].source.isPlaying &&
                !sounds[48].source.isPlaying && !sounds[49].source.isPlaying && !sounds[50].source.isPlaying && !sounds[51].source.isPlaying &&
                !sounds[52].source.isPlaying && !sounds[53].source.isPlaying && !sounds[54].source.isPlaying && !sounds[55].source.isPlaying &&
                !sounds[56].source.isPlaying && !sounds[57].source.isPlaying && !sounds[58].source.isPlaying && !sounds[59].source.isPlaying
                && !sounds[60].source.isPlaying && !sounds[61].source.isPlaying && !sounds[62].source.isPlaying ) {  hablando = false; }
            //  if (!fuentes[0].isPlaying && !fuentes[1].isPlaying && !fuentes[2].isPlaying && !fuentes[3].isPlaying && !fuentes[4].isPlaying &&
            //   !fuentes[5].isPlaying && !fuentes[6].isPlaying && !fuentes[7].isPlaying && !fuentes[8].isPlaying && !fuentes[9].isPlaying &&
            // !fuentes[10].isPlaying && !fuentes[11].isPlaying && !fuentes[12].isPlaying && !fuentes[13].isPlaying && !fuentes[14].isPlaying
            //    && !fuentes[15].isPlaying && !fuentes[16].isPlaying && !fuentes[17].isPlaying && !fuentes[18].isPlaying && !fuentes[19].isPlaying
            //     && !fuentes[20].isPlaying && !fuentes[21].isPlaying && !fuentes[22].isPlaying && !fuentes[23].isPlaying && !fuentes[24].isPlaying
            //     && !fuentes[25].isPlaying && !fuentes[26].isPlaying && !fuentes[27].isPlaying && !fuentes[28].isPlaying && !fuentes[29].isPlaying
            //     && !fuentes[30].isPlaying && !fuentes[31].isPlaying && !fuentes[32].isPlaying && !fuentes[33].isPlaying && !fuentes[34].isPlaying
            //    && !fuentes[35].isPlaying && !fuentes[36].isPlaying && !fuentes[37].isPlaying && !fuentes[38].isPlaying && !fuentes[39].isPlaying
            //    && !fuentes[40].isPlaying && !fuentes[41].isPlaying && !fuentes[42].isPlaying && !fuentes[43].isPlaying && !fuentes[44].isPlaying
            //     && !fuentes[45].isPlaying && !fuentes[46].isPlaying && !fuentes[47].isPlaying && !fuentes[48].isPlaying && !fuentes[49].isPlaying
            //     && !fuentes[50].isPlaying && !fuentes[51].isPlaying && !fuentes[52].isPlaying && !fuentes[53].isPlaying && !fuentes[54].isPlaying
            //     && !fuentes[55].isPlaying && !fuentes[56].isPlaying && !fuentes[57].isPlaying && !fuentes[58].isPlaying && !fuentes[59].isPlaying
            //    && !fuentes[60].isPlaying && !fuentes[61].isPlaying && !fuentes[62].isPlaying) { hablando = false; }


            // if (currentClip.isPlaying) { availableToTalk = false;  }


            // if (fuentes[i].isPlaying && wait1 == 0) { wait1 = fuentes[i].clip.length;     }
            //  if (fuentes[i].isPlaying && wait1 > 1) { wait1 = fuentes[i].clip.length ; }

        }

        // if (fuentes[0].isPlaying) { cliplength = fuentes[0].clip.length + cons;  print(fuentes[0].clip.name);     }
        // if (fuentes[1].isPlaying) { cliplength = fuentes[1].clip.length + cons;  print(fuentes[1].clip.name);    }
        // if (fuentes[2].isPlaying) { cliplength = fuentes[2].clip.length + cons;  print(fuentes[2].clip.name);    }
        // if (fuentes[3].isPlaying) { cliplength = fuentes[3].clip.length + cons;  print(fuentes[3].clip.name);    }
        // if (fuentes[4].isPlaying) { cliplength = fuentes[4].clip.length + cons;  print(fuentes[4].clip.name);    }
        // if (fuentes[5].isPlaying) { cliplength = fuentes[5].clip.length + cons;  print(fuentes[5].clip.name);    } 
        // if (fuentes[6].isPlaying) { cliplength = fuentes[6].clip.length + cons;  print(fuentes[6].clip.name);    }
        // if (fuentes[7].isPlaying) { cliplength = fuentes[7].clip.length + cons;  print(fuentes[7].clip.name);    }
        // if (fuentes[8].isPlaying) { cliplength = fuentes[8].clip.length + cons;  print(fuentes[8].clip.name);    }
        //if (fuentes[9].isPlaying) { cliplength = fuentes[9].clip.length + cons;  print(fuentes[9].clip.name);     }
        /// if (fuentes[10].isPlaying) { cliplength = fuentes[10].clip.length + cons; print(fuentes[10].clip.name);  }

        // foreach (var source in fuentes)
        //{
        //if (source.isPlaying) { print("se esta reproduciendo un audio ");
        // }






    }

    public void normalize()
    {
        hablando = false;
        CancelInvoke();
    }

    public void desactivarSonido()
    {
        AudioListener.pause = true;

        // para desactivar sonido antes que el frame salga en winlevel
    }

    public void ActivarSonido()
    {
        AudioListener.pause = false;

    }
}
