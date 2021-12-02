using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class piceseScript : MonoBehaviour
{
    private bool coroutineAllowed;

    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;
    void Start()
    {
        coroutineAllowed = true;

        RightPosition = transform.position;
        // transform.position = new Vector3(Random.Range(5f, 9f), Random.Range(2.5f, -5));
        transform.position = new Vector3(Random.Range(6.5f, 11f), Random.Range(2.25f, -2.5f));
    }
    
    void Update()
    {
        if (Vector3.Distance(transform.position, RightPosition) < 0.5f)
        {
            if (!Selected)
            {
                if (InRightPosition == false)
                {
                    transform.position = RightPosition;
                    InRightPosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                    Camera.main.GetComponent<DragAndDrop_>().PlacedPieces++;
                }
            }
        }
    }

    private void OnMouseOver()
    {
        if (coroutineAllowed)
        {
            StartCoroutine("StartPulsating");
        }
    }

    private IEnumerator StartPulsating()
    {
        coroutineAllowed = false;

        for (float i = 0f; i <= 1f; i += 0.1f)
        {
            transform.localScale = new Vector3(
            (Mathf.Lerp(transform.localScale.x, transform.localScale.x + 0.017f, Mathf.SmoothStep(0f, 1f, i))),
            (Mathf.Lerp(transform.localScale.y, transform.localScale.y + 0.017f, Mathf.SmoothStep(0f, 1f, i))),
            (Mathf.Lerp(transform.localScale.z, transform.localScale.z + 0.017f, Mathf.SmoothStep(0f, 1f, i)))
            );

            yield return new WaitForSeconds(0.015f);
        }

        for (float i = 0f; i <= 1f; i += 0.1f)
        {
            transform.localScale = new Vector3(
            (Mathf.Lerp(transform.localScale.x, transform.localScale.x - 0.017f, Mathf.SmoothStep(0f, 1f, i))),
            (Mathf.Lerp(transform.localScale.y, transform.localScale.y - 0.017f, Mathf.SmoothStep(0f, 1f, i))),
            (Mathf.Lerp(transform.localScale.z, transform.localScale.z - 0.017f, Mathf.SmoothStep(0f, 1f, i)))
            );

            yield return new WaitForSeconds(0.015f);
        }

        coroutineAllowed = true;
    }
}
