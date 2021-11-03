using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Slider slider;
    public bool timerGoing;
    // Start is called before the first frame update
    void Start()
    {
        timerGoing = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartStopTimer(bool timerStartStop)
    {
        timerGoing = timerStartStop;
    }

    public void SetMaxTime(int max)
    {
        slider.maxValue = max;
        slider.value = max;
    }

    public void SetTime(int time)
    {
        slider.value = time;
    }
}
