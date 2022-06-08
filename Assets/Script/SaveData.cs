using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveData : MonoBehaviour
{

    // Envia la Informacion a la nube

    //Inputs
    public TMP_InputField FloatInput;
    public TMP_InputField IntInput;
    public Toggle BoolInput;
    public TMP_InputField StringInput;


    // Aplicado al boton de cambiar de escena
    public void Save()
    {
        //Define que dato pertenece a cada variable de la nube
        string _StringInput = StringInput.text;
        string _FloatInput = FloatInput.text;
        string _IntInput = IntInput.text;

        DataPersistance.shareInstance.FloatData = _FloatInput;
        DataPersistance.shareInstance.IntData = _IntInput;
        DataPersistance.shareInstance.BoolDatal = BoolInput;
        DataPersistance.shareInstance.StringData = _StringInput; ;
    }
}
