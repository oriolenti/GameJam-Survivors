using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class TestBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        HealthBarManager.SetHealthBarValue(1);
    }

    // Update is called once per frame
    void Update()
    {
        HealthBarManager.SetHealthBarValue(HealthBarManager.GetHealthBarValue() - 0.01f);
    }
}