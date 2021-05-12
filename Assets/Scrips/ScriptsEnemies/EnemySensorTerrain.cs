using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySensorTerrain : MonoBehaviour
{
    public Enemy enemy;
    public AudioSource ruido;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enemy.following = true;
            ruido.Play();
        }

    }
}
