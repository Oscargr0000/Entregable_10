using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetData : MonoBehaviour
{

    // Aplica los datos en la escena

    //Acceso a los lugares donde van los datos
    public TextMeshProUGUI FloatText;
    public TextMeshProUGUI IntText;
    public TextMeshProUGUI BoolText;
    public TextMeshProUGUI StringText;


    void Start()
    {
        //Cambia el texto por los datos guardados
        FloatText.text = DataPersistance.shareInstance.FloatData;
        IntText.text = DataPersistance.shareInstance.IntData;
        StringText.text = DataPersistance.shareInstance.StringData;
        BoolText.text = DataPersistance.shareInstance.BoolDatal.ToString();
    }
}
