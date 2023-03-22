using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base script of all projectile behaviours [To be placed on a prefab of a weapon that is a projectile]
/// </summary>
public class BalaController : MonoBehaviour
{
    public float destroyAfterSeconds;

    //Current stats
    protected float currentDamage;
    protected float currentSpeed;
    protected float currentCooldownDuration;
    protected int currentPierce;

    [SerializeField] protected Rigidbody2D rb;

    public ParticleSystem particles;

    public void SetupData(WeaponController weaponData)
    {
        currentDamage = weaponData.damage;
        currentSpeed = weaponData.speed;
        currentCooldownDuration = weaponData.wait;
        currentPierce = weaponData.pierce;
    }

    protected virtual void Start()
    {
        rb.AddForce(this.transform.right * currentSpeed, ForceMode2D.Impulse);
        Destroy(gameObject, destroyAfterSeconds);
    }
    protected void OnCollisionEnter2D(Collision2D collision)
    {
        //Reference the script from the collided collider and deal damage using TakeDamage()
        if (collision.collider.CompareTag("Enemy"))
        {
            EnemyMovement enemy = collision.collider.gameObject.GetComponent<EnemyMovement>();
            enemy.TakeDamage(currentDamage, rb.velocity);     //Make sure to use currentDamage instead of weaponData.Damage in case any damage multipliers in the future
        }
        Destroy(particles, 0.5f);
        particles.transform.parent = null;
        particles.Play();
        Destroy(this.gameObject);
    }
}