using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JigsawSuccessButton : MonoBehaviour
{
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
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        Debug.Log("button");
        SceneManager.LoadScene("Login_Failed");
    }

    public void onClick()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        SceneManager.LoadScene("Login_Failed");
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
