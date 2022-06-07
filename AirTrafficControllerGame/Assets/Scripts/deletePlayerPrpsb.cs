using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class deletePlayerPrpsb : MonoBehaviour
{
    public void deleteData()
    {
        Debug.Log("game data have been deleted!");
        PlayerPrefs.DeleteAll();
    }
}
