using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : WeaponController
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Attack()
    {
        base.Attack();
        GameObject spawnBala = Instantiate(prefab);
        spawnBala.transform.position = transform.position;
    }
}