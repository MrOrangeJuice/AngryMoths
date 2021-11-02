using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageHandler : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;

 /*   public bool changeImage;
    public bool goToImage2 = false;
    public bool goToImage3 = false;
    // Start is called before the first frame update*/
    void Start()
    {
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        StartCoroutine(FadeImage(image1));
        yield return new WaitForSeconds(5);
        StartCoroutine(FadeImage(image2));
    }

    IEnumerator FadeImage(Image img)
    {
        // fade from opaque to transparent
       
            // loop over 1 second backwards
            for (float i = 1; i >= 0; i -= Time.deltaTime/3)
            {
                // set color with i as alpha
                img.color = new Color(1, 1, 1, i);
                yield return null;
            }
        
    }

        // Update is called once per frame
        void Update()
    {
  
    }
  
}

