using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wilberforce;

public class BlindnessChangerP : MonoBehaviour
{
    public CAPTCHARenderer cAPTCHARenderer;
    public Colorblind camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    int cheatCodeIndex = 0;
    UnityEngine.KeyCode[] cheatCode = { KeyCode.C, KeyCode.O, KeyCode.L, KeyCode.O, KeyCode.R, KeyCode.I, KeyCode.T };
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(cheatCode[cheatCodeIndex]))
        {
            cheatCodeIndex++;
            if (cheatCodeIndex >= 7)
            {
                Debug.Log("CHEAT ENABLED");
                cheatCodeIndex = 0;
                camera.Type = 0;
            }
        }
    }

    public void setColorBlindness()
    {
        if (camera != null)
        {
            camera.Type = (int)ColorBlindnessType.Protanopia;
        }
        if (cAPTCHARenderer != null)
        {
            cAPTCHARenderer.RenderCaptcha(ColorBlindnessType.Protanopia);
        }
    }
}
