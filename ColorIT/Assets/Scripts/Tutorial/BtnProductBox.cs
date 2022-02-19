using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnProductBox : MonoBehaviour
{

    public GameObject [] windows;
    public Texture2D cursor;
    public GameObject[] otherObjects;

    void OnMouseEnter()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseDown()
    {
        foreach (GameObject window in windows)
        {
            window.SetActive(true);
        }

        foreach (GameObject button in otherObjects)
        {
            button.SetActive(false);
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
