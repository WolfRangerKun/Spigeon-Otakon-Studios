using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int life = 5;
    public bool enemy;
    public bool player;
    public bool nidoDeMonstruos;
    public GameObject materiasPlataforms;
    public GameManager game;
    public void TakeDamage(int damage)
    {
        life -= damage;
    }

    private void Update()
    {
        if (life <= 0)
        {

            if (enemy)
            {
                Instantiate(materiasPlataforms, transform.position, materiasPlataforms.transform.rotation);
            }

            if (player)
            {
                game.gameRunning = false;
                game.muerte.SetActive(true);
            }

            if (nidoDeMonstruos)
            {
                NidoDeMonstruos.nidoDeMonstruosIsDead++;
            }

            Destroy(gameObject);

        }
    }
}
