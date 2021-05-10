using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleDamage : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Health health = other.GetComponent<Health>();
            health.TakeDamage(damage);
        }

    }
}
