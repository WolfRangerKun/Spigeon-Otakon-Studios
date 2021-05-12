using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoCaida : MonoBehaviour
{
    public bool isFalling;
    public Transform pie;
    public float radio = 0.6f;
    public LayerMask Suelo;
    public bool isInGround;
    public Rigidbody2D theBody;
    public float timeToDie = 0f;
    public int DañoAlCaer = 1;
    public Health health;

    public AudioSource sonidoCaida;
    private void Awake()
    {
        isFalling = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isInGround = Physics2D.OverlapCircle(pie.position, radio, Suelo);


        if(isInGround == false && theBody.velocity.y < 0)
        {
            isFalling = true;
            timeToDie += Time.deltaTime;
        }
        else if (isInGround)
        {
            isFalling = false;
            if(timeToDie >= 1.8f)
            {
                health.life -= DañoAlCaer;
                timeToDie = 0f;
                sonidoCaida.Play();
                
            }
        }
        else
        {
            timeToDie = 0f;
        }
    }
}
