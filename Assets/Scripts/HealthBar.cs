using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(PlayerMovement playerdata)
    {
        
        slider.maxValue = playerdata.health;
        slider.value = playerdata.health;
    }

    public void SetHealth(float percentage)
    {
        slider.value = percentage * slider.maxValue;
    }
}