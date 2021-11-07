using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wilberforce;
public class BP : MonoBehaviour
{
    public Colorblind camera;
    public Texture2D cursor;
    public CAPTCHARenderer cAPTCHARenderer;

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
        camera.Type = (int)ColorBlindnessType.Protanopia;
        if (cAPTCHARenderer != null)
        {
            cAPTCHARenderer.RenderCaptcha(ColorBlindnessType.Protanopia);
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
