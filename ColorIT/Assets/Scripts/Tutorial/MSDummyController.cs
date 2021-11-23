using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wilberforce;

public class ColorSelectionPicker
{
    public static int[] colorPickers = new int[3];
    public static int[] answers = new int[3];
    public static int pointer = 0;
    public static float[,] coordinates = new float[,]{ { -0.75f, -0.5f }, { -0.75f, -2.25f }, { 0.75f, -0.5f }, { 0.75f, -2.25f }, { 2.25f,-0.5f }, { 2.25f, -2.25f } };
    public static int attempts = 3;

    public static void generateNewPick() {
        pointer = 0;
        attempts = 3;
        System.Random rnd = new System.Random();
        for (int i = 0; i < 3; i++) {
            int number = rnd.Next(0, 2);
            colorPickers[i] = number;
            //Debug.Log(colorPickers[i]);

            switch (i) {
                case 0:
                    answers[i] = (number == 0) ? 1 : 2;
                    break;
                case 1:
                    answers[i] = (number == 0) ? 2 : 0;
                    break;
                case 2:
                    answers[i] = (number == 0) ? 3 : 4;
                    break;
            }
        }
    }
}

public static class ColorSelectionGenerator {
    public static int[] colors = new int[5];
    public static void generateNewColorSelection() {
        List<int> tmpColors = new List<int>();
        System.Random rnd = new System.Random();

        while (tmpColors.Count < 5) {
            int number = rnd.Next(0, 5);
            if (!tmpColors.Contains(number)) {
                tmpColors.Add(number);
            }

        }

        colors = tmpColors.ToArray();

    }
}

public class MSDummyController : MonoBehaviour
{
    public GameObject[] iconArray;
    public GameObject Window;
    public Colorblind camera;

    int frameCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        ColorSelectionGenerator.generateNewColorSelection();
        camera.Type = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (frameCount <= 500) {
            if (frameCount == 240) {
                Window.SetActive(true);
            }
            if (frameCount == 270)
            {
                iconArray[1].SetActive(true);
            }
            if (frameCount == 290)
            {
                iconArray[0].SetActive(true);
            }
            if (frameCount == 310)
            {
                iconArray[2].SetActive(true);
            }
            frameCount++;
        }
    }
}
