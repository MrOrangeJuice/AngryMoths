using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wilberforce;
public class CAPTCHARenderer : MonoBehaviour
{
    public Sprite[] characterSpriteArray;
    public Sprite[] backgroundSpriteArray;
    public readonly StringCAPTCHA captcha = new StringCAPTCHA();
    public Colorblind camera;
    private ColorBlindnessType savedBlindnessType = ColorBlindnessType.Normal;

    private int GetCharacterSpriteInArray(char character,ColorBlindnessType type,int offset = 0){
        int COLORS = 5;
        int spriteOffsetInArray = ((int)character - (int)'A') * COLORS + ColorPalettes.getSpriteOffset(type,offset);
        return spriteOffsetInArray;
    }



    public void ResetCaptcha()
    {
        captcha.generateNewString();
        RenderCaptcha(savedBlindnessType);
    }

    public void RenderCaptcha(ColorBlindnessType renderBlindness = ColorBlindnessType.Normal) {
        savedBlindnessType = renderBlindness;
        Transform[] allChildren = GetComponentsInChildren<Transform>();
        foreach (Transform child in allChildren) {
            // Debug.Log(child.gameObject.name);
            switch (child.gameObject.name[0]) {
                case 'A':
                    {
                        // Characters
                        string[] components = child.gameObject.name.Split('.');
                        int characterOrderIndex = int.Parse(components[1]);


                        char charater = captcha.characters[characterOrderIndex];
                        ColorBlindnessType blindnessType = captcha.colorBlindnessTypes[characterOrderIndex];
                        int backgroundOffset = captcha.backgroundColorOffset[characterOrderIndex];
                        int spriteIndex = GetCharacterSpriteInArray(charater, blindnessType, backgroundOffset.Rev());
                        SpriteRenderer renderer = child.gameObject.GetComponent<SpriteRenderer>();
                        renderer.sprite = characterSpriteArray[spriteIndex];
                    }
                    
                    
                    break;
                case 'B':
                    {
                        string[] components = child.gameObject.name.Split('.');
                        int characterOrderIndex = int.Parse(components[1]);
                        ColorBlindnessType blindnessType = captcha.colorBlindnessTypes[characterOrderIndex];
                        int backgroundOffset = captcha.backgroundColorOffset[characterOrderIndex];
                        int spriteIndex = GetCharacterSpriteInArray('A', blindnessType, renderBlindness == blindnessType?
                             backgroundOffset.Rev(): backgroundOffset);
                        SpriteRenderer renderer = child.gameObject.GetComponent<SpriteRenderer>();
                        renderer.sprite = backgroundSpriteArray[spriteIndex];
                    }
                    break;
                case 'C':
                    break;
            }
        }
    }

    int cheatCodeIndex = 0;
    UnityEngine.KeyCode[] cheatCode = { KeyCode.C, KeyCode.O, KeyCode.L, KeyCode.O, KeyCode.R, KeyCode.I, KeyCode.T };

    // Start is called before the first frame update
    void Start()
    {
        savedBlindnessType = (ColorBlindnessType)camera.Type;
        ResetCaptcha();
        
    }

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
}
