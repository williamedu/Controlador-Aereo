using UnityEngine;
using System.Collections;

public class MoveCam : MonoBehaviour
{

    Vector2 touchDeltaPosition;
    public float speed;
    public bool x;
    public bool y;
    public static bool canMoveCam = true;
    //public bool canmoveCanCheck = true;
    public float height = 1f;
    public float width = 1f;
    public bool test = false;

    Vector2 lockRight = new Vector2(10.4f, -152.8f);



    void Start()
    {
        canMoveCam = true;
        print(transform.rotation.eulerAngles.y);
    }

    private void Update()
    {
       /* if (canMoveCam == true)
        {
            canmoveCanCheck = true;
        }
        else
        {
            canmoveCanCheck = false;
        }

        if (gameObject.transform.rotation.eulerAngles.y >= 210)
        {

        }
       */

        if (Input.GetMouseButtonUp(0))
        {
            y = false;
        }

        if (Input.GetMouseButtonUp(1))
        {
            x = false;
        }

        if (x == true && y == true)
        {
            speed = 0;
        }
        if (Input.GetMouseButton(0) && x == false)
        {
            // speed = 2;
            // y = true;
            // float pointer_x = Input.GetAxis("Mouse Y");
            // gameObject.transform.Rotate(-pointer_x * speed, 0, 0);
            // -pointer_y * 0.5f, 0);
        }

        if (Input.GetMouseButton(1) && y == false && canMoveCam == true)
        {
            print("si estoy aqui");
            speed = 2;
            x = true;
            float pointer_y = Input.GetAxis("Mouse X");
            gameObject.transform.Rotate(0, pointer_y * speed, 0);
            //float pointer_x = Input.GetAxis("Mouse X");
            //transform.Translate(-pointer_x * 0.5f,
            // -pointer_y * 0.5f, 0);

        }
        else
        {
            print("no la puedes mover");
        }


        if (Input.GetMouseButton(1) && Input.GetMouseButton(0))

        {
            /*
            speed = 0;
        }
        if (Input.touchCount == 1)
        {
            Touch touchZero = Input.GetTouch(0);
            if (touchZero.phase == TouchPhase.Moved)
            {
                touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                gameObject.transform.Rotate(touchDeltaPosition.y * .05f, -touchDeltaPosition.x * .4f, 0);
            }
        }
                */
        }


    }

}

    
        

