using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameMAnager : MonoBehaviour
{

    public static GameMAnager shareInstance;

    public TextMeshProUGUI floattext;
    public TextMeshProUGUI inttext;
    public TextMeshProUGUI booltext;
    public TextMeshProUGUI stringtext;

    private void Awake()
    {
        if (shareInstance == null)
        {
            shareInstance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        ApplyData();
    }

    public void ApplyData()
    {
        floattext.text = DataPersistance.sharedInstance.InputFloat.ToString();
        inttext.text = DataPersistance.sharedInstance.InputInt.ToString();
        booltext.text = DataPersistance.sharedInstance.InputBool.ToString();
        stringtext.text = DataPersistance.sharedInstance.InputString;
    }
}
