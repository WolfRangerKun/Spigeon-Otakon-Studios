using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    public GameObject bullet;
    public float timeToShoot = 3;
    public bool listo;

    private void Start()
    {
        StartCoroutine(ShootingEnemy());
    }
    void ShootBullet(Vector2 dir)
    {
        if (listo)
        {
            GameObject bulletGO = Instantiate(bullet, transform.position, Quaternion.identity);
            bulletGO.GetComponent<BulletEnemy>().DirectionBullet(dir);
            bulletGO.GetComponent<SpriteRenderer>().color = Color.blue;
            bulletGO.GetComponent<BulletEnemy>().target = "Player";
        }
    }
    IEnumerator ShootingEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToShoot);
            ShootBullet(GetComponent<Enemy>().directionFollow);
        }
    }
}
