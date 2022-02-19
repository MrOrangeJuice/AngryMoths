using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    // Start is called before the first frame update
    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.7f;

    //public void OnPointerClick(PointerEventData eventData)
    //{
    //    if (eventData.clickCount == 2)
    //    {
    //        Debug.Log("double click");
    //    }
    //}

    private void OnMouseDown()
    {
        selectionArray[0].SetActive(true);
        selectionArray[1].SetActive(false);
        selectionArray[2].SetActive(false);

        
        
        if (clicked == 0){
            clicked++;
            clicktime = Time.time;
        }else{
            float currentTime = Time.time;
            if (currentTime - clicktime < clickdelay){
                // Double Click Detected
                ColorSelectionPicker.generateNewPick();
                window.SetActive(true);
                Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
                int index = ColorSelectionPicker.colorPickers[0];
                arrow.transform.localPosition = new Vector3(ColorSelectionPicker.coordinates[index, 0], ColorSelectionPicker.coordinates[index, 1], -4.1f);
                foreach (ColorSelectionButtons button in colorButtons)
                {
                    button.RefreshSprite();
                }

                foreach (GameObject button in otherButtons)
                {
                    button.SetActive(false);
                }
            }
            clicktime = Time.time;
        }


    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
