using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    public GameObject bullet;
    public float timeToShoot = 3;
    public Transform twistPoint;
    public bool listo;
    public Enemy enemy;
    public float returnTime = .8f;

    public AudioSource sonidoDisparo;

    private void Start()
    {
        StartCoroutine(ShootingEnemy());
    }
    public void ShootBullet(Vector2 dir)
    {
        if (listo)
        {
            Aim();
            GameObject bulletGO = Instantiate(bullet, twistPoint.position, twistPoint.rotation);
            bulletGO.GetComponent<SpriteRenderer>().color = Color.blue;
            bulletGO.GetComponent<BulletEnemy>().target = "Player";
        }
    }
    IEnumerator ShootingEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToShoot);

            ShootBullet(enemy.directionFollow);
            sonidoDisparo.Play();
        }
    }

    public void Aim()
    {

        Vector3 angle = twistPoint.transform.localEulerAngles;

        //float HorizontalAxis = Input.GetAxis("HorizontalRightStick");
        //float VerticalAxis = Input.GetAxis("VerticalRightStick");

        float HorizontalMove = enemy.directionFollow.x;
        float VerticalMove = enemy.directionFollow.y;

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

}
