using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossStreth : MonoBehaviour
{
    public MenuManager menuManager;


    // Start is called before the first frame update
    void Start()
    {
        menuManager = GameObject.FindGameObjectWithTag("MenuManager").GetComponent<MenuManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerStay(Collider other)
    {
        menuManager.canCross = false;
        print("hya carros pasando");
    }

    private void OnTriggerExit(Collider other)
    {
        menuManager.canCross = true;
        print("se puede pasar");
    }
}
