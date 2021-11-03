using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragandDrop : MonoBehaviour
{
    public GameObject SelectedPiece;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if ( hit.transform.CompareTag("Puzzle"))
            {
                SelectedPiece = hit.transform.gameObject;
            }

            if (Input.GetMouseButtonUp(0))
            {
                SelectedPiece = null;
            }

            if (SelectedPiece != null)
            {
                Vector3 MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                SelectedPiece.transform.position = new Vector3(MousePosition.x, MousePosition.y, 0);
            }
        }
    }
}
