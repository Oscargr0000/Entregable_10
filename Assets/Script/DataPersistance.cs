using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistance : MonoBehaviour
{
    public static DataPersistance shareInstance;

    //Esto es la nube

    //Datos guardados en esta
    public string FloatData;
    public string IntData;
    public bool BoolDatal;
    public string StringData;

    //Si existe otro script de DataPersistance sin datos lo borra y aplica los datos guardados
    private void Awake()
    {
        if (shareInstance == null)
        {
            shareInstance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
