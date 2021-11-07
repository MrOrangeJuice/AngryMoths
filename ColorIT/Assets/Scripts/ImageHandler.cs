using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ImageHandler : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;
    public GameObject startup;
    // Start is called before the first frame update*/
    void Start()
    {
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        //wait for 2 seconds before going to next image
        yield return new WaitForSeconds(2);
        //fade the first image
        StartCoroutine(FadeImage(image1));
        //first image takes 3 seconds to fade plus we need to wait for 2 seconds before we go to third image
        yield return new WaitForSeconds(5);
        //fade the second image
        StartCoroutine(FadeImage(image2));
        //wait on image 3 for sometime
        yield return new WaitForSeconds(5);
        startup.SetActive(true);
        yield return new WaitForSeconds(2);
        //load the scene containing first puzzle
        SceneManager.LoadScene("Tutorial_OSLoad");
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

