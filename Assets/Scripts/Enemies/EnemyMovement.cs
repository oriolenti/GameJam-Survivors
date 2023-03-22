using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    Transform player;
    public float health;
    public int damage;
    public float speed;
    public float maxSpeed;
    public float distance;
    public float range;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>().transform;
    }

    void Update()
    {
        //Detectar rango con Player
        Vector2 thisToPlayer = player.transform.position - this.transform.position;

        float calculatedSpeed = thisToPlayer.magnitude <= range ? speed / 2f : speed;

        rb.AddForce(calculatedSpeed * thisToPlayer.normalized, ForceMode2D.Force);
    }

    public void Kill()
    {
        Destroy(gameObject);
    }

    public void TakeDamage(float dmg, Vector2 pushDir)
    {
        health -= dmg;
        rb.AddForce(pushDir, ForceMode2D.Impulse);
        if (health <= 0)
        {
            Kill();
        }
    }
}