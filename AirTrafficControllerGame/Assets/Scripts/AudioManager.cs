using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static bool playing = false;
    public Sounds[] sounds;
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
        }


    }


    public void Play(string name)
    {
        Sounds s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
        
    }


    // Start is called before the first frame update
    void Start()
    {
        
       fuentes = GameObject.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

    }

    private void Update()
    {

       
        //if (hablando == true) { InvokeRepeating("normalize", , 3); }

        for (int i = 0; i < fuentes.Length; i++)
        {
            currentClip = fuentes[i];
           if ( currentClip.isPlaying == true) { hablando = true; }

           if (!fuentes[0].isPlaying && !fuentes[1].isPlaying && !fuentes[2].isPlaying && !fuentes[3].isPlaying && !fuentes[4].isPlaying &&
                !fuentes[5].isPlaying && !fuentes[6].isPlaying && !fuentes[7].isPlaying && !fuentes[8].isPlaying && !fuentes[9].isPlaying &&
                !fuentes[10].isPlaying && !fuentes[11].isPlaying && !fuentes[12].isPlaying && !fuentes[13].isPlaying && !fuentes[14].isPlaying
                && !fuentes[15].isPlaying && !fuentes[16].isPlaying && !fuentes[17].isPlaying && !fuentes[18].isPlaying && !fuentes[19].isPlaying
                && !fuentes[20].isPlaying && !fuentes[21].isPlaying && !fuentes[22].isPlaying && !fuentes[23].isPlaying && !fuentes[24].isPlaying
                && !fuentes[25].isPlaying && !fuentes[26].isPlaying && !fuentes[27].isPlaying && !fuentes[28].isPlaying && !fuentes[29].isPlaying
                && !fuentes[30].isPlaying && !fuentes[31].isPlaying && !fuentes[32].isPlaying && !fuentes[33].isPlaying && !fuentes[34].isPlaying
                && !fuentes[35].isPlaying && !fuentes[36].isPlaying && !fuentes[37].isPlaying && !fuentes[38].isPlaying && !fuentes[39].isPlaying
                && !fuentes[40].isPlaying && !fuentes[41].isPlaying && !fuentes[42].isPlaying && !fuentes[43].isPlaying && !fuentes[44].isPlaying
                && !fuentes[45].isPlaying && !fuentes[46].isPlaying && !fuentes[47].isPlaying && !fuentes[48].isPlaying && !fuentes[49].isPlaying
                && !fuentes[50].isPlaying && !fuentes[51].isPlaying && !fuentes[52].isPlaying && !fuentes[53].isPlaying && !fuentes[54].isPlaying
                && !fuentes[55].isPlaying && !fuentes[56].isPlaying && !fuentes[57].isPlaying && !fuentes[58].isPlaying && !fuentes[59].isPlaying
                && !fuentes[60].isPlaying && !fuentes[61].isPlaying && !fuentes[62].isPlaying) { hablando = false; }
            
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
}
