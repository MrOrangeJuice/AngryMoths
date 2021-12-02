using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public Image image;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(5f);
        StartCoroutine(FadeImage(image));
        StartCoroutine(FadeText(text));
    }

    IEnumerator FadeImage(Image img)
    {
        // fade from opaque to transparent

        // loop over 1 second backwards
        for (float i = 1; i >= 0; i -= Time.deltaTime / 3)
        {
            // set color with i as alpha
            img.color = new Color(1, 1, 1, i);
            yield return null;
        }

    }

    IEnumerator FadeText(Text txt)
    {
        // fade from opaque to transparent

        // loop over 1 second backwards
        for (float i = 1; i >= 0; i -= Time.deltaTime / 3)
        {
            // set color with i as alpha
            txt.color = new Color(0, 0, 0, i);
            yield return null;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
