using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistance : MonoBehaviour
{

    public static DataPersistance sharedInstance;


    public int InputInt;
    public float InputFloat;
    public bool InputBool;
    public string InputString;

    private void Awake()
    {
        if(sharedInstance = null)
        {
            sharedInstance = this;

            DontDestroyOnLoad(sharedInstance);
        }
        else
        {
            Destroy(this);
        }
    }
}
