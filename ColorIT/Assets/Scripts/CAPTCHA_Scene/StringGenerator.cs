using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StringExtensions { 
    public static string AddColor(this string text, Color col) => $"<color={ColorHexFromUnityColor(col)}>{text}</color>";
    public static string ColorHexFromUnityColor(this Color unityColor) => $"#{ColorUtility.ToHtmlStringRGBA(unityColor)}";
}

public static class IntExtensions {
    public static int Rev(this int num) {
        if (num == 1) return 0;
        if (num == 0) return 1;
        return num;
    }
}

public static class ColorPalettes
{
    public static class Protanopia
    {
        public static int[] spriteOffset = {1, 2};
    }

    public static class Deuteranopia
    {
        public static int[] spriteOffset = {0, 2};
    }

    public static class Tritanopia
    {
        public static int[] spriteOffset = {3, 4};
    }

    public static int getSpriteOffset(ColorBlindnessType type,int offset) {
        switch (type) {
            case ColorBlindnessType.Normal:
                return 0;
            case ColorBlindnessType.Protanopia:
                return ColorPalettes.Protanopia.spriteOffset[offset];
            case ColorBlindnessType.Deuteranopia:
                return ColorPalettes.Deuteranopia.spriteOffset[offset];
            case ColorBlindnessType.Tritanopia:
                return ColorPalettes.Tritanopia.spriteOffset[offset];
        }
        return 0;
    }
       
}

public class StringCAPTCHA {


    public readonly static int digits = 6;
    public readonly char[] characters = new char[digits];
    public readonly int[] backgroundColorOffset = new int[digits];

    private int CHAR_BEGIN = 65; // ascii code
    private int CHAR_END = 70;
    public readonly ColorBlindnessType[] colorBlindnessTypes = new ColorBlindnessType[6];

    public void generateNewString() {
        System.Random rnd = new System.Random();

        

        for (int i = 0; i < digits; i++) {
            // Set the colorblindness for each character
            ColorBlindnessType type = (ColorBlindnessType)rnd.Next(1, 4);
            colorBlindnessTypes[i] = type;

            int colorOffset = rnd.Next(0, 2);
            backgroundColorOffset[i] = colorOffset;
            characters[i] = (char)rnd.Next(CHAR_BEGIN, CHAR_END + 1);
        }
    }


    public StringCAPTCHA() {
        for (int i = 0; i < digits; i++) {
            colorBlindnessTypes[i] = ColorBlindnessType.Normal;
        }
        generateNewString();
    }

}


//public class StringGenerator : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}

//public static class ColorPalettes {
//    public static class Protanopia {
//        public static Color[] colors = {Tools.createColor(0x32, 0x88, 0x37), Tools.createColor(0xAD, 0x66, 0x27)};
//    }

//    public static class Deuteranopia {
//        public static Color[] colors = { Tools.createColor(0xD6, 0xAB, 0x80), Tools.createColor(0xF3, 0x9F, 0x93)};
//    }

//    public static class Tritanopia
//    {
//        public static Color[] colors = { Tools.createColor(0x64, 0xC6, 0xD4), Tools.createColor(0x6E, 0xC0, 0xF7), Tools.createColor(0x38, 0xD4, 0x3D) };
//    }
//}

//public static class Tools {
//    public static Color createColor(int r, int g, int b) { 
//        float R = (float)r / 255;
//        float G = (float)g / 255;
//        float B = (float)b / 255;
//        return new Color(R, G, B);
//    }
//}