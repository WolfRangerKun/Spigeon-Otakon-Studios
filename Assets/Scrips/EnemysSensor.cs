using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysSensor : MonoBehaviour
{
    public ShootEnemy shootEnemy;
    public BulletEnemy bulletE;
    public Enemy enemy;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            shootEnemy.listo = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        shootEnemy.listo = false;

    }
}
