using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public float speed = 10f;
    public Transform spawn;
    public GameObject platform;
    public float jumpStreng = 5f;
    public Transform groundCheck;
    public float distanceFromTheFloor = .1f;
    public LayerMask platforme;
    Rigidbody2D rb2D;


    public Joystick joystick;
    float horizontalMove;
    float verticalMove;


    public bool plataformaOn;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (plataformaOn)
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

        if (!plataformaOn)
        {
            verticalMove = joystick.Vertical * speed;
            horizontalMove = joystick.Horizontal * speed;

            transform.position += new Vector3(horizontalMove, verticalMove, 0) * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        if (plataformaOn)
        {
            if (Detection.isGrounded == true)
            {
                PlayerController player = GetComponent<PlayerController>();

                player.Jump();
            }
            
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
