using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wilberforce;

public class BlindnessChangerT : MonoBehaviour
{
    public CAPTCHARenderer cAPTCHARenderer;
    public Colorblind camera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setColorBlindness()
    {
        if (camera != null) {
            camera.Type = (int)ColorBlindnessType.Tritanopia;
        }
        if (cAPTCHARenderer != null) {
            cAPTCHARenderer.RenderCaptcha(ColorBlindnessType.Tritanopia);
        }
    }
}
