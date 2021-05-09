using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static float puntaje;
    public GameObject pause;

    private void Start()
    {
        gameRunning = true;
        Time.timeScale = 1f;
    }
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
                pause.SetActive(false);
            }
            
        }
        else
        {
            Time.timeScale = 0f;

            AudioSource[] audios = FindObjectsOfType<AudioSource>();
            foreach (AudioSource a in audios)
            {
                a.Pause();
                pause.SetActive(true);
            }
            
        }

    }

    public bool IsGameRunning()
    {
        return gameRunning;
    }
}
