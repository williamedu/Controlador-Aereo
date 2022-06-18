using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCmovement : MonoBehaviour
{
    public float speed = 10;
    public MenuManager menuManager;
    public Animator anim;
  public  Transform goal1;
  public  Transform goal2;
    bool go = true;
    public Transform characterPosition;
    bool npc1 = true;
    bool npc3 = true;
   public bool lookat = false;
    public Transform ReturnNPC1;
    public Transform ReturnNPC2;
    public Transform CrossPosition;
   public Transform North;
    public float animStarDelay;
    public int sitiation1;
    public int sitiation2;
    public int crossDesicion = 0;
 public   bool tryingToCross = false;
  public  bool rotation = false;
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
    bool canDestroy = false;

    // Start is called before the first frame update
    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        speed = 1.8f;
        if (gameObject.CompareTag("NPC1") || gameObject.CompareTag("NPC2")) { NPC1();   }
        bakeNumber();
    }
    void Start()
    {
        North = GameObject.Find("north1").transform;
        goal1 = GameObject.Find("goal1").transform;
        goal2 = GameObject.Find("goal2").transform;
        crossDesicion = Random.Range(1, 3);
        ReturnNPC1 = GameObject.Find("NPC1R1").transform;
        ReturnNPC2 = GameObject.Find("NPC2R1").transform;
        CrossPosition = GameObject.Find("Charactercross").transform;
        
        menuManager = GameObject.FindGameObjectWithTag("MenuManager").GetComponent<MenuManager>();
    }

    // Update is called once per frame
    void lateUpdate()
    {

        if (lookat == true)
        {
            transform.LookAt(characterPosition.position  );
            lookat = false;
        }

        if (tryingToCross == true)
        {
            anim.SetTrigger("Run");
            if (menuManager.canCross == true)
            {
                anim.SetTrigger("Run");
                print("cruza ccojoyo");
                tryingToCross = false;
            }
        }


        // if (gameObject.CompareTag("NPC1") || gameObject.CompareTag("NPC2") && npc1 == true)
        // {
        //   Invoke("NPC1", animStarDelay);
        //    npc1 = false;
        // }

        if (gameObject.CompareTag("NPC1") && go == true)
        {
            Vector3 direction = goal1.position - transform.position;
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }

        if (gameObject.CompareTag("NPC2") && go == true)
        {
            Vector3 direction = goal2.position - transform.position;
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }


        //if (gameObject.CompareTag("NPC3") && npc3 == true)
        //{
        //   NPC2();
        //  npc3 = false;
        // }

        if (rotation == true)
        {
            transform.LookAt(North.position);
           
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
        
        anim.SetTrigger("Walk");
        
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

    IEnumerator SITUATION2()
    {
         yield return new WaitForSeconds(12.40f);
        anim.SetTrigger("Situ2_2");
         yield return new WaitForSeconds(2.41f);
        anim.SetTrigger("Situ2_3");
        yield return new WaitForSeconds(25);
        anim.SetTrigger("Run");
        print("ahora es");

    }

    IEnumerator lookat1()
    {
        
        yield return new WaitForSeconds(1);

        transform.LookAt(North.position);
        print("deberia de mirar a la calle");

        yield return new WaitForSeconds(5);
       

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Desicion") && gameObject.CompareTag("NPC1"))
        {
            gameObject.transform.position = ReturnNPC1.transform.position;
            if (sitiation1 == 1)
            {
                reramdonCrossDesicion();
            }
            
        }

        if (other.gameObject.CompareTag("Gates") && gameObject.CompareTag("NPC2"))
        {
            gameObject.transform.position = ReturnNPC2.transform.position;
            reramdonCrossDesicion();
            if (sitiation1 == 1)
            {
                
            }

            if (canDestroy == true)
            {
                Destroy(gameObject);
            }
           
        }

        if (other.gameObject.CompareTag("West") && sitiation1 == 1 && crossDesicion ==2 )
        {
            tryingToCross = true;
            go = false;
            anim.SetTrigger("Idle");
            rotation = true;
            print(transform.rotation.eulerAngles);
            Destroy(other.gameObject);
            tryingToCross = true;
            StartCoroutine(lookat1());
        }

        if (other.gameObject.CompareTag("West") && sitiation2 == 1 && crossDesicion == 2)
        {
            go = false;
            anim.SetTrigger("Situ2_1");

            StartCoroutine(SITUATION2());
            Destroy(other.gameObject);
            canDestroy = true;
           
        }

        if (other.gameObject.CompareTag("Stop"))
            
        {
            menuManager.NPC12.GetComponent<NPCmovement>().lookat = true;
            anim.SetTrigger("Idle");
            rotation90 = true;
            
           

        }

        


    }








}
