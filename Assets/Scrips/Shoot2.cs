using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot2 : MonoBehaviour
{
    public PlayerControllerGabo player;

    public Transform twistPoint;

    public Joystick joystick;

    public float returnTime = .8f;

    public Transform firePoint;

    public Rigidbody2D bulletPrefab;

    public float bulletSpeed = 100f;

    public int ammo = 1;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindObjectOfType<PlayerControllerGabo>();
    }

    // Update is called once per frame
    void Update()
    {
        Aim();
        if (joystick.Vertical != 0  && joystick.Horizontal != 0 && Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        //Shoot();
    }

    public void Aim()
    {
        Vector3 angle = twistPoint.transform.localEulerAngles;

        //float HorizontalAxis = Input.GetAxis("HorizontalRightStick");
        //float VerticalAxis = Input.GetAxis("VerticalRightStick");

        float HorizontalMove = joystick.Horizontal;
        float VerticalMove = joystick.Vertical;

        if (HorizontalMove == 0f && VerticalMove == 0F)
        {
            Vector3 currentRotation = twistPoint.transform.localEulerAngles;
            Vector3 homeRotation;

            if (currentRotation.z > 180f)
            {
                homeRotation = new Vector3(0f, 0f, 359.999f);
            }
            else
            {
                homeRotation = Vector3.zero;
            }

            twistPoint.transform.localEulerAngles = Vector3.Slerp(currentRotation, homeRotation, Time.deltaTime * returnTime);

        }
        else
        {
            twistPoint.transform.localEulerAngles = new Vector3(0f, 0f, Mathf.Atan2(HorizontalMove, VerticalMove) * -180 / Mathf.PI + 90F);
        }
    }

    public void Shoot()
    {
        var bulletFired = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bulletFired.AddForce(firePoint.up * bulletSpeed);
    }
}
