using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class readyForDeparture : MonoBehaviour
{
    public GameObject imagueChanger;
    public Sprite departure;
    public TextMeshProUGUI status;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CHANGEiMAGE()
    {
        imagueChanger.GetComponent<Image>().sprite = departure;
        
    }

    public void changeText()
    {
        status.text = ("Departing RWY 17");
    }
}
