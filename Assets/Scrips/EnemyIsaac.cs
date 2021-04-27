using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIsaac : MonoBehaviour
{
    public float speed = 3f;
    public int timeToDestroy = 5;
    public bool isUp, isDown, isDer, isIzqu;
    void Start()
    {
        if (isUp)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = transform.up * speed;
            Destroy(gameObject, timeToDestroy);
        }

        if (isDown)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = transform.up * -speed;
            Destroy(gameObject, timeToDestroy);
        }

        if (isDer)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
            Destroy(gameObject, timeToDestroy);
        }

        if (isIzqu)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = transform.right * -speed;
            Destroy(gameObject, timeToDestroy);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
