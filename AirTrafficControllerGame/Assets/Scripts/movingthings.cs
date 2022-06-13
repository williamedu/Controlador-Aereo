using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingthings : MonoBehaviour
{

    public Vector3 Moveto;
    public int speed;
    public Transform goal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.LookAt(goal.position);
        Vector3 direction = goal.position - transform.position;
        if (direction.magnitude > 5) { transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World); }
        
    }
}
