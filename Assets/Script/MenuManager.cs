using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    private int InputInt;
    private float InputFloat;
    private bool InputBool;
    private string InputString;

    public void ReadInt(int i)
    {
        InputInt = i;
        Debug.Log(InputInt);
    }


    public void ReadFloat(float f)
    {
        InputFloat = f;
        Debug.Log(InputFloat);
    }

    public void ReadBool(bool b)
    {
        InputBool = b;
        Debug.Log(InputBool);
    }

    public void ReadString(string s)
    {
        InputString = s;
        Debug.Log(InputString);
    }
}
