using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wilberforce;
public class BT : MonoBehaviour
{
    public Colorblind camera;
    public Texture2D cursor;
    public CAPTCHARenderer cAPTCHARenderer;

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
        camera.Type = (int)ColorBlindnessType.Tritanopia;
        if (cAPTCHARenderer != null)
        {
            cAPTCHARenderer.RenderCaptcha(ColorBlindnessType.Tritanopia);
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
