using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButtonWI : MonoBehaviour
{
    public GameObject window;
    public Texture2D cursor;
    public GameObject[] otherButtons;

    void OnMouseEnter()
    {
        //Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
    void OnMouseDown()
    {
        foreach (GameObject button in otherButtons)
        {
            button.SetActive(true);
        }
        window.SetActive(false);
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
