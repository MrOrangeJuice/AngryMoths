using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCount : MonoBehaviour
{
    static public MainCount Instance;

    public int switchCount;
    public GameObject winText;

    private int onCount = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void SwitchChange(int points)
    {
        onCount = onCount + points;
        if(onCount == switchCount)
        {
            winText.SetActive(true);
        }
    }
}
