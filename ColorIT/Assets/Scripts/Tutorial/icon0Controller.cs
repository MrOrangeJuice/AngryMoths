using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icon0Controller : MonoBehaviour
{
    public GameObject[] selectionArray;
    public Texture2D cursor;

    public GameObject[] otherButtons;
    public GameObject window;

    public ColorSelectionButtons[] colorButtons;
    public GameObject arrow;

    void OnMouseEnter()
    {
        //Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    // Start is called before the first frame update
    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.7f;

    private void OnMouseDown()
    {
        selectionArray[0].SetActive(true);
        selectionArray[1].SetActive(false);
        selectionArray[2].SetActive(false);

        clicked++;
        if (clicked == 1) clicktime = Time.time;

        if (clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;

            ColorSelectionPicker.generateNewPick();
            window.SetActive(true);




            int index = ColorSelectionPicker.colorPickers[0];
            Debug.Log(index);
            arrow.transform.localPosition = new Vector3(ColorSelectionPicker.coordinates[index,0], ColorSelectionPicker.coordinates[index, 1], -4.1f);
            foreach (ColorSelectionButtons button in colorButtons)
            {
                button.RefreshSprite();
            }

            foreach (GameObject button in otherButtons)
            {
                button.SetActive(false);
            }
        }
        else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
