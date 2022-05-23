using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{

    public TMP_InputField _InputInt;
    public TMP_InputField _InputFloat;
    public Toggle _InputBool;
    public TMP_InputField _InputString;

    
    public int ResultInt;
    public float ResultFloat;


    private void Start()
    {
        ResultFloat = float.Parse(_InputFloat.text);
        ResultFloat = int.Parse(_InputInt.text);

        SaveData();

    }


    public void SaveData()
    {

        DataPersistance.sharedInstance.InputFloat = ResultFloat;
        DataPersistance.sharedInstance.InputInt = ResultInt;
        DataPersistance.sharedInstance.InputBool = _InputBool;
        DataPersistance.sharedInstance.InputString = _InputString.text;
    }

    // NO ME FUNCIONA EL CODIGO, ME RINDO :_(


    
}