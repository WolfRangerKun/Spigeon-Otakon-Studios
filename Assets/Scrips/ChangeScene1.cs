using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene1 : MonoBehaviour
{
    public int NumeroDeEscena;
    public AudioSource click;
    private void Start()
    {
       
    }
    public void CargarNivel(int NumeroDeEscena)
    {
        SceneManager.LoadScene(NumeroDeEscena);
        click.Play();
    }
    public void MainMenu(int NumeroDeEscena)
    {
        SceneManager.LoadScene(NumeroDeEscena);
        click.Play();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CargarNivel(NumeroDeEscena);
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}