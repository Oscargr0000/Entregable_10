using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MenuManager()
    {
        SceneManager.LoadScene(0);
    }
    public void Data()
    {
        SceneManager.LoadScene(1);
    }
}
