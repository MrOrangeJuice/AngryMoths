using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wilberforce;
public class Colorcode : MonoBehaviour
{

    public Sprite[] spriteArray;
    public Colorblind camera;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        ColorBlindnessType type = (ColorBlindnessType)camera.Type;
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        switch (type)
        {
            case ColorBlindnessType.Protanopia:
                renderer.sprite = spriteArray[0];
                break;
            case ColorBlindnessType.Deuteranopia:
                renderer.sprite = spriteArray[1];
                break;
            case ColorBlindnessType.Tritanopia:
                renderer.sprite = spriteArray[2];
                break;
        }
    }
}
