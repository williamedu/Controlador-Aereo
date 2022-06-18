using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressEnter : MonoBehaviour
{

    public GameObject afterMenu;
    public GameObject upBar;
    public GameObject GM;
    private void Update()
    {
        if (Input.anyKey)
        {
            GM.GetComponent<MenuManager>().checkdepthoffielday();
            afterMenu.SetActive(true);
            upBar.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
