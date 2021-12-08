using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthControlTest : MonoBehaviour
{

    public HealthBar healthBar;
    public Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        timer.SetCounter();
    }

    // Update is called once per frame
    void Update()
    {
        // Start and stop timer
        if(Input.GetKeyDown("space"))
        {
           timer.SetCounter();
        }

        if(Input.GetKeyDown("r"))
        {
            timer.SetTime(300);
            healthBar.SetHealth(100);
        }
    }
}
