using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int life = 5;
    public bool enemy;
    public bool puntaje;


    public void TakeDamage(int damage)
    {
        life -= damage;
        if (life <= 0)
        {
            Destroy(gameObject);

            if (enemy && puntaje)
            {

            }

        }
    }
}
