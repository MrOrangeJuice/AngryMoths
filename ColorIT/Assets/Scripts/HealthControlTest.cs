using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthControlTest : MonoBehaviour
{

    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            healthBar.SetHealth(20);
        }
    }
}
