using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
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
        distance = Vector3.Distance(player.position, transform.position);

        //Area de Seguridad: Más lento cerca del Player
        if (distance <= range)
        {
            speed = maxSpeed / 2;
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }

        else
        {
            //Reset de Velocidad
            speed = maxSpeed;

            //Perseguir al Player normal
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {

        }
    }
    public void Kill()
    {
        Destroy(gameObject);
    }

    public void TakeDamage(float dmg)
    {
        health -= dmg;

        if (health <= 0)
        {
            Kill();
        }
    }
}