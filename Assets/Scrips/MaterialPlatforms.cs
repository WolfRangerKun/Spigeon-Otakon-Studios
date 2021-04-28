using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialPlatforms : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerControllerGabo player = other.GetComponent<PlayerControllerGabo>();

            player.materialPlatforms += 40;

            Destroy(gameObject);
        }
    }
}
