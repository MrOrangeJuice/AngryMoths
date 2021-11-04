using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("SubmitButton").GetComponentInChildren<Text>().text = "Submit";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
