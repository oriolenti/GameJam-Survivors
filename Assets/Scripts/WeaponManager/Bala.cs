using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Bala : BalaController
{

    Gun kc;

    protected override void Start()
    {
        base.Start();
        kc = FindObjectOfType<Gun>();
    }

    void Update()
    {
        transform.position += direction * kc.speed * Time.deltaTime;    //Set the movement of the knife
    }
}