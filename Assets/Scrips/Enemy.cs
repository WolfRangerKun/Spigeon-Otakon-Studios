using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public bool following = true;
    public float speed = 2;
    public Vector2 directionFollow;
    private Rigidbody2D rb;
    public bool terrestEnemy;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {
        if (following && target != null)
        {
            DirectionToGo();
            //transform.Translate(directionFollow * speed * Time.deltaTime);
            rb.velocity = new Vector2(directionFollow.x, directionFollow.y) * speed * Time.fixedDeltaTime;
        }
        if (terrestEnemy)
        {
            if (directionFollow.x > 0)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
            if (directionFollow.x < 0)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
        }
        
    }
    public void DirectionToGo()
    {
        directionFollow = (target.position - transform.position).normalized;
    }
}
