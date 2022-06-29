using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    public Image image;

    public Sprite Image1;
    public Sprite Image2;
    public Sprite Image3;
    public Sprite Image4;
    public Sprite Image5;
    public Sprite Image6;
    public Sprite Image7;
    public Sprite Image8;
    public Sprite Image9;

    public bool screenSelection = true;
    public int imageNumb;







    private void Awake()
    {
        
        ImageSelector();
    }



    // Start is called before the first frame update
    void Start()
    {
         
        if (screenSelection == true)
        {

            if (imageNumb == 1)
            {
                image.sprite = Image1;
                screenSelection = false;
            }


            if (imageNumb == 2)
            {
                image.sprite = Image2;
                screenSelection = false;
            }


            if (imageNumb == 3)
            {
                image.sprite = Image3;
                screenSelection = false;
            }


            if (imageNumb == 4)
            {
                image.sprite = Image4;
                screenSelection = false;
            }


            if (imageNumb == 5)
            {
                image.sprite = Image5;
                screenSelection = false;
            }


            if (imageNumb == 6)
            {
                image.sprite = Image6;
                screenSelection = false;
            }


            if (imageNumb == 7)
            {
                image.sprite = Image7;
                screenSelection = false;
            }

            if (imageNumb == 8)
            {
                image.sprite = Image8;
                screenSelection = false;
            }


            if (imageNumb == 9)
            {
                image.sprite = Image9;
                screenSelection = false;
            }



        }


    }

    

    void ImageSelector()
    {
        imageNumb = Random.Range(1, 9);
    }








}
