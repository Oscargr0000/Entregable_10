using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetData : MonoBehaviour
{
    private string NoData = "No Funciona";

    public TextMeshProUGUI floattext;
    public TextMeshProUGUI inttext;
    public TextMeshProUGUI booltext;
    public TextMeshProUGUI stringtext;
    // Start is called before the first frame update
    void Start()
    {
        floattext.text = NoData;
        inttext.text = NoData;
        booltext.text = NoData;
        stringtext.text = NoData;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
