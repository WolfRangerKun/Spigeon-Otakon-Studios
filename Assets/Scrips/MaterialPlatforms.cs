using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialPlatforms : MonoBehaviour
{
    public GridBuildingSystem2D grid;
    private void Start()
    {
        grid = FindObjectOfType<GridBuildingSystem2D>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            grid.limitPlatforms++;
            Destroy(gameObject);
        }
    }
}
