using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Transform Gun;

    Vector2 direction;

    public GameObject bullet;

    public float bulletSpeed;

    public Transform ShootPoint;

    public Animator gunAnimator;


    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)Gun.position;
        FaceMouse();

        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }

    }
    void FaceMouse()
    {
        Gun.transform.right = direction;
    }

    void shoot()
    {
        GameObject BulletIns = Instantiate(bullet, ShootPoint.position, ShootPoint.rotation);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(BulletIns.transform.right * bulletSpeed);
        gunAnimator.SetTrigger("shoot");
    }
}
