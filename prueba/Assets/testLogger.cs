using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testLogger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("print", 2f);
        Invoke("debug", 2f);
        Invoke("warning",4f);
        Invoke("error", 6f);
    }

   void debug()
    {
        Debug.Log("JBU pushing back from b1");
       // CancelInvoke();
    }

    void warning()
    {
        Debug.LogWarning("JBU casi colisiona con otro avion");
        //CancelInvoke();
    }

    void error()
    {
        Debug.LogError("JBU choco con otra aeronave se acabo el ejercicio");
        //CancelInvoke();
    }

    void print()
    {
      print("hola mundo");
        //CancelInvoke();
    }
}
