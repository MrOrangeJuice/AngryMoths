using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class icon1Controller : MonoBehaviour
{
    public GameObject[] selectionArray;
    public Texture2D cursor;

    public GameObject [] otherButtons;

    void OnMouseEnter()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.7f;

    public GameObject window;
    public GameObject [] windows;

    private void OnMouseDown()
    {
        selectionArray[0].SetActive(false);
        selectionArray[1].SetActive(true);
        selectionArray[2].SetActive(false);


        if (clicked == 0){
            clicked++;
            clicktime = Time.time;
        }else{
            float currentTime = Time.time;
            if (currentTime - clicktime < clickdelay){
                // Double Click Detected
                Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
                window.SetActive(true);
                foreach (GameObject button in otherButtons) {
                    button.SetActive(false);
                }

                foreach (GameObject gameObject in windows) {
                    gameObject.SetActive(true);
                }

            }
            clicktime = Time.time;
        }        
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
