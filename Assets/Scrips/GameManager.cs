using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static float puntaje;

    private void Update()
    {
        if (puntaje >= 12)
        {
            SceneManager.LoadScene("PlatformScene");
            puntaje = 0;
        }
    }

    [SerializeField]
    private bool gameRunning;

    public void ChangedGameRunningState()
    {
        gameRunning = !gameRunning;

        if (gameRunning)
        {
            Time.timeScale = 1f;

            AudioSource[] audios = FindObjectsOfType<AudioSource>();
            foreach (AudioSource a in audios)
            {
                a.Play();
            }
        }
        else
        {
            Time.timeScale = 0f;

            AudioSource[] audios = FindObjectsOfType<AudioSource>();
            foreach (AudioSource a in audios)
            {
                a.Pause();
            }
        }
    }

    public bool IsGameRunning()
    {
        return gameRunning;
    }
}
