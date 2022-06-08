using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFLow : MonoBehaviour
{
    // Cambio entre escenas
    public void ToData(int Scene)
    {
        SceneManager.LoadScene(Scene);
    }

    public void ToInput(int Scene)
    {
        SceneManager.LoadScene(Scene);
    }
}
