using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerGabo : MonoBehaviour
{
    [SerializeField]
    public float speed = 10f;
    public Transform spawn;
    public GameObject platform;
    public float jumpStreng = 5f;
    public Transform groundCheck;
    public float distanceFromTheFloor = .1f;
    Rigidbody2D rb2D;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Vector3 dir = Vector3.zero;
        //dir.y = (Mathf.Abs(Input.acceleration.y) > 0.1) ? -Input.acceleration.y : 0 ;
        dir.x = (Mathf.Abs(Input.acceleration.x) > 0.1f) ? Input.acceleration.x : 0;
        if (dir.sqrMagnitude > 1)
        {
            dir.Normalize();
        }

        dir *= Time.deltaTime;
        transform.Translate(dir * speed);
    }

    private void FixedUpdate()
    {
        if (Detection.isGrounded == true)
        {
            PlayerController player = GetComponent<PlayerController>();

            Jump();
        }
    }

    public void SpawnPlatform()
    {
        Instantiate(platform, spawn.position, Quaternion.identity);
    }

    public void Jump()
    {
        rb2D.velocity = new Vector2(rb2D.velocity.y, jumpStreng);
    }
}
