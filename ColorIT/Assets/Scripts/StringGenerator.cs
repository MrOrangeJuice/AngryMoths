using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StringExtensions
{
    public static string AddColor(this string text, Color col) => $"<color={ColorHexFromUnityColor(col)}>{text}</color>";
    public static string ColorHexFromUnityColor(this Color unityColor) => $"#{ColorUtility.ToHtmlStringRGBA(unityColor)}";
}

public static class ColorPalettes
{
    public static class Protanopia {
        public static Color[] colors = { Tools.createColor(0xDA,0x42,0x42), Tools.createColor(0x32, 0x88, 0x37), Tools.createColor(0xAD, 0x66, 0x27)};
    }

    public static class Deuteranopia
    {
        public static Color[] colors = { Tools.createColor(0xD6, 0xAB, 0x80), Tools.createColor(0xF3, 0x9F, 0x93)};
    }

    public static class Tritanopia
    {
        public static Color[] colors = { Tools.createColor(0x64, 0xC6, 0xD4), Tools.createColor(0x6E, 0xC0, 0xF7), Tools.createColor(0x38, 0xD4, 0x3D) };
    }
}

public static class Tools {
    public static Color createColor(int r, int g, int b)
    {
        float R = (float)r / 255;
        float G = (float)g / 255;
        float B = (float)b / 255;
        return new Color(R, G, B);

    }
}

public class StringCAPTCHA {



    public readonly string text = "";
    public readonly int digits = 6;

    public StringCAPTCHA() {
        System.Random rnd = new System.Random();



        for (int i = 1; i <= digits; i++) {
            int letterCase = rnd.Next(0, 1);
            switch (letterCase)
            {
                case 0:
                    {
                        char[] charater = { (char)rnd.Next(65, 91) };
                        text += new string(charater);
                     
                        break;
                    }

                case 1:
                    {
                        char[] charater = { (char)rnd.Next(97, 123) };
                        text += new string(charater);
                        break;
                    }

            }

        }
        Debug.Log(text);
    }

}

public class StringGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
