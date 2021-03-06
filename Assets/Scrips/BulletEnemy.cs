using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    public int damage = 1;
    public Vector2 direction;
    public float speed = 10;
    public string target;
    public float timeToDestroy = 3;
    Rigidbody2D rb2D;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        Destroy(gameObject, timeToDestroy);
        rb2D.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Health health = other.GetComponent<Health>();
            if (health == null)
                return;
            health.TakeDamage(damage);
            Destroy(gameObject);
        }
        if (other.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Walls"))
        {
            Destroy(gameObject);
        }

    }
    //private void Update()
    //{
    //    transform.Translate(direction * speed * Time.deltaTime);

    //}
    //public void DirectionBullet(Vector2 dir)
    //{
    //    direction = dir;
    //}
}
