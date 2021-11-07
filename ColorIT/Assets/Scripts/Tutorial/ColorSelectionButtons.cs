using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wilberforce;

public class ColorSelectionButtons : MonoBehaviour
{
    public int buttonIndex;
    int spriteIndex;

    public Sprite[] colorSprites;
    public Colorblind camera;

    public GameObject arrow;
    public GameObject ADOSWindow;
    public GameObject FailWindow;
    public GameObject SuccessfulWindow;
    public GameObject [] otherWindows;
    // Start is called before the first frame update

    void Start()
    {
        RefreshSprite();
 
    }

    void OnMouseDown()
    {
        int answer = ColorSelectionPicker.answers[ColorSelectionPicker.pointer];
        if (spriteIndex == answer)
        {
            // Correct, Change the pointer
            Debug.Log("Correct");
            ColorSelectionPicker.pointer++;
            if (ColorSelectionPicker.pointer >= 3)
            {
                SuccessfulWindow.SetActive(true);
                foreach (GameObject window in otherWindows)
                {
                    window.SetActive(false);
                }
            }
            else {
                int index = ColorSelectionPicker.pointer;
                int offset = ColorSelectionPicker.colorPickers[ColorSelectionPicker.pointer];
                arrow.transform.localPosition = new Vector3(ColorSelectionPicker.coordinates[2 * index + offset, 0], ColorSelectionPicker.coordinates[2 * index + offset, 1], -4.1f);
            }
            
        }
        else {
            Debug.Log("Wrong");
            ColorSelectionPicker.attempts--;
            if (ColorSelectionPicker.attempts == 0) {

                // Fail
                FailWindow.SetActive(true);
                ADOSWindow.SetActive(false);
            }
        }
    }

    public void RefreshSprite() {
        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        spriteIndex = ColorSelectionGenerator.colors[buttonIndex];
        renderer.sprite = colorSprites[spriteIndex];

        int renderSpriteIndex = spriteIndex;
        switch ((ColorBlindnessType)camera.Type) {
            case ColorBlindnessType.Protanopia:
                if (spriteIndex == 1) renderSpriteIndex = 2;
                break;
            case ColorBlindnessType.Deuteranopia:
                if (spriteIndex == 2) renderSpriteIndex = 0;
                break;
            case ColorBlindnessType.Tritanopia:
                if (spriteIndex == 4) renderSpriteIndex = 3;
                break;
        }
        renderer.sprite = colorSprites[renderSpriteIndex];
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
