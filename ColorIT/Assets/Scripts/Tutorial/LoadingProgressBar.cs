using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Wilberforce;

public class LoadingProgressBar : MonoBehaviour
{

    float maxXScale = 16.2f;
    float scale = 0;
    float inteval = 0.015f;
    int count = 0;
    public Colorblind camera;
    int waitTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        camera.Type = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (waitTime < 90) {
            waitTime++;
            return;
        }

        if (scale >= 4.0f) {
            inteval = 0.03f;
        }

        if (scale >= 9.0f)
        {
            inteval = 0.065f;
        }

        Vector3 currentScale = this.transform.localScale;
        currentScale.x = scale + inteval;
        if (scale + inteval <= maxXScale)
        {
            scale += inteval;
            this.transform.localScale = currentScale;
        }
        else {
            count++;
            if (count >= 180) {
                SceneManager.LoadScene("OS_Main_Scene");
            }
        }


    }
}
