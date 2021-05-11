using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource loop;
    public AudioSource inicio;
    public float duracionInicio;


    private void Start()
    {
        inicio.Play();

        loop.PlayDelayed(duracionInicio);
    }
}
