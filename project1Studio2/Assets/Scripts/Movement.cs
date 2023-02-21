using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;

    public float sprint = 20f;

    Vector2 direction;

    public GameObject bullet;

    public float bulletSpeed;

    public Transform ShootPoint;

    public float roationSpeed;


   
    void Update()
    {
       


        Vector2 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey("q"))
        {
            pos.y += sprint * Time.deltaTime;
        }

        transform.position = pos;
    }

     
}
