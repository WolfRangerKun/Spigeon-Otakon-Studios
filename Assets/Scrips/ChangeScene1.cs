using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene1 : MonoBehaviour
{
    public int NumeroDeEscena;
    public AudioSource click;

    public GameObject pantallaDeCarga;
    public Slider Slider;
    private void Start()
    {
       
    }
    public void CargarNivel(int NumeroDeEscena)
    {
        //SceneManager.LoadScene(NumeroDeEscena);
        click.Play();
        StartCoroutine(CargarAsync(NumeroDeEscena));
    }
    public void MainMenu(int NumeroDeEscena)
    {
        //SceneManager.LoadScene(NumeroDeEscena);
        click.Play();
        StartCoroutine(CargarAsync(NumeroDeEscena));
    }




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CargarNivel(NumeroDeEscena);
        }
    }

    public void ReiniciarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator CargarAsync(int NumerodeEscena)
    {

        AsyncOperation Operation = SceneManager.LoadSceneAsync(NumerodeEscena);
        //
        //SetactiveFalse
        //
        pantallaDeCarga.SetActive(true);

        while (!Operation.isDone)
        {
            float Progreso = Mathf.Clamp01(Operation.progress / .9f);
            Slider.value = Progreso;

            yield return null;
        }
    }
}