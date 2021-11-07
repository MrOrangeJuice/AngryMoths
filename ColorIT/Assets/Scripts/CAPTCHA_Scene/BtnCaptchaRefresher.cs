using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnCaptchaRefresher : MonoBehaviour
{
    public CAPTCHARenderer cAPTCHARenderer;

    public Texture2D cursor;

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
        Debug.Log("Mouse");
        cAPTCHARenderer.ResetCaptcha();
    }

    public void ButtonOnClick() {
        cAPTCHARenderer.ResetCaptcha();
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
