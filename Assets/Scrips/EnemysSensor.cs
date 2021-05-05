using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysSensor : MonoBehaviour
{
    public ShootEnemy shootEnemy;
    public Enemy enemy;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            shootEnemy.listo = true;
            enemy.following = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        shootEnemy.listo = false;
        enemy.following = false;
    }
}
