using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;

    void Start()
    {

    }

    void OnGUI()
    {
        if (slider.value <= 100)
        {
            GUI.Label(new Rect(10, 10, 100, 20), "You got too frustrated. Press R to Try Again");
        }
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }

    public void DecreaseHealth(int health)
    {
        slider.value -= health;
    }
}
