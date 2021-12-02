using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SubmitButton : MonoBehaviour
{
    public Button submitButton;
    public Canvas canvas;
    public GameObject captcha;
    public Timer timer;
    public HealthBar healthbar;
    public GameObject[] otherObjects;
    public CAPTCHARenderer cAPTCHARenderer;
    public GameObject inputField;
    public GameObject wrongWindow;
    public GameObject[] disabledObjects;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = submitButton.GetComponent<Button>();
        btn.onClick.AddListener(ProgressToNextScene);
        GameObject.Find("SubmitButton").GetComponentInChildren<Text>().text = "Submit";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ProgressToNextScene()
    {
        //timer.SetTime(100);
        //healthbar.DecreaseHealth(-20);
        string text = inputField.GetComponent<TMP_InputField>().text;
        string code = cAPTCHARenderer.captcha.getString();
        Debug.Log(text);
        if (text.ToUpper() == code.ToUpper())
        {
            foreach (GameObject gameObject in otherObjects)
            {
                gameObject.SetActive(false);
            }

            canvas.GetComponent<Canvas>().enabled = false;

            Destroy(captcha);
            SceneManager.LoadScene("Game");
        }
        else {
            wrongWindow.SetActive(true);
            foreach (GameObject window in disabledObjects) {
                window.SetActive(false);
            }
        }


    }
}
