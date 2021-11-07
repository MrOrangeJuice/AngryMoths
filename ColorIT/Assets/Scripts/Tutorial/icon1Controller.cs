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
        //Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.7f;

    public GameObject window;

    private void OnMouseDown()
    {
        selectionArray[0].SetActive(false);
        selectionArray[1].SetActive(true);
        selectionArray[2].SetActive(false);

        clicked++;
        if (clicked == 1) clicktime = Time.time;

        if (clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;
            window.SetActive(true);
            foreach (GameObject button in otherButtons) {
                button.SetActive(false);
            }

        }
        else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;
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
