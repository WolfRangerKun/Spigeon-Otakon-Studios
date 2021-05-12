using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialPlatforms : MonoBehaviour
{
    public GridBuildingSystem2D grid;
    public AudioSource popUpSound;
    public AudioSource popDownSound;
    private void Start()
    {
        grid = FindObjectOfType<GridBuildingSystem2D>();
        popUpSound.Play();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && grid.limitPlatforms < 4)
        {
            grid.limitPlatforms++;
            popDownSound.Play();
            Destroy(gameObject);
        }
    }
}
