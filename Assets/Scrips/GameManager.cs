using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static float puntaje;
    public GameObject pause;
    public GameObject muerte;

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
    public bool gameRunning;
    public AudioSource clickEntry;
    public AudioSource clickExit;

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
                clickExit.Play();
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
                clickEntry.Play();
            }
            
        }

    }

    public bool IsGameRunning()
    {
        return gameRunning;
    }
}
