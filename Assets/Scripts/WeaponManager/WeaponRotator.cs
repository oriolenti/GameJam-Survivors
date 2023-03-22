using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        CalculateAngle();
    }

    private void CalculateAngle()
    {
        float x = Input.GetAxisRaw("HorizontalArrows");
        float y = Input.GetAxisRaw("VerticalArrows");
        if (Mathf.Abs(x) < 0.1f && Mathf.Abs(y) < 0.1f)
            return;

        float angle = Mathf.Atan2(y, x);
        Debug.Log(angle);

        this.transform.rotation = Quaternion.AngleAxis(angle * Mathf.Rad2Deg, Vector3.forward);
    }
}
