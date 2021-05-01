using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDisparo8 : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb2D;
    public int damage = 1;
    public string target;

    // Start is called before the first frame update
    void Start()
    {
        rb2D.velocity = transform.right * speed;
        Destroy(gameObject, 3);
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
}
