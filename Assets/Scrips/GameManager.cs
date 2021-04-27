using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static float puntaje;

    private void Update()
    {
        if (puntaje >= 2)
        {
            SceneManager.LoadScene("PlatformScene");
        }
    }
}
