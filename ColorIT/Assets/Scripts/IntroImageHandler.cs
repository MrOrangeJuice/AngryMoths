using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroImageHandler : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;

    public bool changeImage;

    // Start is called before the first frame update
    void Start()
    {
        image1.SetActive(true);
        image2.SetActive(false);
        image3.SetActive(false);
        ImageChanger();
    }

    // Update is called once per frame
    void Update()
    {
       

        
    }
    IEnumerator Wait()
    {
        
        yield return new WaitForSeconds(5);
        changeImage = true;
        
    }
    public void ImageChanger()
    {
        StartCoroutine(Wait());

        if (changeImage && image1.activeSelf == true)
        {
            image1.SetActive(false);
            image2.SetActive(true);
            image3.SetActive(false);
            changeImage = false;
            StartCoroutine(Wait());
            if (changeImage && image2.activeSelf == true)
            {
                image1.SetActive(false);
                image2.SetActive(false);
                image3.SetActive(true);
            }
        }
    }

}
