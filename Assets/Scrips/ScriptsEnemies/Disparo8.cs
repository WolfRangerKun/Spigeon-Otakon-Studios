using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo8 : MonoBehaviour
{
    public Transform shoot1, shoot2, shoot3, shoot4, shoot5, shoot6, shoot7, shoot8;
    public Rigidbody2D bulletPrefab;
    public float bulletSpeed = 100f;
    public bool canFire = true;
    public AudioSource canon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canFire)
        {
            canFire = false;
            StartCoroutine(TimingShoot());
            Shoot();
        }
        
    }
    
    public void Shoot()
    {
        var bulletFired1 = Instantiate(bulletPrefab, shoot1.position, shoot1.rotation);
        bulletFired1.AddForce(shoot1.up * bulletSpeed);
        var bulletFired2 = Instantiate(bulletPrefab, shoot2.position, shoot2.rotation);
        bulletFired2.AddForce(shoot2.up * bulletSpeed);
        var bulletFired3 = Instantiate(bulletPrefab, shoot3.position, shoot3.rotation);
        bulletFired3.AddForce(shoot3.up * bulletSpeed);
        var bulletFired4 = Instantiate(bulletPrefab, shoot4.position, shoot4.rotation);
        bulletFired4.AddForce(shoot4.up * bulletSpeed);
        var bulletFired5 = Instantiate(bulletPrefab, shoot5.position, shoot5.rotation);
        bulletFired5.AddForce(shoot5.up * bulletSpeed);
        var bulletFired6 = Instantiate(bulletPrefab, shoot6.position, shoot6.rotation);
        bulletFired6.AddForce(shoot6.up * bulletSpeed);
        var bulletFired7 = Instantiate(bulletPrefab, shoot7.position, shoot7.rotation);
        bulletFired7.AddForce(shoot7.up * bulletSpeed);
        var bulletFired8 = Instantiate(bulletPrefab, shoot8.position, shoot8.rotation);
        bulletFired8.AddForce(shoot8.up * bulletSpeed);
        canon.Play();
    }

    IEnumerator TimingShoot()
    {
        yield return new WaitForSeconds(1f);
        canFire = true;
        yield break;
    }
}
