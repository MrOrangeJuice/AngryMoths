using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnCaptchaRefresher : MonoBehaviour
{
    public CAPTCHARenderer cAPTCHARenderer;
    public void ButtonOnClick() {
        cAPTCHARenderer.ResetCaptcha();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
