using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector2 direction;
    public float speed;
    
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.right;
        rb = GetComponent<Rigidbody2D>();

       //SetBullet(direction, speed);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBullet(Vector2 dir, float spd)
    {
        direction = dir.normalized;
        speed = spd;

        rb.velocity = direction * speed;

    }
}
