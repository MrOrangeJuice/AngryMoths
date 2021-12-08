using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public Slider slider;
    public HealthBar healthbar;
    public bool timerGoing;
    private float nextActionTime = 1.0f;
    public float period = 1.0f;
    public bool counting = false;

    // Start is called before the first frame update
    void Start()
    {
        timerGoing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Game")
        {
            SetMaxTime(1000);
        }
        else
        {
            SetMaxTime(300);
        }
        if(slider.value <= 0)
        {
            healthbar.DecreaseHealth(10);
            slider.value = slider.maxValue;
        }
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            if(counting)
            {
                slider.value--;
            }
        }
    }

    public void StartStopTimer(bool timerStartStop)
    {
        timerGoing = timerStartStop;
    }

    public void SetMaxTime(int max)
    {
        slider.maxValue = max;
        //slider.value = max;
    }

    public void SetTime(int time)
    {
        slider.value = time;
    }

    public void SetCounter()
    {
        if(counting)
        {
            counting = false;
        }
        else if(!counting)
        {
            counting = true;
        }
    }
}
