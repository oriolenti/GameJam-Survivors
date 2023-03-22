using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base script for all weapon controllers
/// </summary>
public class WeaponController : MonoBehaviour
{
    public GameObject prefab;

    public float damage;
    public float speed;
    public float wait;
    float cooldown;
    public int pierce;

    protected PlayerMovement pm;

    protected virtual void Start()
    {
        pm = FindObjectOfType<PlayerMovement>();
        cooldown = wait; //At the start set the current cooldown to be cooldown duration
    }

    protected virtual void Update()
    {
        cooldown -= Time.deltaTime;
        if (cooldown <= 0f)   //Once the cooldown becomes 0, attack
        {
            Attack();
        }
    }

    protected virtual void Attack()
    {
        cooldown = wait;
    }
}