using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using Wilberforce;

public class DragAndDrop_ : MonoBehaviour
{
    public Sprite[] Levels;
    public GameObject EndMenu;
    public GameObject SelectedPiece;
    public GameObject winText;
    public GameObject successScreen;
    int OIL = 1;    
    public int PlacedPieces = 0;

    public Colorblind camera;

    void Start()
    {
        for (int i = 0;i < 36; i++)
        {
            GameObject.Find("Piece (" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = Levels[PlayerPrefs.GetInt("Level")];
        }
        
    }

    int cheatCodeIndex = 0;
    UnityEngine.KeyCode[] cheatCode = { KeyCode.C, KeyCode.O, KeyCode.L, KeyCode.O, KeyCode.R, KeyCode.I, KeyCode.T };

    void Update()
    {

        if (Input.GetKeyDown(cheatCode[cheatCodeIndex]))
        {
            cheatCodeIndex++;
            if (cheatCodeIndex >= 7)
            {
                Debug.Log("CHEAT ENABLED");
                cheatCodeIndex = 0;
                camera.Type = 0;
                successScreen.SetActive(true);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<piceseScript>().InRightPosition)
                {
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<piceseScript>().Selected = true;
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OIL;
                    OIL++;
                }
            }
            else
            {
                return;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (SelectedPiece != null)
            {
                SelectedPiece.GetComponent<piceseScript>().Selected = false;
                SelectedPiece = null;
            }
        }
        if (SelectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x,MousePoint.y,0);
        }             
        if (PlacedPieces == 36)
        {
            //winText.SetActive(true);
            successScreen.SetActive(true);
        }
    }
}