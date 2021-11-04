using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SubmitButton : MonoBehaviour
{
    public Button submitButton;
    public Canvas canvas;
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
        canvas.GetComponent<Canvas>().enabled = false;
        SceneManager.LoadScene("Wire_Game_Scene", LoadSceneMode.Additive);
    }
}
