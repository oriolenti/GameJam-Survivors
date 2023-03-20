using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 10f;
    public SpriteRenderer sr;
    public Animator animator;

    Vector2 movementDirection;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { }

    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        movementDirection = new Vector2(moveX, moveY).normalized;

        rb.velocity = new Vector2(movementDirection.x * movementSpeed, movementDirection.y * movementSpeed);

    }

}
