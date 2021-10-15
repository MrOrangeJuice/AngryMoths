using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wilberforce;
using System;

// The ColorBlindnessType defined in the plugin
public enum ColorBlindnessType {
    Normal,
    Protanopia,
    Deuteranopia,
    Tritanopia,
}


public static class Extensions
{
    public static int Count(this ColorBlindnessType type) {
        // Return the overall item counts in the enum
        return Enum.GetNames(typeof(ColorBlindnessType)).Length;
    }

    public static ColorBlindnessType Next(this ColorBlindnessType type) {
        // Return the next ColorBlindnessType in the enum, in a loop
        // Checking if new value outbounds the value, set it back to zero if it does
        int newType = ((int)type + 1 >= type.Count()) ? 0 : (int)type + 1;
        return (ColorBlindnessType)newType;
    }
}

public class ButtonController : MonoBehaviour{


    public Colorblind camera;
    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update() {

    }
    
    public void setColorBlindness() {

        // Get the button text from the button
        TMPro.TextMeshProUGUI textBox = GetComponentInChildren<TMPro.TextMeshProUGUI>();
        // Get the next ColorBlindnessType
        ColorBlindnessType newType = ((ColorBlindnessType)camera.Type).Next();
        // Set the text and the value of camera
        camera.Type = (int)newType;
        textBox.text = newType.ToString();
    }

}
    