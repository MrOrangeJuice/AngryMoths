using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreenButtons : MonoBehaviour
{
    public Button start;
    // Start is called before the first frame update
    void Start()
    {
        start.onClick.AddListener(delegate { StartGame(); });
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Intro");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
