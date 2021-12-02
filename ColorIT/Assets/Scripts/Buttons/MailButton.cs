using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailButton : MonoBehaviour
{
    public GameObject loginFailedWindow;
    public GameObject mailWindow;
    public Texture2D cursor;

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
        loginFailedWindow.SetActive(false);
        mailWindow.SetActive(true);
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
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
