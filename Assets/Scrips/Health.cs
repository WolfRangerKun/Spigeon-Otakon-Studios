using System.Collections;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int life = 5;
    public bool enemy;
    public bool player;
    public bool nidoDeMonstruos;
    public GameObject materiasPlataforms;
    public GameManager game;
    public AudioSource explisoin;
    public AudioSource danoPlayer;
    public AudioSource danoEnemy;
    public void TakeDamage(int damage)
    {
        life -= damage;
        StartCoroutine(VisualDano());
        if (player)
        {
            danoPlayer.Play();
        }
        if (enemy || nidoDeMonstruos)
        {
            danoEnemy.Play();
        }
    }
    private GameManager gameManager;
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
                //sonidoMuerte.Play();
                game.muerte.SetActive(true);
            }

            if (nidoDeMonstruos)
            {
                NidoDeMonstruos.nidoDeMonstruosIsDead++;
                explisoin.Play();
            }

            Destroy(gameObject);

        }

    }

    IEnumerator VisualDano()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(.1f);
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
