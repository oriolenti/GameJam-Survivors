using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public float speed;
    public SpriteRenderer sr;
    public Animator animator;

    Vector2 movementDirection;

    Rigidbody2D rb;
    internal Vector3 lastMovedVector;

    protected float enemyDamage;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        movementDirection = new Vector2(moveX, moveY).normalized;

        rb.AddForce(movementDirection * speed, ForceMode2D.Force);
    }

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            health = health - 10;

            if (health <= 0)
            {
                Destroy(gameObject);
            }

        }
    }

}
