using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCmovement : MonoBehaviour
{

    public MenuManager menuManager;
    public Animator anim;


    bool npc1 = true;
    bool npc3 = true;

    public Transform ReturnNPC1;
    public Transform ReturnNPC2;
    public Transform CrossPosition;

    public float animStarDelay;
    public int cross;
    public int crossDesicion = 0;
    bool tryingToCross = false;
    bool rotation = false;
    bool rotation90 = false;
    bool activateAferCross = false;
    
    public bool rotation270 = false;
    [HideInInspector]
    public bool rotation0 = false;
    [HideInInspector]
    public bool rotation00 = false;
    public Vector3 rotationNPC;
    public Vector3 rotationNPC2;
     public bool NPCright = false;

    // Start is called before the first frame update
    private void Awake()
    {
        
        if (gameObject.CompareTag("NPC1")) { NPCright = true; }
        bakeNumber();
    }
    void Start()
    {
        crossDesicion = Random.Range(1, 3);
        ReturnNPC1 = GameObject.Find("NPC1R1").transform;
        ReturnNPC2 = GameObject.Find("NPC2R1").transform;
        CrossPosition = GameObject.Find("Charactercross").transform;
        anim = gameObject.GetComponent<Animator>();
        menuManager = GameObject.FindGameObjectWithTag("MenuManager").GetComponent<MenuManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (tryingToCross == true)
        {
            if (menuManager.canCross == true)
            {
                anim.SetTrigger("Run");
                tryingToCross = false;
            }
        }


       if (gameObject.CompareTag("NPC1") || gameObject.CompareTag("NPC2") && npc1 == true)
        {
            Invoke("NPC1", animStarDelay);
            npc1 = false;
        }



        if (gameObject.CompareTag("NPC3") && npc3 == true)
        {
            NPC2();
            npc3 = false;
        }

        if (rotation == true)
        {
            transform.Rotate(rotationNPC * Time.deltaTime);
            if (gameObject.transform.rotation.eulerAngles.y >= 180)
            {
                rotation = false;
            }
        }


        if (rotation == true)
        {
            transform.Rotate(rotationNPC * Time.deltaTime);
            if (gameObject.transform.rotation.eulerAngles.y >= 180)
            {
                rotation = false;
            }
        }
        if (rotation90 == true)
        {
            transform.Rotate(rotationNPC2 * Time.deltaTime);
            if (gameObject.transform.rotation.eulerAngles.y <= 90)
            {
                rotation90 = false;
            }
        }

        if (rotation270 == true)
        {
            transform.Rotate(rotationNPC2 * Time.deltaTime);
            if (gameObject.transform.rotation.eulerAngles.y <= 270)
            {
                rotation270 = false;
                print(gameObject.name + "termino de rotar");
            }
        }

        if (rotation0 == true)
        {
            transform.Rotate(rotationNPC2 * Time.deltaTime);
            if (gameObject.transform.rotation.eulerAngles.y <= 259)
            {
                rotation0 = false;
                print(gameObject.name + "termino de rotar");
                
            }
        }

        if (rotation00 == true)
        {
            transform.Rotate(rotationNPC * Time.deltaTime);
            if (gameObject.transform.rotation.eulerAngles.y >= 259)
            {
                rotation00 = false;
                print("termino de rotar");
            }
        }
        if (activateAferCross == true)
        {
            aftercross();
            activateAferCross = false;
        }

    }

    void bakeNumber( )
    {
        animStarDelay = Random.Range(1, 3);
        
    }


    void NPC1()
    {
        print("se activo");
        anim.SetTrigger("Walk");
        CancelInvoke();
    }

    void NPC2()
    {
        anim.SetTrigger("Cool");
        CancelInvoke();
    }

    void crossing()
    {
        anim.SetTrigger("Run");
    }

  public  void aftercross()
    {
        rotation00 = true;
        print("se invoco el aftercvross");
        menuManager.NPC12.GetComponent<NPCmovement>().rotation270 = true;
        CancelInvoke();
    }

    void reramdonCrossDesicion()
    {
        crossDesicion = Random.Range(1, 3);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Desicion") && gameObject.CompareTag("NPC1"))
        {
            gameObject.transform.position = ReturnNPC1.transform.position;
            if (cross == 1)
            {
                reramdonCrossDesicion();
            }
            
        }

        if (other.gameObject.CompareTag("Gates") && gameObject.CompareTag("NPC2"))
        {
            gameObject.transform.position = ReturnNPC2.transform.position;

            if (cross == 1)
            {
                reramdonCrossDesicion();
            }
           
        }

        if (other.gameObject.CompareTag("West") && cross == 1 && crossDesicion ==2 )
        {
            anim.SetTrigger("Idle");
            rotation = true;
            print(transform.rotation.eulerAngles);
            Destroy(other.gameObject);
            tryingToCross = true;
        }

        if (other.gameObject.CompareTag("Stop"))
            
        {
            menuManager.NPC12.GetComponent<NPCmovement>().rotation270 = true; 
            anim.SetTrigger("Idle");
            rotation90 = true;
            
           

        }

        


    }








}
