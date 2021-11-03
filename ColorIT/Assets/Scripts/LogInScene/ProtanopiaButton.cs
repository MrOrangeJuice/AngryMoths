using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wilberforce;
using System;



// The ColorBlindnessType defined in the plugin




public class ProtanopiaButton : MonoBehaviour
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



        // Get the button text from the button
        TMPro.TextMeshProUGUI textBox = GetComponentInChildren<TMPro.TextMeshProUGUI>();
        // Get the next ColorBlindnessType
        ColorBlindnessType newType = ((ColorBlindnessType)camera.Type);
        // Set the text and the value of camera
        camera.Type = (int)newType;
        cAPTCHARenderer.RenderCaptcha(newType);
        textBox.text = newType.ToString();
        //textBox.text = textBox.text.AddColor(ColorPalettes.Tritanopia.colors[0]);
    }

}
