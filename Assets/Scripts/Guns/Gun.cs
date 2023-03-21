using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage;
    public float speed;
    public float cooldown;
    float currentCooldown;
    public int penetration;

    public GameObject bulletPrefab = null;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        currentCooldown = cooldown; 
    }

    void Update()
    {
        currentCooldown -= Time.deltaTime;
       
        //Once the cooldown becomes 0, attack
        if (Input.GetButtonDown("Q") && currentCooldown <= 0f)   
        {
            Shoot();
            currentCooldown = cooldown;
        }
    
    }

    void Shoot()
    {
        GameObject bullet =  Instantiate(bulletPrefab);

        //Copia posición de padre
        bullet.transform.position = transform.position;

    }
}